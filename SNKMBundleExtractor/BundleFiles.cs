/*
 * Bundle class for storing the file structure for the PList files.
 * 
 * 
 * 
 */
using System.Text;

namespace SNKMBundleExtractor
{
    internal class BundleFiles
    {

        #region Fields

        public string BundleName
        {
            get; set;
        }

        public string Filename
        {
            get; set;
        }

        public int Offset
        {
            get; set;
        }

        public int Size
        {
            get; set;
        }

        #endregion

        public BundleFiles()
        {
            BundleName = string.Empty;
            Filename = string.Empty;
            Offset = 0;
            Size = 0;
        }

        public string MinimalToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("  Bundle Name: " + BundleName);
            sb.AppendLine("  File Name  : " + Filename);
            //sb.AppendLine("  Offset     : " + Offset);
            //sb.AppendLine("  Size       : " + Size);

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  Bundle Name: " + BundleName);
            sb.AppendLine("  File Name  : " + Filename);
            sb.AppendLine("  Offset     : " + Offset);
            sb.AppendLine("  Size       : " + Size);

            return sb.ToString();
        }
    }
}
