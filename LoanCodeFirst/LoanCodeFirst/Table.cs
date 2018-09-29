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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            
        }

        private void Table_Load(object sender, EventArgs e)
        {
            AddToTable();
        }

        public void AddToTable()
        {
            using (BankDBContext db = new BankDBContext())
            {

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Surname");
                dataTable.Columns.Add("Passport");
                dataTable.Columns.Add("LoaDate");
                dataTable.Columns.Add("Amount");

                for (int i = 0; i < Session.FullNames.Count; i++)
                {
      dataTable.Rows.Add(Session.Name[i], Session.Surname[i], Session.Passport[i], Session.LoanDate[i], Session.Amount[i]);
                    
                    //LoanTable.Rows.Add();
                    //LoanTable.Rows[i].Cells[0].Value = Session.Name[i];
                    //LoanTable.Rows[i].Cells[1].Value = Session.Surname[i];
                    //LoanTable.Rows[i].Cells[2].Value = Session.Passport[i];
                    //LoanTable.Rows[i].Cells[3].Value = Session.LoanDate[i];
                    //LoanTable.Rows[i].Cells[4].Value = Session.Amount[i];
                }

            }
           
        }

        private void LoanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
