using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management_software
{
    public partial class Form1 : Form
    {


        string userId;
        string password;
        string Address;
        string mobileNumebr;
        string userName;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            try
            {

                dataDataContext log = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\C#\calc\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                var x = from a in log.userDatas
                        where a.id == userIdTF.Text && a.password == passTF.Text
                        select a;

                // get values from database 
                 userId = x.FirstOrDefault().id;
                 password = x.FirstOrDefault().password;
                 Address = x.FirstOrDefault().address;
                 userName = x.FirstOrDefault().name_;
                 mobileNumebr = x.FirstOrDefault().phoneNumber;


                string userIdText = userIdTF.Text;
                string passwordtext = passTF.Text;
                // userId == userIdText || password == passwordtext

                if (cbSearch.Text == "user")
                {
                    if (x.Any())
                    {
                        UserDashboard user = new UserDashboard(userName,userId, password,Address,mobileNumebr);
                        this.Hide();
                        user.Show();
                        //  MessageBox.Show("User id:"+userId+"\nPassword :"+password);
                    }
                    else
                    {
                        MessageBox.Show("wrong password");
                    } 

                }

                else if(cbSearch.Text == "admin")
                {

                }
                      
                
            
            }
            catch(Exception){
                MessageBox.Show("Wrong password and user id ");
            }

            
            

            }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

        //private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        //{
            


        //}
           
      }
    
  }

