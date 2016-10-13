using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdobeConnectTool
{
    /// 
    /// The Login class is the controller for the form 
    /// that users login at and validates the login 
    /// information.
    /// 
    public partial class Login : Form
    {
        private bool _drag;
        private Point _firstPoint;

        public Login()
        {
            InitializeComponent();
            this.usernameTxtBox.Select();
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
        /// VALIDATE THE LOGIN INFORMATION
        ///
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = GetUsername();
            string password = GetPassword();
            if (username == "" || username == null)
            {
                MessageBox.Show("Invalid Username", "Login Error", MessageBoxButtons.OK);
            }
            else if (password == "" || password == null)
            {
                MessageBox.Show("Invalid Password", "Login Error", MessageBoxButtons.OK);
            }

            User user = new User(username, password);

            bool valid = user.Login();

            if (!valid)
            {
                MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Program._mainMenu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// 
        /// GET THE USERNAME FROM THE FORM
        ///
        public string GetUsername()
        {
            return this.usernameTxtBox.Text;
        }

        /// 
        /// GET THE PASSWORD FROM THE FORM
        ///
        public string GetPassword()
        {
            return this.passwordTxtBox.Text;
        }

        /// 
        /// ALLOW THE USER TO USE THE ENTER KEY TO LOGIN
        ///
        private void PasswordTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }
    }
}
