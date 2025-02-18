using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;


namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        private string CurrentPath = "";
        private Stack<string> BackStack = new Stack<string>();


        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorerLoad(object sender, EventArgs e)
        {
            TreeView.Nodes.Clear();
            TreeNode root = new TreeNode("내 PC");
            TreeView.Nodes.Add(root);

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name) { Tag = drive.Name };
                    node.Nodes.Add("@%");
                    root.Nodes.Add(node);
                }
            }
            root.Expand();
        }

        #region 이벤트

        private void TreeViewBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode current = e.Node;

            if (current.Nodes.Count == 1 && current.Nodes[0].Text.Equals("@%"))
            {
                current.Nodes.Clear();
                string path = current.Tag.ToString();

                try
                {
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string directory in directories)
                    {
                        TreeNode newNode = new TreeNode(Path.GetFileName(directory)) { Tag = directory };
                        newNode.Nodes.Add("@%");
                        current.Nodes.Add(newNode);
                    }
                }
                catch { }
            }
        }

        private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag?.ToString();
            if (!string.IsNullOrEmpty(path))
            {
                NavigateToPath(path);
            }
        }

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = ListView.SelectedItems[0];
            string path = selectedItem.Tag.ToString();

            if (Directory.Exists(path))
            {
                NavigateToPath(path);
            }
            else if (File.Exists(path))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일을 열 수 없습니다: " + ex.Message);
                }
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentPath) || CurrentPath == "C:\\")
                return;

            string parentPath = Directory.GetParent(CurrentPath)?.FullName;

            if (!string.IsNullOrEmpty(parentPath))
            {
                BackStack.Push(CurrentPath);
                NavigateToPath(parentPath);
            }
        }


        private void BeforeButtonClick(object sender, EventArgs e)
        {
            if (BackStack.Count > 0)
            {
                string previousPath = BackStack.Pop();
                NavigateToPath(previousPath);
            }
        }
        #endregion

        #region 메서드
        private void LoadFilesAndFolders(string path)
        {
            FilePath.Text = path;
            ListView.Items.Clear();

            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                foreach (string directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, "폴더", info.LastWriteTime.ToString(), ""
                    })
                    { Tag = directory };

                    ListView.Items.Add(item);
                }

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, "파일", info.LastWriteTime.ToString(), info.Length.ToString() + " bytes"
                    })
                    { Tag = file };

                    ListView.Items.Add(item);
                }
            }
            catch { }
        }

        private void NavigateToPath(string path)
        {
            CurrentPath = path;
            FilePath.Text = path;
            LoadFilesAndFolders(path);

            TreeNode foundNode = FindNodeByPath(TreeView.Nodes, path);
            if (foundNode != null)
            {
                TreeView.SelectedNode = foundNode;
                foundNode.Expand();
            }
        }

        private TreeNode FindNodeByPath(TreeNodeCollection nodes, string path)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag?.ToString() == path) return node;

                TreeNode found = FindNodeByPath(node.Nodes, path);
                if (found != null) return found;
            }
            return null;
        }

        #endregion


    }
}
