/**
 *  File           Form1.cs
 *  Brief          Class for extracting mbundle file content used for the game SNK 40th Anniversary Collection (setup_snk_40th_anniversary_collection_1016_(64bit)_(45677).exe)
 *  Copyright      2025 Shawn M. Crawford [sleepy]
 *  Date           12/03/2025
 *
 *  Author         Shawn M. Crawford [sleepy]
 *
 */
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SNKMBundleExtractor
{
    public partial class Form1 : Form
    {
        private BundleFiles[] bundles;
        private int bundleFileIndex;
        private bool isBundleName;
        //private bool isFileName;
        private bool isFileOffset;
        private bool isFileSize;
        string bundleName;
        private string extractToDirPath;
        private string mainBundleName;
        private string dlcBundleName;
        private string patchBundleName;

        public Form1()
        {
            InitializeComponent();
            SetFormDefaults();

            // 2870 files in version: setup_snk_40th_anniversary_collection_1016_(64bit)_(45677)
            bundles = new BundleFiles[3000];

            bundleFileIndex = 0;
            bundles[bundleFileIndex] = new BundleFiles();
            isBundleName = false;
            //isFileName = false;
            isFileOffset = false;
            isFileSize = false;
            bundleName = "";
            extractToDirPath = "";
        }

        private void SetFormDefaults()
        {
            textBoxDLCBundle.Enabled = false;
            textBoxMainBundle.Enabled = false;
            textBoxPatchBundle.Enabled = false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonOpenFile_Click(sender, e);
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PLIST Files (plist)|*.plist";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string folder = Path.GetDirectoryName(filename);
                textBoxPListFile.Text = Path.GetFullPath(filename);

                try
                {
                    using (XmlReader reader = XmlReader.Create(filename))
                    {
                        while (reader.Read())
                        {
                            
                            if (reader.IsStartElement())
                            {
                                bundles[bundleFileIndex].BundleName = bundleName;
                                switch (reader.Name)
                                {
                                    case "plist":
                                        //Console.WriteLine("Start <plist> element.");
                                        break;
                                    case "dict":
                                        //Console.WriteLine("Start <dict> element.");
                                        break;
                                    case "key":
                                        //Console.WriteLine("Start <key> element.");
                                        if (reader.Read())
                                        {
                                            string value = reader.Value.Trim();

                                            if (value == "bundleName")
                                            {
                                                isBundleName = true;
                                            }

                                            if (value == "offset")
                                            {
                                                isFileOffset = true;
                                            }

                                            if (value == "size")
                                            {
                                                isFileSize = true;
                                            }

                                            if ((value != "bundles")
                                                && (value != "bundleName")
                                                && (value != "files")
                                                && (value != "offset")
                                                && (value != "size"))
                                            {
                                                // e.g. key reader.Value: ADAM.CG PRO.otf
                                                bundles[bundleFileIndex].Filename = value;
                                            }
                                        }
                                        break;
                                    case "array":
                                        //Console.WriteLine("Start <array> element.");
                                        break;
                                    case "string":
                                        //Console.WriteLine("Start <string> element.");
                                        if (reader.Read())
                                        {
                                            string value = reader.Value.Trim();

                                            if (isBundleName)
                                            {
                                                // e.g. string reader.Value: bundleMain.mbundle
                                                bundles[bundleFileIndex].BundleName = value;
                                                bundleName = value;
                                                isBundleName = false;

                                                // Set the read only textboxes with the names of the bundles from file in order
                                                if (string.IsNullOrEmpty(textBoxMainBundle.Text))
                                                {
                                                    textBoxMainBundle.Text = folder + "\\" + value;
                                                    mainBundleName = value;
                                                }
                                                else if (string.IsNullOrEmpty(textBoxDLCBundle.Text))
                                                {
                                                    textBoxDLCBundle.Text = folder + "\\" + value;
                                                    dlcBundleName = value;
                                                }
                                                else if (string.IsNullOrEmpty(textBoxPatchBundle.Text))
                                                {
                                                    textBoxPatchBundle.Text = folder + "\\" + value;
                                                    patchBundleName = value;
                                                }
                                            }
                                        }
                                        break;
                                    case "integer":
                                        //Console.WriteLine("Start <integer> element.");
                                        if (reader.Read())
                                        {
                                            string value = reader.Value.Trim();

                                            if (isFileOffset)
                                            {
                                                // e.g. integer reader.Value: 490134408
                                                if (int.TryParse(value, out int offset))
                                                {
                                                    bundles[bundleFileIndex].Offset = offset;
                                                }

                                                isFileOffset = false;
                                            }

                                            if (isFileSize)
                                            {
                                                // e.g. integer reader.Value: 40496
                                                if (int.TryParse(value, out int size))
                                                {
                                                    bundles[bundleFileIndex].Size = size;
                                                }

                                                isFileSize = false;

                                                // Size is the last field in the bundle read, increase to next bundle
                                                bundleFileIndex++;
                                                bundles[bundleFileIndex] = new BundleFiles();
                                            }
                                        }
                                        break;
                                    default:
                                        // Don't care
                                        break;
                                }
                            }
                            else
                            {
                                // Used for debuggin / testing end tags
                                switch (reader.Name)
                                {
                                    case "plist":
                                        //Console.WriteLine("End </plist> element.");
                                        break;
                                    case "dict":
                                        //Console.WriteLine("End </dict> element.");
                                        break;
                                    case "key":
                                        //Console.WriteLine("End </key> element.");
                                        break;
                                    case "array":
                                        //Console.WriteLine("End </array> element.");
                                        break;
                                    case "string":
                                        //Console.WriteLine("End </string> element.");
                                        break;
                                    case "integer":
                                        //Console.WriteLine("End </integer> element.");
                                        break;
                                    default:
                                        // Don't care
                                        break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception parsing PList: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // last bundle is not populated from file, just instantiated, so set it back to null to filter it out
                bundles[bundleFileIndex] = null;

                // Used for debugging
                //foreach (BundleFiles bundle in bundles)
                //{
                //    if (bundle != null)
                //    {
                //        Console.WriteLine(bundle.ToString());
                //    }
                //}

            }
        }

        private void ButtonExtractTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxExtractTo.Text = folderBrowserDialog.SelectedPath;
                extractToDirPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonExtract_Click(object sender, EventArgs e)
        {
            try
            {
                // Example:
                // Bundle Name: bundleMain.mbundle
                // File Name  : ASO.nes
                // Offset     : 490174910
                // Size       : 65552
                foreach (BundleFiles bundle in bundles)
                {
                    if (bundle != null)
                    {
                        //textBoxLog.AppendText("Extracting/Creating: " + Environment.NewLine + bundle.MinimalToString());
                        textBoxLog.AppendText("Extracting/Creating: " + Environment.NewLine + bundle.ToString());

                        if (bundle.BundleName == mainBundleName)
                        {
                            FileStream mainBundleFileStream = File.Open(textBoxMainBundle.Text, FileMode.Open);
                            string file = extractToDirPath + "\\" + bundle.Filename;
                            mainBundleFileStream.Seek(bundle.Offset, SeekOrigin.Begin);
                            byte[] rawbytes = new byte[bundle.Size];
                            mainBundleFileStream.Read(rawbytes, 0, bundle.Size);
                            FileStream fileStream = File.Create(file);
                            UTF8Encoding utf8 = new UTF8Encoding();
                            BinaryWriter binaryWriter = new BinaryWriter(fileStream, utf8);
                            binaryWriter.Seek(0, SeekOrigin.Begin);
                            binaryWriter.Write(rawbytes);
                            fileStream.Close();
                            mainBundleFileStream.Close();

                            Application.DoEvents();
                        }
                        else if (bundle.BundleName == dlcBundleName)
                        {
                            FileStream dlcBundleFileStream = File.Open(textBoxDLCBundle.Text, FileMode.Open);
                            string file = extractToDirPath + "\\" + bundle.Filename;
                            dlcBundleFileStream.Seek(bundle.Offset, SeekOrigin.Begin);
                            byte[] rawbytes = new byte[bundle.Size];
                            dlcBundleFileStream.Read(rawbytes, 0, bundle.Size);
                            FileStream fileStream = File.Create(file);
                            UTF8Encoding utf8 = new UTF8Encoding();
                            BinaryWriter binaryWriter = new BinaryWriter(fileStream, utf8);
                            binaryWriter.Seek(0, SeekOrigin.Begin);
                            binaryWriter.Write(rawbytes);
                            fileStream.Close();
                            dlcBundleFileStream.Close();

                            Application.DoEvents();
                        }
                        else if (bundle.BundleName == patchBundleName)
                        {
                            FileStream patchBundleFileStream = File.Open(textBoxPatchBundle.Text, FileMode.Open);
                            string file = extractToDirPath + "\\" + bundle.Filename;
                            patchBundleFileStream.Seek(bundle.Offset, SeekOrigin.Begin);
                            byte[] rawbytes = new byte[bundle.Size];
                            patchBundleFileStream.Read(rawbytes, 0, bundle.Size);
                            FileStream fileStream = File.Create(file);
                            UTF8Encoding utf8 = new UTF8Encoding();
                            BinaryWriter binaryWriter = new BinaryWriter(fileStream, utf8);
                            binaryWriter.Seek(0, SeekOrigin.Begin);
                            binaryWriter.Write(rawbytes);
                            fileStream.Close();
                            patchBundleFileStream.Close();

                            Application.DoEvents();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                textBoxLog.AppendText("Exception extracting files: " + ex);
            }

            textBoxLog.AppendText(Environment.NewLine + "Done" + Environment.NewLine);
            MessageBox.Show("Extraction Complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonExtract_Click(sender, e);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SNK 40th Anniversary Collection MBundle Extractor"
                + Environment.NewLine
                + "Author: Shawn M. Crawford [sLeEpY9090] 2025", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
