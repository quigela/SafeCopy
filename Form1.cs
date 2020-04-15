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
        private Dictionary<string, string> paths = new Dictionary<string, string>()
        {
            {"source", null},
            {"dest", null},
            {"backup", null}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(btnBrowseSource, listSource, labelSource, "source");
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(btnBrowseDest, listDest, labelDest, "dest");
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            StartBrowseOperation(btnBrowseBackup, null, labelBackup, "backup");
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            string sourcePath, destPath, backupPath;
            paths.TryGetValue("source", out sourcePath);
            paths.TryGetValue("dest", out destPath);
            paths.TryGetValue("backup", out backupPath);
            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(destPath) ||
                string.IsNullOrWhiteSpace(backupPath)) { btnOperate.Enabled = false; return; }
            btnOperate.Enabled = false;

            Thread t = new Thread(() =>
            {
                DirUtils.DoOperation(sourcePath, destPath, backupPath, Log);
                Invoke((MethodInvoker)delegate
                {
                    Log("Done!");
                    btnOperate.Enabled = true;
                });
            });
            t.Start();
        }

        private void BackupPreview()
        {
            string sourcePath, destPath;
            paths.TryGetValue("source", out sourcePath);
            paths.TryGetValue("dest", out destPath);
            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(destPath)) { return; }

            Thread t = new Thread(() =>
            {
                string[] files = DirUtils.GetOverwriteItems(sourcePath, destPath);
                Invoke((MethodInvoker)delegate
                {
                    listBackup.Items.Clear();
                });

                foreach (string s in files)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        listBackup.Items.Add(s);
                    });
                }
                
            });
            t.Start();
            Log("Populating backup items...");
        }

        private void OperateCheck()
        {
            string sourcePath, destPath, backupPath;
            paths.TryGetValue("source", out sourcePath);
            paths.TryGetValue("dest", out destPath);
            paths.TryGetValue("backup", out backupPath);

            if (string.IsNullOrWhiteSpace(sourcePath) || 
                string.IsNullOrWhiteSpace(destPath) || 
                string.IsNullOrWhiteSpace(backupPath)) { btnOperate.Enabled = false; return; }

            Log("Ready to backup & overwrite");
            btnOperate.Enabled = true;
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

        private bool Log(string msg)
        {
            Invoke((MethodInvoker)delegate
            {
                textLog.Text += "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + msg + "\n";
            });
            return true;
        }
    }
}
