using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerpScan.WiaWrapper
{
    public class WiaScan
    {
        public WIA.ImageFile Raw { get; protected set; }

        public WiaScan(WIA.ImageFile raw)
        {
            this.Raw = raw ?? new WIA.ImageFile();
        }

        public virtual byte[] GetBytes()
        {
            return (byte[])Raw.FileData.get_BinaryData();
        }

        public virtual System.IO.MemoryStream ToMemoryStream()
        {
            return new System.IO.MemoryStream(GetBytes());
        }

        public virtual System.Drawing.Image ToImage()
        {
            System.Drawing.Image image;
            using (var stream = ToMemoryStream())
            {
                image = System.Drawing.Image.FromStream(stream);
            }
            return image;
        }

        public virtual void Save(string path, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            using (var stream = ToMemoryStream())
            {
                using (var image = System.Drawing.Image.FromStream(stream))
                {
                    image.Save(path, imageFormat);
                }
            }
        }
    }
}
