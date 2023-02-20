using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using MetadataExtractor.Formats.Jpeg;
using ExifLib;

namespace LearnASPNET
{
    public partial class ImageProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (ImageUpload.HasFile)
            {
                HttpPostedFile file = ImageUpload.PostedFile;
                if (file.ContentLength > 0)
                {
                    string fname = file.FileName;
                    string uploaded = Path.Combine(Server.MapPath("~/Images"), fname);
                    file.SaveAs(uploaded);
                    //GetImageProperties(uploaded);
                    MetadataExtr(uploaded);
                }
            }


        }

        private void GetImageProperties(string path)
        {
            using (var img = System.Drawing.Image.FromFile(path))
            {
                Response.Write($"\npath: {path}");

                Response.Write($"<br/>RawFormat: {img.RawFormat.ToString()}");
                Response.Write($"<br/>PhysicalDimension: {img.PhysicalDimension.ToSize().ToString()}");
                Response.Write($"<br/>Palette: {img.Palette.ToString()}");
                Response.Write($"<br/>PixelFormat: {img.PixelFormat.ToString()}");
                Response.Write($"<br/>Width: {img.Width} pxl Height: {img.Height} pxl");

                Response.Write($"<br/>HorizontalResolution: {img.HorizontalResolution} ppi");
                Response.Write($"<br/>VerticalResolution: {img.VerticalResolution} ppi");
                //using (FileStream fsimg = new FileStream("ImageJPG", FileMode.Create, FileAccess.ReadWrite))
                //{
                    
                //    img.Save(fsimg, ImageFormat.Jpeg);
                //}
            }
        }
        private void MetadataExtr(string filePath)
        {

           var directories =  JpegMetadataReader.ReadMetadata( filePath );

            foreach (var d in directories) {
                foreach (var t in d.Tags)
                {
                    Response.Write($"<br/>{t.DirectoryName} >> { t.Name} >> { t.Description}");
                } 
            }

            using (ExifReader reader = new ExifReader(filePath))
            {
                // Extract the tag data using the ExifTags enumeration
                DateTime datePictureTaken;
                if (reader.GetTagValue<DateTime>(ExifTags.DateTimeDigitized,
                                                out datePictureTaken))
                {
                    // Do whatever is required with the extracted information
                    Response.Write($"The picture was taken on {datePictureTaken}");
                }
            }
        }
    
    }
}