using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace NT106.O23_Lab02_25520353
{
    public partial class Lab2_Bai07 : Form
    {
        public Lab2_Bai07()
        {
            InitializeComponent();
            InitializeFileTreeView();
        }

        private void InitializeFileTreeView()
        {
            // Thiết lập TreeView để hiển thị cấu trúc thư mục
            treeView.Nodes.Clear();

            // Thêm ổ đĩa C
            DirectoryInfo rootC = new DirectoryInfo(@"C:\");
            TreeNode nodeC = CreateDriveNode(rootC);
            treeView.Nodes.Add(nodeC);

            // Thêm ổ đĩa D
            DirectoryInfo rootD = new DirectoryInfo(@"D:\");
            TreeNode nodeD = CreateDriveNode(rootD);
            treeView.Nodes.Add(nodeD);

            // Ẩn PictureBox ban đầu
            pictureBoxImage.Visible = false;
        }

        private TreeNode CreateDriveNode(DirectoryInfo drive)
        {
            TreeNode driveNode = new TreeNode(drive.Name);
            driveNode.Tag = drive.Root;
            LoadDirectories(drive.Root.FullName, driveNode);
            return driveNode;
        }

        private void LoadDirectories(string path, TreeNode parentNode)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    node.Tag = directory;
                    parentNode.Nodes.Add(node);
                    // Add a dummy node to the directory node
                    node.Nodes.Add("Expand");
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle unauthorized access to directories
            }
        }

        private void LoadFiles(string path, TreeNode directoryNode)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file;
                    directoryNode.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle unauthorized access to files
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Expand")
            {
                TreeNode parentNode = e.Node.Parent;
                if (parentNode != null)
                {
                    parentNode.Nodes.Clear();
                    LoadDirectories(parentNode.Tag.ToString(), parentNode);
                    LoadFiles(parentNode.Tag.ToString(), parentNode);
                }
            }
        }

        

       
    }
}
