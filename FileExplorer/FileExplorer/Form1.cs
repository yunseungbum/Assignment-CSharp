using System;
using System.IO;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorerLoad(object sender, EventArgs e)
        {
            TreeNode root = TreeView.Nodes.Add("내 PC");
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode node = root.Nodes.Add(drive);
                node.Nodes.Add("@%"); 
            }
        }

        private void TreeViewBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode current = e.Node;
            if (current.Nodes.Count == 1 && current.Nodes[0].Text.Equals("@%"))
            {
                current.Nodes.Clear();
                

                try
                {
                    string path = current.FullPath.Substring(current.FullPath.LastIndexOf("\\") + 1);
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string directory in directories)
                    {
                        TreeNode newNode = new TreeNode(new DirectoryInfo(directory).Name);
                        newNode.Nodes.Add("@%");
                        current.Nodes.Add(newNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = e.Node;
            string path = current.FullPath.Replace("내 PC\\", "");
            FilePath.Text = path;

            try
            {
                ListView.Items.Clear();
                string[] directories = Directory.GetDirectories(path);

                foreach (string directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, "", "파일 폴더", info.LastWriteTime.ToString()
                    });

                    ListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {

        }

        private void BeforeButtonClcik(object sender, EventArgs e)
        {

        }
    }
}
