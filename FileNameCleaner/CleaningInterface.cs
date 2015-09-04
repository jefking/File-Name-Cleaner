using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileNameCleaner
{
    public partial class CleaningInterface : Form
    {
        #region Members
        //@"^(http|https)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~])*$";
        private const string UriRegex = @"w{3}\.\w+\.[a-zA-Z]{2,3}";
        private static readonly System.Text.RegularExpressions.Regex s_uriRegex = new System.Text.RegularExpressions.Regex(UriRegex
            , System.Text.RegularExpressions.RegexOptions.Singleline |
            System.Text.RegularExpressions.RegexOptions.Compiled |
            System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        private System.Windows.Forms.FolderBrowserDialog m_directoryBrowser;
		protected Microsoft.Win32.RegistryKey
			registry;
        #endregion

        #region Constructors
        public CleaningInterface()
        {
            InitializeComponent();
            this.m_directoryBrowser = new FolderBrowserDialog();
            this.registry = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\FileNameCleaner");
            this.SetDirectory(this.LastDirectory);
        }
        #endregion

        private void m_go_Click(object sender, EventArgs e)
        {
            if (this.m_removeUrls.Checked)
            {
                this.RenameFiles(new Rename(RemoveUrl));
            }
            if (this.m_doPrepend.Checked)
            {
                this.RenameFiles(new Rename(this.PrependText));
            }
            if (this.m_doAppend.Checked)
            {
                this.RenameFiles(new Rename(this.AppendText));
            }
            if (this.m_doReplace.Checked)
            {
                this.RenameFiles(new Rename(this.ReplaceFileName));
            }
            if (this.m_dashToSpaceDashSpace.Checked)
            {
                this.RenameFiles(new Rename(DashToSpaceDashSpace));
            }
            if (this.m_underscoreToSpace.Checked)
            {
                this.RenameFiles(new Rename(UnderScoreToSpace));
            }
            if (this.m_doubleSpace.Checked)
            {
                this.RenameFiles(new Rename(DoubleSpace));
            }
            if (this.m_camelCase.Checked)
            {
                this.RenameFiles(new Rename(CamelCase));
            }
            if (this.m_lowerCaseExtention.Checked)
            {
                this.RenameFiles(new Rename(LowerCaseExtention));
            }
            this.m_browser.Refresh();
        }
        private static string LowerCaseExtention(string FileName)
        {
            int periodIndex = FileName.LastIndexOf('.');
            return FileName.Substring(0, periodIndex) + FileName.Substring(periodIndex).ToLower();
        }
        private static string RemoveUrl(string FileName)
        {
            return s_uriRegex.Replace(FileName, string.Empty);
        }
        private static string DoubleSpace(string FileName)
        {
            return FileName.Replace("  ", " ");
        }
        private static string DashToSpaceDashSpace(string FileName)
        {
            return FileName.Replace("-", " - ");
        }
        private static string UnderScoreToSpace(string FileName)
        {
            return FileName.Replace('_', ' ');
        }
        private string ReplaceFileName(string FileName)
        {
            return FileName.Replace(this.m_replaceText.Text, this.m_withText.Text);
        }
        private string PrependText(string FileName)
        {
            return this.m_prependText.Text + FileName;
        }
        private string AppendText(string FileName)
        {
            return FileName + this.m_appendText.Text;
        }
        /// <summary>
        /// Camel Cases String replaceing Spaces
        /// </summary>
        /// <param name="format">String To Format</param>
        /// <returns>Formatted String</returns>
        public static string CamelCase(string format)
        {
            return CamelCase(format, ' ');
        }
        /// <summary>
        /// Camel Cases 
        /// </summary>
        /// <param name="format">String To Format</param>
        /// <param name="remove">Char To Remove</param>
        /// <returns>Formatted String</returns>
        public static string CamelCase(string format, char remove)
        {
            bool isFirst = true;
            System.Text.StringBuilder builder = new System.Text.StringBuilder(format.Length);
            foreach (char c in format)
            {
                if (isFirst)
                {
                    builder.Append(c.ToString().ToUpper());
                    isFirst = false;
                }
                else if (remove == c)
                {
                    isFirst = true;
                    builder.Append(c);
                }
                else
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
        private void RenameFiles(Rename renameDelegate)
        {
            this.Enabled = false;
            if (!(string.IsNullOrEmpty(this.m_directoryText.Text))
                && System.IO.Directory.Exists(this.m_directoryText.Text))
            {
                this.m_outputText.Text = string.Empty;
                System.Text.StringBuilder output = new StringBuilder();
                string FileFormat = "{0}\\{1}",
                    File;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(this.m_directoryText.Text);
                string tempFolderName = System.Guid.NewGuid().ToString();
                string moveTo = string.Format("{0}\\{1}", di.FullName, tempFolderName);
                System.IO.Directory.CreateDirectory(moveTo);
                string moveBack = this.m_directoryText.Text;
                foreach (System.IO.FileInfo fi in di.GetFiles(this.m_maskText.Text))
                {
                    try
                    {
                        string to = string.Format(FileFormat, moveTo, fi.Name);
                        fi.MoveTo(to);

                        File = renameDelegate(fi.Name);
                        File = string.Format(FileFormat
                            , di.FullName
                            , File);
                        if (File != fi.FullName)
                        {
                            File = File.Replace(tempFolderName, string.Empty);
                            File.Replace("\\\\", "\\");
                            output.AppendFormat("{0}->{1}{2}", fi.FullName, File, System.Environment.NewLine);
                            fi.MoveTo(File);
                            output.Append("Success.");
                            output.Append(System.Environment.NewLine);
                        }
                        else
                        {
                            output.AppendFormat("Name Won't Change: {0}", fi.FullName);
                            output.Append(System.Environment.NewLine);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        output.AppendFormat("Failure.{0}{1}{0}"
                            , System.Environment.NewLine
                            , ex.Message);
                    }
                }
                System.IO.Directory.Delete(moveTo);
                this.m_outputText.Text = output.ToString();
            }
            this.Enabled = true;
        }
        private delegate string Rename(string fileName);

        private void m_doReplace_CheckedChanged(object sender, EventArgs e)
        {
            this.m_withText.Enabled = this.m_replaceText.Enabled = this.m_doReplace.Checked;
        }

        private void m_directoryChooser_Click(object sender, EventArgs e)
        {
            if (string.Empty != this.m_directoryText.Text && System.IO.Directory.Exists(this.m_directoryText.Text))
            {
                this.SetDirectory(this.m_directoryText.Text);
            }
            if (System.Windows.Forms.DialogResult.OK == this.m_directoryBrowser.ShowDialog(this))
            {
                this.SetDirectory(this.m_directoryBrowser.SelectedPath);
            }
        }

        private void m_next_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(this.m_directoryText.Text);
            System.IO.DirectoryInfo[] directories = di.GetDirectories();
            if (0 < directories.Length)
            {
                this.SetDirectory(directories[0].FullName);
            }
            else
            {
                while (true)
                {
                    string startDirectory = this.m_directoryText.Text;
                    this.m_directoryText.Text = this.UpOneDir(this.m_directoryText.Text);

                    bool grabNext = false;
                    di = new System.IO.DirectoryInfo(this.m_directoryText.Text);
                    foreach (System.IO.DirectoryInfo dir in di.GetDirectories())
                    {
                        if (grabNext)
                        {
                            this.SetDirectory(dir.FullName);
                            return;
                        }
                        if (dir.FullName == startDirectory)
                        {
                            grabNext = true;
                        }
                    }
                }
            }
        }
        private bool ContainsDirectories(string dir)
        {
            return 0 < System.IO.Directory.GetDirectories(dir).Length;
        }
        private bool ContainsFiles(string dir)
        {
            return 0 < System.IO.Directory.GetFiles(dir, this.m_maskText.Text).Length;
        }
        private string UpOneDir(string currentDir)
        {
            if (currentDir.EndsWith("\\"))
            {
                currentDir = currentDir.Substring(0, currentDir.Length - 1);
            }
            return currentDir.Substring(0, currentDir.LastIndexOf('\\'));
        }

        private void m_doPrepend_CheckedChanged(object sender, EventArgs e)
        {
            this.m_prependText.Enabled = this.m_doPrepend.Checked;
        }

        private void m_doAppend_CheckedChanged(object sender, EventArgs e)
        {
            this.m_appendText.Enabled = this.m_doAppend.Checked;
        }
        private void SetDirectory(string dir)
        {
            this.LastDirectory = this.m_directoryText.Text = dir;
            this.m_browser.Navigate(dir);
        }

        #region Properties
        /// <summary>
        /// Last Directory File
        /// </summary>
        public string LastDirectory
        {
            set
            {
                if (null != this.registry)
                {
                    this.registry.SetValue("LastDirectory", value);
                }
            }
            get
            {
                if (null != this.registry)
                {
                    return (string)this.registry.GetValue("LastDirectory", string.Empty);
                }
                return string.Empty;
            }
        }
        #endregion
    }
}