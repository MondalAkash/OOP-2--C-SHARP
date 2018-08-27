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
    public partial class Form1 : Form
    {
        //string tname; string tpass; string tmbl; string tgen; string tmail; string tut;
        //int tid;
        string table;
        string g;
        libraryDataContext ld;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.table = comboBox1.Text;
            //MessageBox.Show(table);
            //Console.WriteLine("Admin");
        }

        /*private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
                this.table = "admin";
            
            
                //this.table = "user";
        
        }
        private void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.table = "user";
        }*/
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.g = "male";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.g = "female";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            

            // Check if the point entered is numeric or not
            //if ()
            //{
            //    // Do what you want to do if numeric
            //}
            //else
            //{
            //    // Do what you want to do if not numeric
            //}   

            ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
            Information i = new Information();
            //tid=Convert.ToInt32(idTextBox.Text);
            /*this.tname=nameTextBox.Text;
            this.tpass=passwordTextBox.Text;
            this.tmbl=mobileTextBox.Text;
            this.tgen=gender;
            this.tmail=emailTextBox.Text;
            this.tut=this.table;*/
            /*if(tname.Equals(null)||tpass.Equals(null)||tmbl.Equals(null)||tgen.Equals(null)||tmail.Equals(null)||tut.Equals(null))
            {
                label8.Text="Please enter all the values";
            }*/
            if (idTextBox.Text == "" || nameTextBox.Text == "" || passwordTextBox.Text == "" || mobileTextBox.Text == "" || g == "" || emailTextBox.Text == "" || comboBox1.Text == "" || addressTf.Text == "" )
            {
                label8.Text = "Please enter all the values Correctly";
            }
            else
            {

                try
                {
                    i.Id = Convert.ToInt32(idTextBox.Text);
                    i.Name = nameTextBox.Text;
                    i.Password = passwordTextBox.Text;
                    i.MobileNo = mobileTextBox.Text;
                    i.Gender = this.g;
                    i.Email = emailTextBox.Text;
                    i.Type = this.table;
                    i.Address = addressTf.Text;

                    if (this.table == "Admin")
                    {
                        var x = from a in ld.Informations
                                where a.Type == "Admin"
                                select a.Type;
                        //var y = from b in ld.Informations
                        //        where b.Type == "User"
                        //        select b.Type;



                        if (x.Any())
                        {

                            MessageBox.Show("Already");

                        }
                        else
                        {
                            ld.Informations.InsertOnSubmit(i);
                            ld.SubmitChanges();
                            this.Hide();
                            MessageBox.Show("Registration Successfull..");
                            Form2 f2 = new Form2();
                            f2.Show();


                        }
                    }
                    else
                    {
                        ld.Informations.InsertOnSubmit(i);
                        ld.SubmitChanges();
                        this.Hide();
                        MessageBox.Show("Registration Successfull..");
                        Form2 f2 = new Form2();
                        f2.Show();
                    }


                }

                catch (Exception)
                {
                    MessageBox.Show("Check Again");
                }
                //try
                //{
                //    i.Id = Convert.ToInt32(idTextBox.Text);
                //    i.Name = nameTextBox.Text;
                //    i.Password = passwordTextBox.Text;
                //    i.MobileNo = mobileTextBox.Text;
                //    i.Gender = this.g;
                //    i.Email = emailTextBox.Text;
                //    i.Type = this.table;
                //    i.Address = addressTf.Text;

                //    var x = from a in ld.Informations
                //            where a.Type == "Admin"
                //            select a.Type;
                //    var y = from b in ld.Informations
                //            where b.Type == "User"
                //            select b.Type;



                //        if (x != null)
                //        {


                //            ld.Informations.InsertOnSubmit(i);
                //            ld.SubmitChanges();
                //            this.Hide();
                //            MessageBox.Show("Registration Successfull..");
                //            Form2 f2 = new Form2();
                //            f2.Show();

                //        }
                //        else
                //        {
                //            if (y.Any() || y != null)
                //            {
                //                ld.Informations.InsertOnSubmit(i);
                //                ld.SubmitChanges();
                //                this.Hide();
                //                MessageBox.Show("Registration Successfull..");
                //                Form2 f2 = new Form2();
                //                f2.Show();
                //            }
                //            else
                //            {
                //                MessageBox.Show("Already");
                //            }

                //        }


                //    }
                    






                
                //catch (Exception)
                //{
                //    MessageBox.Show("Please enter another id");
                //}
            }
                
            
            







           
            /*if (this.table == "Admin")
            {
                ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                admin ad = new admin();

                try
                {
                    ad.aid = idTextBox.Text;
                    ad.name = nameTextBox.Text;
                    ad.password = passwordTextBox.Text;
                    ad.mobileno = mobileTextBox.Text;
                    ad.emailid = emailTextBox.Text;
                    ad.gender = gender;
                    ld.admins.InsertOnSubmit(ad);
                    ld.SubmitChanges();
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("Please Check Your Mobile No.", "Message");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please insert all the values", "Message");
                }
                
                //MessageBox.Show(idTextBox.Text+nameTextBox.Text+passwordTextBox.Text+mobileTextBox.Text+emailTextBox.Text+gender);
                

            }
            else if (this.table == "User")
            {
                ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                user us = new user();
                try
                {
                    us.pid = idTextBox.Text;
                    us.name = nameTextBox.Text;
                    us.password = passwordTextBox.Text;
                    us.mobileno = mobileTextBox.Text;
                    us.emailid = emailTextBox.Text;
                    us.gender = gender;
                    ld.users.InsertOnSubmit(us);
                    ld.SubmitChanges();
                }
                catch (DataException)
                {
                    MessageBox.Show("Please Check Your Mobile No.", "Message");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please insert all the values", "Message");
                }

            }
            else
            {
                MessageBox.Show("Please insert the values");
            }*/
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        

       


        
    }
}
