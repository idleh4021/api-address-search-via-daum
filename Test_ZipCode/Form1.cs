using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_ZipCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

            if (frm.Tag == null) { return; }
            DataRow dr = (DataRow)frm.Tag;

            TBox_ZipCode.Text = dr["zonecode"].ToString();
            TBox_Address1.Text = dr["ADDR1"].ToString();
            TBox_Address2.Text = "";
            TBox_Notes.Text = dr["EX"].ToString();

            TBox_Address2.Focus();
        }
    }
}
