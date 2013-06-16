using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerpScan.WiaWrapper
{
    public class WiaScanTest : WiaScan
    {
        public System.Drawing.Image TestImage { get; set; }
        public System.Drawing.Imaging.ImageFormat TestImageFormat { get; set; }

        public WiaScanTest(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat imageFormat) : base(new WIA.ImageFile())
        {
            this.TestImage = image;
            this.TestImageFormat = imageFormat;
        }

        public override byte[] GetBytes()
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            TestImage.Save(stream, TestImageFormat);
            return stream.ToArray();
        }

        public override System.IO.MemoryStream ToMemoryStream()
        {
            return new System.IO.MemoryStream(GetBytes());
        }

        public override System.Drawing.Image ToImage()
        {
            return TestImage;
        }

        public override void Save(string path, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            TestImage.Save(path, imageFormat);
        }
    }
}
