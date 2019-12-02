using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
  

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSTK.Text == "" || txtName.Text == "" || txtPlace.Text == "" || txtPay.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                List<Account> listAccount = GetListAccount();
                Account findAccount = listAccount.FirstOrDefault(p => p.STK == txtSTK.Text);
                if (findAccount == null) //TH Insert dữ liệu
                {
                    findAccount = GetAccount(); //lấy giá trị từ forms 
                    string[] items = new string[] { (listAccount.Count + 1).ToString(),
                    findAccount.STK, findAccount.TEN, findAccount.DIACHI,
                    findAccount.SOTIEN.ToString() };
                    ListViewItem newRow = new ListViewItem(items);
                    listView1.Items.Add(newRow);
                }
                else  //TH update sinh vien tu viet 
                {
                    for(int i = 0; i < listView1.Items.Count; i++)
                    {
                        if(listView1.Items[1].SubItems[1].Text == txtSTK.Text)
                        {
                            listView1.Items[1].SubItems[1].Text = txtSTK.Text;
                            listView1.Items[1].SubItems[1].Text = txtName.Text;
                            listView1.Items[1].SubItems[1].Text = txtPlace.Text;
                            listView1.Items[1].SubItems[1].Text = txtPay.Text;
                            return;

                        }
                    }
                    ListViewItem item = new ListViewItem(new string[] { (listAccount.Count + 1).ToString(), findAccount.STK, findAccount.TEN, findAccount.DIACHI, findAccount.SOTIEN.ToString()});
                    listView1.Items.AddRange(new ListViewItem[] { item });
                }
               txtPay.Text = GetListAccount().Sum(p => p.SOTIEN).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private Account GetAccount()
        {
            Account acc = new Account();
            acc.STK = txtSTK.Text;
            acc.TEN = txtName.Text;
            acc.DIACHI = txtPlace.Text;
            acc.SOTIEN = double.Parse(txtPay.Text);
            return acc;
        }
        private List<Account> GetListAccount()
        {
        
            List<Account> list = new List<Account>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Account acc = new Account();
                acc.STK = listView1.Items[i].SubItems[1].Text;
                acc.TEN = listView1.Items[i].SubItems[2].Text;
                acc.DIACHI = listView1.Items[i].SubItems[3].Text;
                acc.SOTIEN = double.Parse(listView1.Items[i].SubItems[4].Text);
                list.Add(acc);   
            }
            return list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0 )
            {
                DialogResult del = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                }
            }
            else
            {
                MessageBox.Show("Ban chua chon User can xoa");
            }
        }
    }
}
