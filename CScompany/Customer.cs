using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CScompany
{
    public partial class Customer : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Customer()
        {
            InitializeComponent();
            connectDB();
            getCustomer();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-HJN36SH;Initial Catalog=CScompany;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        public void getCustomer()
        {
            cmd.CommandText = "select * from Customer";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัสลูกค้า"; //เปลี่ยนหัวของ dataGridView
            dataGridView1.Columns[1].HeaderText = "ชื่อลูกค้า";
        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Customer where customerCode = '" + customerCode.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    customerName.Text = rs.GetString(1);
                }
                rs.Close();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
                customerCode.Clear();
                customerName.Clear();
                customerCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Customer values ('" + customerCode.Text + "','" + customerName.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Customer set customerName = '" + customerName.Text + "' where customerCode = '" + customerCode.Text + "'  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
                getCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("แก้ไขไปแล้ว");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ต้องการที่จะลบข้อมูลหรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.CommandText = "delete Customer where customerCode = '" + customerCode.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ต้องการลบข้อมูล");
                    getCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบข้อมูลไปแล้ว");
            }
        }

        private void bClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการที่จะปิดหน้านี้", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
