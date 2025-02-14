using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        private Stack<string> BackStack = new Stack<string>();
        private Stack<string> ForwardStack = new Stack<string>();
        private string CurrentPath = "";

        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorerLoad(object sender, EventArgs e)
        {
            TreeView.Nodes.Clear();
            TreeNode root = new TreeNode("내 PC") { Tag = "" };
            TreeView.Nodes.Add(root);

            string drive = "C:\\";  // C 드라이브만 추가
            TreeNode node = new TreeNode(drive) { Tag = drive };
            node.Nodes.Add("@%");
            root.Nodes.Add(node);
            root.Expand();
        }

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
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = e.Node;
            if (current.Tag == null || string.IsNullOrEmpty(current.Tag.ToString()))
                return;

            string path = current.Tag.ToString();
            LoadFilesAndFolders(path);
        }

        private void LoadFilesAndFolders(string path)
        {
            if (!string.IsNullOrEmpty(CurrentPath))
                BackStack.Push(CurrentPath);

            CurrentPath = path;
            FilePath.Text = path;

            try
            {
                ListView.Items.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            if (BackStack.Count > 0)
            {
                ForwardStack.Push(CurrentPath);
                string previousPath = BackStack.Pop();
                LoadFilesAndFolders(previousPath);
            }
        }

        private void BeforeButtonClcik(object sender, EventArgs e)
        {
            if (ForwardStack.Count > 0)
            {
                BackStack.Push(CurrentPath); 
                string nextPath = ForwardStack.Pop();
                LoadFilesAndFolders(nextPath);
            }
        }

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = ListView.SelectedItems[0];
            string path = selectedItem.Tag.ToString();

            if (Directory.Exists(path))
            {
                LoadFilesAndFolders(path);  // 폴더 탐색
            }
            else if (File.Exists(path))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });  // 파일 열기
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일을 열 수 없습니다: " + ex.Message);
                }
            }
        }

        private void SearchClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentPath) || CurrentPath == "내 PC")
            {
                MessageBox.Show("먼저 검색할 폴더를 선택하세요.");
                return;
            }

            string keyword = SearchText.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("검색어를 입력하세요.");
                return;
            }

            try
            {
                ListView.Items.Clear();

                // 폴더 검색
                string[] directories = Directory.GetDirectories(CurrentPath, $"*{keyword}*");
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

                // 파일 검색
                string[] files = Directory.GetFiles(CurrentPath, $"*{keyword}*");
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

                if (ListView.Items.Count == 0)
                {
                    MessageBox.Show("검색 결과가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색 중 오류 발생: " + ex.Message);
            }
        }

    }
}
