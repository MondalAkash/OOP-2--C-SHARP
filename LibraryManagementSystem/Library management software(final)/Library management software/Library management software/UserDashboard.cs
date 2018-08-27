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
    public partial class UserDashboard : Form
    {

     
        //Profiles 
        string userName;
        string userId;
        string password;
        string Address;
        string mobileNumber;
        //
        string borrowD;
        string returnD;
        int day;
        static int count = 0;
        int totalCopy;
        //
        Image File;

  // -------------------------------- Profile------------------------------
       
        public UserDashboard(string userName,string userId,string password,string Address , string mobileNumber)
        {
            this.userName = userName;
            this.userId = userId;
            this.password = password;
            this.Address = Address;
            this.mobileNumber = mobileNumber;

            
             

            InitializeComponent();
            getNameLbl.Text = userName;
            getPasswordLbl.Text = password;
            getAddLbl.Text = Address;
            getPhoneLbl.Text = mobileNumber;
            getUserIdLbl.Text = userId;
            
            
        }
        //open button
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
            }

        }
        //save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }

            
        }

        
        // log out button
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        //closing application
        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      
 
        //------------------------Search Book------------------------------

        //enable search and load 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchTF.Enabled = true;
            dataGridView();
           // btnSelectBook.Enabled = true;
            btnSrc.Enabled = true;
            btnConfirm.Enabled = true;
          
        }
        //load the data 
        public void dataGridView()
        {
            dataDataContext grid = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource =grid.Tables;
        }

        // search books for borrowing
        private void btnSrc_Click(object sender, EventArgs e)
        {
          
            try
            {
              //  btnSelectBook.Enabled = true;

                dataDataContext src = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                    var x = from a in src.Tables
                            where a.bookId == searchTF.Text
                            select a;


                    BookIdTF.Text = x.FirstOrDefault().bookId;
                    bookNameTF.Text = x.FirstOrDefault().bookName;
                    authorNameTF.Text = x.FirstOrDefault().authorName;
                    bookTypeTF.Text = x.FirstOrDefault().bookType;
                    bookCopyTF.Text = x.FirstOrDefault().bookCopy;

                    // priceTF.Text = x.FirstOrDefault().price;

                    dataGridView1.DataSource = x.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found");
            }
           
        }

        
        // insert data of borrower for admin to monitor the borrowe return the book or not 
        private void InsertBorrowerInfoToDatabase()
        {

            borrowD = borrowDate.Value.ToString("dd-mm-yyyy");
            returnD = returnDate.Value.ToString("dd-mm-yyyy");

            dataDataContext borrowBook = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            Borrow borrowInfo = new Borrow{

                name = getNameLbl.Text,
                userId = getUserIdLbl.Text,
                bookId = BookIdTF.Text,
                borrowDate = borrowD,
                returnDate = returnD,
                totalDays = dateDiffTF.Text


            };

            //borrowInfo.BookBorrowInfos.InsertOnSubmit();
            borrowBook.Borrows.InsertOnSubmit(borrowInfo);
            borrowBook.SubmitChanges();



        }

        // borrow date 
        private void borrowDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate =
                    (DateTime)borrowDate.Value;

                DateTime endDate =
                    (DateTime)returnDate.Value;

                TimeSpan ts = endDate.Subtract(startDate);
                day = ts.Days+1;
               // day = day + 1;
                dateDiffTF.Text = day.ToString();
              //  Console.WriteLine(day);
               
               // ddtxtDifference.Text = (Convert.ToDouble(ddtxtDays.Text) / 365).ToString();
          
            }
            catch
            {

            }
        }
        //return date 
        private void returnDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate =
                    (DateTime)borrowDate.Value;

                DateTime endDate =
                    (DateTime)returnDate.Value;

                TimeSpan ts = endDate.Subtract(startDate);

                //dateDiffTF.Text = ts.Days.ToString();
               // dateDiffTF.Text = ts.Days.ToString();
                day = ts.Days+1;
                // day = day + 1;
                dateDiffTF.Text = day.ToString();
                // ddtxtDifference.Text = (Convert.ToDouble(ddtxtDays.Text) / 365).ToString();
            }
            catch
            {

            }
        }
        //confirm button 
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            count++;
            try
            {
                int totalBook = int.Parse(bookCopyTF.Text);
                int totalCopy = 0;
                totalCopy = totalBook;

                if (totalCopy <= 0)
                {
                    MessageBox.Show("Book is not avaliable");
                }
                else
                {
                    //update 
                    bookCopyTF.Text = totalCopy.ToString();
                    dataDataContext update = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                    
                    var x = from a in update.Tables
                            where a.bookId == BookIdTF.Text
                            select a;

                    x.First().bookId = BookIdTF.Text;
                    x.First().bookName = bookNameTF.Text;
                    x.First().authorName = authorNameTF.Text;
                    x.First().bookType = bookTypeTF.Text;
                    x.First().bookCopy = bookCopyTF.Text;

                    update.SubmitChanges();
                    dataGridView1.DataSource = x.ToList();



                    int days = int.Parse(dateDiffTF.Text);
                    //days = days +1;
                    dateDiffTF.Text = days.ToString();

                    if (day > 7 || day <= 0 )
                    {//|| count == 2 || userName == getNameLbl.Text
                        totalCopy = totalCopy - 1;
                        MessageBox.Show("sorry ... order can't be processed");

                    }
                    else
                    {
                        if (searchTF.Text == "" || BookIdTF.Text == "" || bookNameTF.Text == "" || bookTypeTF.Text == "" || bookCopyTF.Text == "")
                        {
                            MessageBox.Show(" Sorry your request is Not confirmed yet :)");

                        }
                        else
                        {
                            if (count == 1)
                            {

                                
                                MessageBox.Show("Welcome sir you borrowed this book for  " + dateDiffTF.Text + "  days");
                                InsertBorrowerInfoToDatabase();
                            }
                            else if (count > 2)
                            {
                                MessageBox.Show(" Sorry your request is Not confirmed yet :)");

                            }
                            
                           

                        }

                       


                    }
                }

            }
            catch (Exception)
            {
                if (searchTF.Text == "" || BookIdTF.Text == "" || bookNameTF.Text == "" || bookTypeTF.Text == "" || bookCopyTF.Text == "")
                {
                    MessageBox.Show(" Sorry your request is Not confirmed yet :)");

                }
      
                /*else if (count == 2 && userName == getNameLbl.Text)
                {
                    MessageBox.Show("you can't select one more book");
                    
                }*/
            }

            //if (day > 7 || day <= 0)
            //{
            //    MessageBox.Show("sorry ... order can't be processed");

            //}
            //else
            //{
            //    MessageBox.Show("Welcome sir you borrowed this book for  " + dateDiffTF.Text + "  days");
            //    InsertBorrowerInfoToDatabase();


            //}
            

        }
        //clear all textfields
        private void btnClr_Click(object sender, EventArgs e)
        {
            //book segment 
            BookIdTF.Clear();
            bookNameTF.Clear();
            authorNameTF.Clear();
            bookTypeTF.Clear();
            bookCopyTF.Clear();

            //serach segment 
            searchTF.Clear();

            //day segment
            dateDiffTF.Clear();


        }

        //--------------------------Membership---------------------------

        //check 
        private void checkValue_CheckedChanged(object sender, EventArgs e)
        {
            ReportTF.Enabled = true;
            userTF.Text = userId;
            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            try
            {

                if (ReportTF.Text != "")
                {
                    dataDataContext dc = new dataDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                    Review r = new Review();
                    r.Id = Convert.ToInt32(userTF.Text);
                    r.Rev = ReportTF.Text;
                    dc.Reviews.InsertOnSubmit(r);
                    dc.SubmitChanges();


                    ReportTF.Enabled = false;

                    //userTF.Text = userId;

                    //string getMessage = ReportTF.Text;
                    userTF.Text = "";
                    ReportTF.Text = "";

                    //getMess.Text = getMessage;
                    btnSend.Enabled = false;
                    MessageBox.Show("Message sent successfully");

                }
                else
                {

                    MessageBox.Show("Message sent failed");


                }
                



            }
            catch (Exception)
            {
                MessageBox.Show("You are already give your review ");
            }
            

        }

      

   







    }
}
