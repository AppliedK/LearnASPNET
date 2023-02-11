using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadUploadedFiles();
            }


        }

        private void LoadUploadedFiles()
        {
            string saveFolder = Server.MapPath("~/Uploaded");
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(saveFolder);
            FileInfo[] fileinfos = di.GetFiles();
            var uploadedFiles = fileinfos.ToList();
            FilesListBox.DataSource = uploadedFiles;
            FilesListBox.DataBind();
        }
        protected void FileUpload1_Load(object sender, EventArgs e)
        {
            
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string saveFolder = Server.MapPath("~/Uploaded");
            if (!System.IO.Directory.Exists(saveFolder))
            {
                System.IO.Directory.CreateDirectory(saveFolder);
            }
            HttpFileCollection files = Request.Files;
            if (files.Count > 0)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    file.SaveAs(saveFolder+ "\\"+ file.FileName);
                }
            }
            LoadUploadedFiles();
        }

        protected void DeleteFile_Click(object sender, EventArgs e)
        {
            string saveFolder = Server.MapPath("~/Uploaded/");
            // check the items selected in listbox
            var s = FilesListBox.SelectedIndex.ToString();
            Response.Write("<h1>"+ s +"</h1>");
            if (FilesListBox.SelectedIndex !=-1)
            {
                var filename = FilesListBox.SelectedItem.Text;
                System.IO.File.Delete(saveFolder + filename);
                LoadUploadedFiles();
            }

        }
    }
}