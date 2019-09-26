using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace ScanBarcode
{
    public partial class GetForm : Form
    {
        SSMPositionManager mcssmmanager = new SSMPositionManager();
        Homeform home = new Homeform();

        public GetForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        //move and drag this borderless form
        private bool drag = false;
        private Point startP = new Point(0, 0);


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        /*public static GetForm getGetFormIns()
        {
            if (instanceGetForm == null || instanceGetForm.IsDisposed)
                instanceGetForm = new GetForm();
            else
                instanceGetForm.BringToFront();
            return instanceGetForm;
        }*/

        private void btnGet_Click(object sender, EventArgs e)
        {
            string text = mcssmmanager.GetID(tbID.Text);
            lblID.Text = text;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void GetForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void GetForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void GetForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            home.Show(); //show home
       }

        private void helpBtn_Click(object sender, EventArgs e)
        {

        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://warwick.ac.uk/fac/sci/wmg/about/");
        }

        //highlight textbox
        private void GetForm_Activated(object sender, EventArgs e)
        {
            tbID.Focus();
        }



        //move form around

    }
}
