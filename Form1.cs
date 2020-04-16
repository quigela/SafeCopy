using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SafeCopy
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> paths = new Dictionary<string, string>()
        {
            {"source", null},
            {"dest", null},
            {"backup", null}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowseSource_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(BtnBrowseSource, ListSource, LabelSource, "source");
        }

        private void BtnBrowseDest_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(BtnBrowseDest, ListDest, LabelDest, "dest");
        }

        private void BtnBrowseBackup_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(BtnBrowseBackup, null, LabelBackup, "backup");
        }

        private void BtnOperate_Click(object sender, EventArgs e)
        {
            paths.TryGetValue("source", out string sourcePath);
            paths.TryGetValue("dest", out string destPath);
            paths.TryGetValue("backup", out string backupPath);
            if (ContainsNullOrWhitespace(sourcePath, destPath, backupPath))
            {
                BtnOperate.Enabled = false;
                return;
            }
            
            BtnBrowseSource.Enabled = false;
            BtnBrowseDest.Enabled = false;
            BtnBrowseBackup.Enabled = false;
            BtnOperate.Enabled = false;

            Thread t = new Thread(() =>
            {
                DirUtils.DoOperation(sourcePath, destPath, backupPath, Log);
                Invoke((MethodInvoker)delegate
                {
                    Log("Done!");
                    BtnOperate.Enabled = true;
                });
            });
            t.Start();
        }

        private void BackupPreview()
        {
            paths.TryGetValue("source", out string sourcePath);
            paths.TryGetValue("dest", out string destPath);
            if (ContainsNullOrWhitespace(sourcePath, destPath)) { return; }

            Thread t = new Thread(() =>
            {
                string[] files = DirUtils.GetOverwriteItems(sourcePath, destPath);
                Invoke((MethodInvoker)delegate
                {
                    ListBackup.Items.Clear();
                });

                foreach (string s in files)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        ListBackup.Items.Add(s);
                    });
                }
                
            });
            t.Start();
            Log("Populating backup items...");
        }

        private void OperateCheck()
        {
            paths.TryGetValue("source", out string sourcePath);
            paths.TryGetValue("dest", out string destPath);
            paths.TryGetValue("backup", out string backupPath);

            if (ContainsNullOrWhitespace(sourcePath, destPath, backupPath))
            { 
                    BtnOperate.Enabled = false; 
                    return; 
            }

            Log("Ready to backup & overwrite");
            BtnOperate.Enabled = true;
        }

        private void StartBrowseOperation(Button browseButton, ListBox listPreview, Label labelPreview, string pathVar)
        {
            Thread t = new Thread(() =>
            {
                BrowseOperation(listPreview, labelPreview, pathVar);
                Invoke((MethodInvoker)delegate
                {
                    browseButton.Enabled = true;
                    BackupPreview();
                    OperateCheck();
                });
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            browseButton.Enabled = false;
        }

        private void BrowseOperation(ListBox preview, Label labelPath, string pathKey)
        {
            string path = DirUtils.SelectDirectory();
            if (path == null) { return; }

            Invoke((MethodInvoker)delegate {
                labelPath.Text = path;
                paths[pathKey] = path;
                if (preview != null) { preview.Items.Clear(); }
            });

            if (preview != null)
            {
                string[] files = DirUtils.GetSubItems(path, true);

                foreach (string s in files)
                {
                    //string reducedName = s.Replace(path, "");
                    Invoke((MethodInvoker)delegate {
                        preview.Items.Add(s);
                    });
                }
            }
        }

        private bool ContainsNullOrWhitespace(params string[] data)
        {
            //invert because we want True if not all strings return true from the 'NotIsNullOrEmpty' check
            return !(data.All(s => !string.IsNullOrWhiteSpace(s)));
        }

        private bool Log(string msg)
        {
            Invoke((MethodInvoker)delegate
            {
                TextLog.Text += "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + msg + "\n";
            });
            return true;
        }
    }
}
