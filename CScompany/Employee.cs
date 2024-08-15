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
using System.Diagnostics;

namespace CScompany
{
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Employee()
        {
            InitializeComponent();
            connectDB();
            getEmployee();
            getDepartment();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-HJN36SH;Initial Catalog=CScompany;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        public void getEmployee()
        {
            cmd.CommandText = "select *  from Employee";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัสพนักงาน"; //เปลี่ยนหัวของ dataGridView
            dataGridView1.Columns[1].HeaderText = "ชื่อพนักงาน";
            dataGridView1.Columns[2].HeaderText = "แผนก";
            dataGridView1.Columns[3].HeaderText = "เงินเดือน";
        }

        public void getDepartment()
        {
            cmd.CommandText = "select *  from Department";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource2.DataSource = table;
            departmentType.DataSource = bindingSource2;
            departmentType.DisplayMember = "departmentName";
            departmentType.ValueMember = "departmentCode";
            departmentCode.Text = departmentType.SelectedValue.ToString();
        }

        private void departmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentType.SelectedIndex >= 0)
            {
                departmentCode.Text = departmentType.SelectedValue.ToString();
            }
        }

        private void employeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Employee where employeeCode = '" + employeeCode.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    employeeName.Text = rs.GetString(1);
                    departmentCode.Text = rs.GetString(2);
                    salary.Text = rs.GetInt32(3) + "";
                }
                rs.Close();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            employeeCode.Clear();
            employeeName.Clear();
            departmentCode.Clear();
            salary.Clear();
            employeeCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Employee values ('" + employeeCode.Text + "','" + employeeName.Text + "','" + departmentCode.Text + "','" + salary.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getDepartment();
                getEmployee();
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
                cmd.CommandText = "update Employee set employeeName = '" + employeeName.Text + "' where employeeCode = '" + employeeCode.Text + "' ";
                cmd.ExecuteNonQuery();


                cmd.CommandText = "update Employee set departmentCode = '" + departmentCode.Text + "'where employeeCode = '" + employeeCode.Text + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update Employee set salary = '" + salary.Text + "' where employeeCode = '" + employeeCode.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
                getDepartment();
                getEmployee();
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
                    cmd.CommandText = "delete Employee where employeeCode = '" + employeeCode.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ต้องการลบข้อมูล");
                    getDepartment();
                    getEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบข้อมูลไปแล้ว");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการที่จะปิดหน้านี้", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
