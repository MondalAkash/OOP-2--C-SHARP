using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form3 : Form
    {
        string cb;
        string userId;
        string password;
        string Address;
        string mobileNumebr;
        string userName;


        public Form3()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cb = cbSearch.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string type = cbSearch.Text; ;
            string tid = userIdTF.Text;
            string tpass = passTF.Text;
            if (tid == "" || tpass == ""||type=="")
            {
                warnLabel.Text = "Please Enter All The Values";
            }
            else
            {
                try
                {
                    libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                    Information i = new Information();
                    warnLabel.Text = "";
                    var x = from a in lb.Informations
                            where a.Id == Convert.ToInt32(tid) && a.Type == type && a.Password == tpass
                            select a;
                    if (x.Any())
                    {
                        if (type == "Admin")
                        {
                            //MessageBox.Show("Admin Found");
                            this.Hide();
                            Form4 f4 = new Form4(userIdTF.Text);
                            f4.Show();

                        }
                        else if (type == "User")
                        {
                            libraryDataContext log = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                            var r = from a in log.Informations
                                    where a.Id == Convert.ToInt32(userIdTF.Text) && a.Password == passTF.Text
                                    select a;

                            // get values from database 
                            userId = r.FirstOrDefault().Id.ToString();
                            password = r.FirstOrDefault().Password;
                            Address = r.FirstOrDefault().Address;
                            userName = r.FirstOrDefault().Name;
                            mobileNumebr = r.FirstOrDefault().MobileNo;
                            //Library_management_software.UserDashboard u1 = new Library_management_software.UserDashboard();
                            //MessageBox.Show("User Found");
                            //   Library_management_software.UserDashboard u1 = new Library_management_software.UserDashboard(userName, userId, password, Address, mobileNumebr);
                            Form5 f5 = new Form5(userName, userId, password, Address, mobileNumebr);
                            this.Hide();
                            f5.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong id and password");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("wrong id and password");

                }
                //MessageBox.Show(tid + tpass+type);
            }
            
        }

        
    }
}
