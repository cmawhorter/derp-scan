using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DerpScan.WiaWrapper
{
	public class WiaDevice
	{
		private WIA.Device device;
		private WiaPropertyMap properties;

		#region Properties
		public string DeviceID { get { return device.DeviceID; } }
		public string DeviceName { get { return properties.GetValue<string>(WiaProperty.WIA_DIP_DEV_NAME); } }

        public int DeviceSelect { get { return properties.GetValue<int>(WiaProperty.WIA_DPS_DOCUMENT_HANDLING_SELECT); } }
        public int DeviceStatus { get { return properties.GetValue<int>(WiaProperty.WIA_DPS_DOCUMENT_HANDLING_STATUS); } }

        public bool HasFeeder { get { return (DeviceSelect & WiaDef.FEEDER) != 0; } }
        public bool HasPagesWaiting { get { return HasFeeder && (DeviceStatus & WiaDef.FEED_READY) != 0; } }

        public int DPI { get; set; }
        public System.Drawing.Size PageSize { get; set; }
        private bool _duplex = false;
        public bool Duplex
        {
            get
            {
                return _duplex;
            }

            set
            {
                if (value && Supports(WiaDef.DUP)) _duplex = true;
                else _duplex = false;
                DocumentHandling = DocumentHandling;
            }
        }
        private int _documentHandling = -1;
        public int DocumentHandling
        {
            get
            {
                return _documentHandling;
            }

            set
            {
                if (HasFeeder) _documentHandling = WiaDef.FEEDER | (Duplex ? WiaDef.DUPLEX : 0);
                else _documentHandling = WiaDef.FLATBED;   
            }
        }
		#endregion

		#region Constructor/Acquire methods
		public WiaDevice(WIA.Device device)
		{
			this.device = device;
			properties = new WiaPropertyMap(device);

            this.DPI = 200;
            this.PageSize = new System.Drawing.Size(8500, 11000);
            this.Duplex = false;
		}

		public static WiaDevice ShowSelectionDialog()
		{
			var dialog = new WIA.CommonDialog();

			try
			{
				var d = dialog.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, true);
				if (d != null)
					return new WiaDevice(d);
			}
			catch (COMException ex)
			{
				switch ((uint)ex.ErrorCode)
				{
					case WiaDef.WIA_S_NO_DEVICE_AVAILABLE:
						throw new Exceptions.WiaNoDeviceAvailableException(ex);

					default:
                            throw new Exceptions.WiaException("Error selecting device:" +
                            System.Environment.NewLine + Exceptions.WiaException.ErrorMessageFromCode(ex.ErrorCode), ex.ErrorCode, ex);

				}
			}

			return null;
		}

		public static WiaDevice GetDeviceFromID(string deviceID)
		{
			var manager = new WIA.DeviceManager();

			foreach (WIA.DeviceInfo dev in manager.DeviceInfos)
				if (dev.DeviceID == deviceID)
					return new WiaDevice(dev.Connect());

			return null;
		}
		#endregion

        public bool Supports(int capability)
        {
            int capabilities = properties.GetValue<int>(WiaProperty.WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES);
            return (capabilities & capability) != 0;
        }

		/*internal object GetProperty(WiaProperty property)
		{
			return device.Properties.Cast<WIA.Property>().Single(prop => prop.PropertyID == (int)property).get_Value();
		}

		internal void SetProperty(WiaProperty property, object value)
		{
			device.Properties.Cast<WIA.Property>().Single(prop => prop.PropertyID == (int)property).set_Value(value);
		}*/

        public void SetPageSizeInInches(decimal width, decimal height) 
        {
            PageSize = new System.Drawing.Size((int)(Math.Round(width, 3) * 1000), (int)(Math.Round(height, 3) * 1000));
        }

        public IEnumerable<WiaScan> Scan()
        {
            var dialog = new WIA.CommonDialog();

            properties[WiaProperty.WIA_DPS_DOCUMENT_HANDLING_SELECT] = DocumentHandling;

            try
            {
                int pages = 0;
                while ((!HasFeeder && pages == 0) || HasPagesWaiting)
                {
                    pages++;
                    var item = (WIA.Item)device.Items[1];

                    var itemProperties = new WiaPropertyMap(item);
                    itemProperties[WiaProperty.WIA_IPA_DATATYPE] = 3;
                    itemProperties[WiaProperty.WIA_IPS_XRES] = DPI;
                    itemProperties[WiaProperty.WIA_IPS_YRES] = DPI;
                    var pageWidth = PageSize.Width * DPI / 1000;
                    var pageHeight = PageSize.Height * DPI / 1000;
                    var pageMaxWidth = properties.GetValue<int>(WiaProperty.WIA_DPS_HORIZONTAL_BED_SIZE) * DPI / 1000;
                    var pageMaxHeight = properties.GetValue<int>(WiaProperty.WIA_DPS_VERTICAL_BED_SIZE) * DPI / 1000;

                    var horizontalPos = pageMaxWidth - pageWidth;
                    pageWidth = Math.Min(pageWidth, pageMaxWidth);
                    pageHeight = Math.Min(pageHeight, pageMaxHeight);

                    itemProperties[WiaProperty.WIA_IPS_XEXTENT] = pageWidth;
                    itemProperties[WiaProperty.WIA_IPS_YEXTENT] = pageHeight;
                    itemProperties[WiaProperty.WIA_IPS_XPOS] = horizontalPos;

                    var img = Transfer(dialog, item);
                    if (img == null) break;
                    yield return new WiaScan(img);
                }
            }
            finally
            {
                
            }
        }

        protected WIA.ImageFile Transfer(WIA.CommonDialog dialog, WIA.Item item) 
        {
            WIA.ImageFile img = null;

            try
            {
                img = (WIA.ImageFile)dialog.ShowTransfer(item, /*WiaImageFormat.WiaImgFmt_BMP.ToString()*/"{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}", false);
            }
            catch (COMException ex)
            {
                switch ((uint)ex.ErrorCode)
                {
                    case WiaDef.WIA_ERROR_PAPER_EMPTY:
                        return null;

                    default:
                        throw new Exceptions.WiaException("An error occurred while scanning:" +
                            System.Environment.NewLine + Exceptions.WiaException.ErrorMessageFromCode(ex.ErrorCode), ex.ErrorCode, ex);
                }
            }

            return img;
        }
	}
}
