using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanBarcode
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //prevent reopening new windows
        //private static Homeform instanceHomeForm;
        //GetForm getFormIns = new GetForm();

        private const int cGrip = 16;
        private const int cCaption = 32;

        //move and drag this borderless form
        private bool drag = false;
        private Point startP = new Point(0, 0);


        //prevent reopening new windows
        /*public static Homeform gethomeinstance() //used this instance with every button to open a new form
        {
            if (instanceHomeForm == null || instanceHomeForm.IsDisposed)
                instanceHomeForm = new Homeform();
            else
                instanceHomeForm.BringToFront();
            return instanceHomeForm;
        }*/

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

        private void getBarcodeform_Click(object sender, EventArgs e)
        {
            //getFormIns.Show();   
            GetForm openGetForm = new GetForm();
            openGetForm.ShowDialog();
            this.Visible = false;
           // this.Hide();
            this.Close();
            //this.Dispose();
        }

       private void create_Click(object sender, EventArgs e)
        {
            Create openCreate = new Create();
            openCreate.ShowDialog(); //show new form
            this.Visible = false;
            //this.Hide(); //hide current form
            //this.Close(); //close previous form
            this.Dispose();
        }

        public void aboutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://warwick.ac.uk/fac/sci/wmg/about/");
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {

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

        private void Homeform_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Homeform_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);
        }

        private void Homeform_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }

        }

        private void fbBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/wmgwarwick/");
        }

        private void linkdenBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/wmg-university-of-warwick");
        }

        private void Homeform_Load(object sender, EventArgs e)
        {

        }
    }
}
