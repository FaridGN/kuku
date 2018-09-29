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

namespace LoanCodeFirst
{
    public partial class LoanInfo : Form
    {
        public LoanInfo()
        {
            InitializeComponent();
        }

        private void LoanInfo_Load(object sender, EventArgs e)
        {
           using(BankDBContext  newdb = new BankDBContext())
            {
                newdb.Customers.ToList().LastOrDefault();
                textBox1.Text = Mainform.FullName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BankDBContext newdb = new BankDBContext())
            {
                newdb.Loans.Add(new Loan
                {
                    LoanDate = dateTimePicker1.Value,
                    Amount = Convert.ToDecimal(textBox2.Text)
                });
                newdb.SaveChanges();

                Session.LoanDate.Add(dateTimePicker1.Value);
                Session.Amount.Add(Convert.ToDecimal(textBox2.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }
    }
}
