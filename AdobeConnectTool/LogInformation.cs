using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeConnectTool
{
    /// 
    /// The LogInformation class is the controller for 
    /// the form that keeps track of information that 
    /// was not processed or did not need to be 
    /// processed.
    /// 
    public partial class LogInformation : Form
    {
        private bool _drag;
        private Point _firstPoint;
        private static TreeNode _mainNode;
        private TreeNode _success;
        private TreeNode _error;

        public LogInformation()
        {
            InitializeComponent();

            SetupTreeView();
        }

        private void SetupTreeView()
        {
            _mainNode = new TreeNode();
            _success = new TreeNode("Success");
            _error = new TreeNode("Error");

            _mainNode.Name = "mainNode";
            _mainNode.Text = "Log Report";
            this.treeView1.Nodes.Add(_mainNode);
            _mainNode.Nodes.Add(_success);
            _mainNode.Nodes.Add(_error);
        }

        ///////////////
        // Move Form //
        ///////////////

        /// 
        /// ENABLE DRAG WHILE THE MOURSE IS DOWN AND GATHER MOUSE LOCATION DATA
        ///
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
            _firstPoint = e.Location;
        }

        /// 
        /// MOVE THE FORM WHILE THE MOUSE IS DOWN AND MOVING
        ///
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                // Get the difference between the two points
                int xDiff = _firstPoint.X - e.Location.X;
                int yDiff = _firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        /// 
        /// STOP DRAG WHILE THE MOUSE IS UP
        ///
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }

        ///
        /// CLOSE ERROR LOG FORM
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// 
        /// ADD A LINE TO THE BODY OF THE TEXTBOX IN THE FORM
        /// 
        public static void AddLineToLogInformation(string type, string line)
        {
            TreeNode node = new TreeNode(line);
            if (type == "Success")
            {
                _mainNode.Nodes[0].Nodes.Add(node);
            }
            else
            {
                _mainNode.Nodes[1].Nodes.Add(node);
            }
        }

        /// 
        /// DOWNLOAD THE ERROR LOG AS A TEXT FILE
        ///
        private void logInformationDownloadBtn_Click(object sender, EventArgs e)
        {
            string treeNodeString = "Log Report\r\nSuccess\r\n";
            TreeNodeCollection tnc = _mainNode.Nodes[0].Nodes;
            
            foreach (TreeNode t in tnc)
            {
                treeNodeString += "- " + t.Text + "\r\n";
            }

            treeNodeString += "Error\r\n";

            tnc = _mainNode.Nodes[1].Nodes;

            foreach (TreeNode t in tnc)
            {
                treeNodeString += "- " + t.Text + "\r\n";
            }

            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Error_Log.txt", treeNodeString);
            MessageBox.Show("The file, Error_Log.txt, has been saved to your desktop.", "Download complete", MessageBoxButtons.OK);
        }

        private void logInformationContinueBtn_Click(object sender, EventArgs e)
        {
            Program._mainMenu.Show();
            this.Hide();
            MainMenu.Reset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
