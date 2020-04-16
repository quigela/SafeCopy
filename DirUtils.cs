using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeCopy
{
    static class DirUtils
    {
        public static string[] GetSubItems(string path, bool stripBase = false)
        {
            string[] items = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            if (stripBase)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = items[i].Replace(path, "");
                }
                return items;
            }
            else
            {
                return items;
            }
        }

        public static string SelectDirectory(string initial)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (!string.IsNullOrWhiteSpace(initial))
                {
                    fbd.SelectedPath = initial;
                }
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }
            return null;
        }

        public static string[] GetOverwriteItems(string source, string dest)
        {
            string[] sourceFiles = GetSubItems(source, true);
            string[] destFiles = GetSubItems(dest, true);

            return sourceFiles.Intersect(destFiles, StringComparer.OrdinalIgnoreCase).ToArray<string>();
        }

        public static void DoOperation(string sourceDir, string destDir, string backupDir, Func<string, bool> log)
        {
            DoBackup(sourceDir, destDir, backupDir, log);
            DoCopy(sourceDir, destDir, log);
        }

        private static void DoCopy(string sourceDir, string destDir, Func<string, bool> log)
        {
            log("Copying files from source to dest...");
            try
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourceDir, destDir));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string sourcePath in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
                {
                    string destFile = sourcePath.Replace(sourceDir, destDir);
                    File.Copy(sourcePath, destFile, true);
                    File.SetAttributes(destFile, FileAttributes.Normal);
                }
            }
            catch (Exception e)
            {
                log("Error occured: " + e.Message);
            }
        }

        private static void DoBackup(string sourceDir, string destDir, string backupDir, Func<string, bool> log)
        {
            log("Calculating directory intersection...");
            string[] overwrite = GetOverwriteItems(sourceDir, destDir);
            log("Copying overlapping files from dest to backup...");

            foreach (string s in overwrite)
            {
                string file = destDir + s;
                string backupFile = backupDir + s;

                string backupSubDir = Path.GetDirectoryName(backupFile);
                if (!Directory.Exists(backupSubDir))
                {
                    Directory.CreateDirectory(backupSubDir);
                    log("Creating " + backupSubDir + "...");
                }
                try
                {
                    if (File.Exists(file))
                    {
                        File.Copy(file, backupFile, true);
                    }
                } 
                catch (Exception e)
                {
                    log("Error occured: " + e.Message);
                }
                
            }
        }
    }
}
