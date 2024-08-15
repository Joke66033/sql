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
    public partial class ItemType1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public ItemType1()
        {
            InitializeComponent();
            connectDB();
            getItemType();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-HJN36SH;Initial Catalog=CScompany;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        public void getItemType()
        {
            cmd.CommandText = "select * from ItemType";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัส"; //เปลี่ยนหัวของ dataGridView
            dataGridView1.Columns[1].HeaderText = "ชื่อ";
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            typeCode.Clear();
            typeName.Clear();   
            typeCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into ItemType values ('" + typeCode.Text + "','" + typeName.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getItemType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการที่จะปิดหน้านี้", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update ItemType set TypeName = '" + typeName.Text + "' where TypeCode = '" + typeCode.Text + "'  ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
                getItemType();
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
                    cmd.CommandText = "delete ItemType where TypeCode = '" + typeCode.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ต้องการลบข้อมูล");
                    getItemType();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบข้อมูลไปแล้ว");
            }
        }

        private void typeCode_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    cmd.CommandText = "select * from ItemType where TypeCode = '" + typeCode.Text + "'";
                    SqlDataReader rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        rs.Read();
                        typeName.Text = rs.GetString(1);
                    }
                    rs.Close();
                }

        }
    }
}
