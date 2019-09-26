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

    public partial class Create : Form
    {
        SSMPositionManager mcssmmanager = new SSMPositionManager();
        CheckedListBox acheckbox = new CheckedListBox();
        Homeform home = new Homeform();

        bool boolon = true;
        bool toggleLght = true;
        Timer t = new Timer();

        //move and drag this borderless form
        private bool drag = false;
        private Point startP = new Point(0,0);
      
        //List<string>  
        public Create()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //panelMenu.Height = homeBtn.Height;
            //panelMenu.Top = homeBtn.Top;

        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg==0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width-cGrip && pos.Y >= this.ClientSize.Height-cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private DataGridView dataGridView = new DataGridView();

        private void Create_Load(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost; username = root; password=; database=mysql; SSL Mode=None; Persist Security Info=True");

                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM barcodescan", con);
                    DataSet ds = new DataSet();
                    adaptor.Fill(ds, "barcodescan");
                    dataGridView.DataSource = ds.Tables["barcodescan"];
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /* Method (button click): Generate ID 
         * Click button 1 -> Submit -> Generate ID
         * Map button 1 (row 1 of barcodescan table) to row 1 of generateid table
         */
       private void button5_Click(object sender, EventArgs e)
        {
            string connectionstr = "datasource = localhost; username = root; password =; database = mysql; SSL Mode = None; Persist Security Info = True";
            MySqlConnection connectDB = new MySqlConnection(connectionstr);
            MySqlCommand cmdDB = new MySqlCommand("select characterforid from mysql.generateid;", connectDB);

            try
            {
                MySqlDataAdapter sqlda = new MySqlDataAdapter();
                sqlda.SelectCommand = cmdDB;
                DataTable dbdataset = new DataTable();
                sqlda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                //dataGridView1.DataSource = bSource;
                sqlda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /* 
         * if (button[i].Checked == True){
         * button[i] map to masking json file  
         * display 
         * svID.text= text;
         * **/
        private void btnSave_Click(object sender, EventArgs e)
        {
            SSMManager aMasker = new SSMManager();
            SSMPositionManager mcssmmanager = new SSMPositionManager();

           // listBoxIndex.Items.Clear();

            //gives index of the selected box
            //checkedlistbox to a string array (items which has been checked in checkedlistbox to store in a string array)
            ////if (acheckbox.Items.Count > 0)

            int[] itemArr = new int[acheckbox.CheckedItems.Count];
            Int32 counter = 0;
                foreach (object item in this.acheckbox.CheckedItems)
                {
                    int temp = Convert.ToInt32(item);
                    itemArr[counter] = temp;
                    counter++;

                    aMasker.DataLength = counter;
                    aMasker.Masking = itemArr; //indeces of selected checkboxes
                    aMasker.Date = DateTime.Now;
                }
            aMasker.Save();
        }

        /**
         * if button 1, 2, 4, clicked return ID
         * create checkboxes in check box list
         */
        private void btnCreate_Click(object sender, EventArgs e)
        {
            flpanel.Controls.Clear();
            t.Interval = 1000;
            t.Tick += new EventHandler(ttick);

            int count = Int32.Parse(tbNumber.Text); //entered text

            for (int i = 0; i < count; i++)
            {
                string[] arr = {i + "th" };
                acheckbox.Items.AddRange(arr);
                //buttons.Add(acheckbox);

                acheckbox.Size = new Size(60, 40);
                acheckbox.Padding = new Padding(10, 10, 10, 10);
                acheckbox.Cursor = System.Windows.Forms.Cursors.Hand;

                flpanel.Size = new Size(512, 152);
                flpanel.Controls.Add(acheckbox);
            }

            //switch the button boolon/off
            //check if item is chicked
            if (boolon && acheckbox.CheckedItems.Count != 0)
            {
                //button clicked -> turn skylight
                t.Start(); //start the flash effect    
                boolon = false; //clicked
            }
            else
            {
                acheckbox.BackColor = Color.LightBlue;
                t.Stop();
                boolon = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        //THIS******************************************************
        private void ttick(object s, EventArgs e)
        {
          
                //CheckedListBox acheckbox = new CheckedListBox();
               // buttons.Add(acheckbox);

                //flashlight effect
                ////list?
                if (toggleLght)
                {
                    acheckbox.BackColor = Color.Salmon;
                    toggleLght = false;
                }
                else
                {
                    acheckbox.BackColor = Color.LightBlue;
                    toggleLght = true;
                }            
        }

        /*private void btnGetItem_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in acheckbox.CheckedItems)
                listBoxItem.Items.Add(s);
        }*/

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
            if (WindowState.ToString()=="Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //move form around
        private void Create_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startP = new Point(e.X, e.Y);       
        }

        private void Create_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startP.X, p.Y - this.startP.Y);
            }
        }

        private void Create_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
            //Homeform openHome = Homeform.gethomeinstance(); 
            home.Show(); //show home
        }
        
        private void abtBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://warwick.ac.uk/fac/sci/wmg/about/");
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
        }

        //highlight textboxes
        private void Create_Activated(object sender, EventArgs e)
        {
            tbNumber.Focus();
        }
    }
}

