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
    public partial class Form4 : Form
    {
        string id;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string id)
        {
            this.id=id;
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in lb.Informations
                    where a.Id == Convert.ToInt32(id)
                    select a;
            adLabel.Text = x.FirstOrDefault().Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            //string bId = delBookIdTF.Text;
            var x = from a in lb.Tables
                    where a.bookId == delBookIdTF.Text
                    select a;
            if (x.Any())
            {
                dataGridView1.DataSource = x.ToList();
            }
            else
            {
                MessageBox.Show("Nothing Found");
            }
            

        }
        void UpdateGridView()
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = lb.Tables;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in lb.Tables
                    where a.bookId == delBookIdTF.Text
                    select a;
            if (x.Any())
            {
                foreach (Table p in x)
                {
                    lb.Tables.DeleteOnSubmit(p);
                }

                lb.SubmitChanges();
                MessageBox.Show("Book Deleted");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Fill up the id first");
            }

            
        }

        private void bookStatus_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView2.DataSource = lb.Tables;
        }

        private void searchUButton_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
            //string bId = delBookIdTF.Text;
            try
            {
                var z = from a in lb.Informations
                        where a.Id == Convert.ToInt32(textBox1.Text) && a.Id != 1
                        select a;
                if (z.Any())
                {
                    dataGridView3.DataSource = z.ToList();
                }
                else
                {
                    MessageBox.Show("Nothing Found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the ID");
            }

        }

        private void deleteUButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                var x = from a in lb.Informations
                        where a.Id == Convert.ToInt32(textBox1.Text)
                        select a;
                if (x.Any())
                {
                    foreach (Information p in x)
                    {
                        lb.Informations.DeleteOnSubmit(p);
                    }

                    lb.SubmitChanges();
                    MessageBox.Show("Member Deleted");
                    //libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                    dataGridView3.DataSource = lb.Informations;
                }
                else
                {
                    MessageBox.Show("Fill up the id first");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fill Up the id first");
            }
        }

        private void ustatusButton_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView4.DataSource = lb.Informations;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                Table t = new Table();
                //string tid = bookIdText.Text;
                //string tname = bookNameText.Text;
                //string tauthore = bookAuthoreTF.Text;
                //string type = btTf.Text;
                //string tcopy = cpyTF.Text;
                if (bookIdText.Text == "" || bookNameText.Text == "" || bookAuthoreTF.Text == "" || btTf.Text == "" || cpyTF.Text == "")
                {
                    MessageBox.Show("Please Check The Fields");
                }
                else
                {
                    t.bookId = bookIdText.Text;
                    t.bookName = bookNameText.Text;
                    t.authorName = bookAuthoreTF.Text;
                    t.bookType = btTf.Text;
                    t.bookCopy = cpyTF.Text;
                    lb.Tables.InsertOnSubmit(t);
                    lb.SubmitChanges();
                   
                    dataGridView6.DataSource = lb.Tables;
                    MessageBox.Show("Book Added Successfully");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please CHeck The Fields Again");
                    
            }

        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            bookIdText.Clear();
            bookNameText.Clear();
            bookAuthoreTF.Clear();
            btTf.Clear();
            cpyTF.Clear();
        }

        private void bstatusButton_Click(object sender, EventArgs e)
        {
            libraryDataContext lb = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView5.DataSource = lb.Borrows;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            libraryDataContext ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView7.DataSource = ld.Reviews;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            delBookIdTF.Text = "";
            dataGridView1.DataSource = "";
        }

        private void clButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = "";
        }

        private void cclButton_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = "";
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void cbutton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView3.DataSource = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                var c = from h in ld.Informations
                        where h.Id == Convert.ToInt32(idTF.Text)
                        select h;
                if (c.Any())
                {
                    nameTF.Text = c.FirstOrDefault().Name;
                    addTF.Text = c.FirstOrDefault().Address;
                    emailTF.Text = c.FirstOrDefault().Email;
                    phoneTF.Text = c.FirstOrDefault().MobileNo;
                    genderTF.Text = c.FirstOrDefault().Gender;
                    dataGridView8.DataSource = c.ToList();
                    if (nameTF.Text != "" || addTF.Text != "" || emailTF.Text != "" || phoneTF.Text != "" || genderTF.Text != "")
                    {
                        nameTF.Enabled = true;
                        addTF.Enabled = true;
                        emailTF.Enabled = true;
                        phoneTF.Enabled = true;
                        genderTF.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Nothing Found");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter ID");
            }
                

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext ld = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\LibraryManagementSystem\library.mdf;Integrated Security=True;Connect Timeout=30");
                var t = from s in ld.Informations
                        where s.Id == Convert.ToInt32(idTF.Text)
                        select s;

                //libraryDataContext le = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                //var zz = from q in le.Borrows
                //         where q.userId == idTF.Text
                //         select q;
                
                    t.First().Name = nameTF.Text;
                    //zz.First().name = nameTF.Text;
                    t.First().Address = addTF.Text;
                    t.First().Email = emailTF.Text;
                    t.First().MobileNo = phoneTF.Text;
                    t.First().Gender = genderTF.Text;
                    ld.SubmitChanges();
                    //le.SubmitChanges();
                    dataGridView8.DataSource = t.ToList();

                    
                   
                    
                    
                
                
                
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter ID");
            }
                    
            
        }

        private void cclleeaarr_Click(object sender, EventArgs e)
        {
            idTF.Text = "";
            nameTF.Text = "";
            addTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            genderTF.Text = "";
            dataGridView8.DataSource = "";
        }

        private void addbookcopyButton_Click(object sender, EventArgs e)
        {
            bidTF.Enabled = true;
            cpTF.Enabled = true;
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            libraryDataContext ll = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            var f = from l in ll.Tables
                    where l.bookId == bidTF.Text
                    select l;
            if (f.Any())
            {
                dataGridView2.DataSource = f.ToList();
            }
            else
            {
                MessageBox.Show("Nothing Found");
            }
        }

        private void uupdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext ll = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                var f = from l in ll.Tables
                        where l.bookId == bidTF.Text
                        select l;
                int x = Convert.ToInt32(f.FirstOrDefault().bookCopy);
                x += Convert.ToInt32(cpTF.Text);
                f.First().bookCopy = Convert.ToString(x);
                ll.SubmitChanges();
                MessageBox.Show("Book Copy Added Successfully");
                dataGridView2.DataSource = f.ToList();
                cpTF.Text = "";
                bidTF.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Check ID");
            }
        }

        private void seButton_Click(object sender, EventArgs e)
        {
            try
            {
                libraryDataContext lr = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
                var f = from k in lr.Borrows
                        where k.userId == textBox2.Text
                        select k;
                var h = from l in lr.Tables
                        where f.FirstOrDefault().bookId == l.bookId
                        select l;
                textBox3.Text = f.FirstOrDefault().bookId;
                textBox4.Text = f.FirstOrDefault().name;
                textBox5.Text = h.FirstOrDefault().bookName;
            }
            catch (Exception)
            {
                MessageBox.Show("Check ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            libraryDataContext lr = new libraryDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C# project\LibraryManagementSystem\Library management software(final)\Library management software\Library management software\datatable.mdf;Integrated Security=True;Connect Timeout=30");
            var x = from a in lr.Tables
                    where a.bookId == textBox3.Text
                    select a;
            int g = Convert.ToInt32(x.FirstOrDefault().bookCopy);
            g += 1;
            x.First().bookCopy = Convert.ToString(g);
            lr.SubmitChanges();
            var v = from f in lr.Borrows
                    where f.userId == textBox2.Text
                    select f;
            foreach (Borrow oo in v)
            {
                lr.Borrows.DeleteOnSubmit(oo);
            }

            lr.SubmitChanges();
            //UpdateGridView();
        }

      

        

        


       

        
    }
}
