using LoanCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;


namespace LoanCodeFirst
{
    public partial class Mainform : Form
    {
        public static string FullName;
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(BankDBContext db = new BankDBContext())
            {
                try
                {
                    db.Customers.Add(new Customer
                    {
                        Name = textBox1.Text,
                        Surname = textBox2.Text,
                        Passport = textBox3.Text
                    });
                    db.SaveChanges();
                    
                    FullName = textBox1.Text + textBox2.Text;
                    Session.FullNames.Add(FullName);
                    Session.Name.Add(textBox1.Text);
                    Session.Surname.Add(textBox2.Text);
                    Session.Passport.Add(textBox3.Text);
                    LoanInfo info = new LoanInfo();
                    info.ShowDialog();
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                     
            }              
            }
           
        }

    }
