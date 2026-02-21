using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.General
{
    public static class Utility
    {
        private static string projectImagesFolder = @"C:\DVLD-People-Images\";
        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static bool CreateFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }

            return true;
        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            FileInfo fileInfo = new FileInfo(sourceFile);
            string extension = fileInfo.Extension;
            return GenerateGUID() + extension;
        }
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            if (!CreateFolder(projectImagesFolder))
            {
                return false;
            }

            string destinationFile = projectImagesFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
                sourceFile = destinationFile;
                return true;
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool DeleteFile(string sourceFile)
        {
            try
            {
                if (File.Exists(sourceFile))
                {
                    File.Delete(sourceFile);
                }
                return true;
            }
            catch (IOException iox)
            {
                return false;
            }
        }
    }
}