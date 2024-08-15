using System.Data;
using System.Windows.Forms;

namespace CScompany
{
    public partial class Form1 : Form
    {
        SqlConnerction conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
            connectDB();
            getItem();
            getItemType();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-HJN36SH;Initial Catalog=CScompany;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        public void getItem()
        {
            cmd.CommandText = "select * , price*qty from Item";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัส"; //เปลี่ยนหัวของ dataGridView
            dataGridView1.Columns[1].HeaderText = "ชื่อ";
            dataGridView1.Columns[2].HeaderText = "ประเภท";
            dataGridView1.Columns[3].HeaderText = "ราคา";
            dataGridView1.Columns[4].HeaderText = "จำนวน";
            dataGridView1.Columns[5].HeaderText = "เป็นเงิน";
        }

        public void getItemType()
        {
            cmd.CommandText = "select *  from ItemType";  //คำสั่งที่จะไปดึงมาจาก sql
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;  //อ่านข้อมูลจากตารางเอามาเก็บใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource2.DataSource = table;
            itemType.DataSource = bindingSource2;
            itemType.DisplayMember = "typeName";
            itemType.ValueMember = "typeCode";
            typeCode.Text = itemType.SelectedValue.ToString();
        }

        private void itemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemType.SelectedIndex >= 0)
            {
                typeCode.Text = itemType.SelectedValue.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemCode.Clear();
            itemName.Clear();
            typeCode.Clear();
            price.Clear();
            qty.Clear();
            amount.Clear();
            itemCode.Focus();
        }

        private void Insent_Click(object sender, EventArgs e)
        {

            try
            {
                cmd.CommandText = "insert into Item values ('" + itemCode.Text + "','" + itemName.Text + "','" + typeCode.Text + "','" + price.Text + "','" + qty.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getItemType();
                getItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                cmd.CommandText = "update Item set itemName = '" + itemName.Text + "'" + "where itemCode = '" + itemCode.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Item set typeCode = '" + typeCode.Text + "'" + "where itemCode = '" + itemCode.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Item set price = '" + price.Text + "'" + "where itemCode = '" + itemCode.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Item set qty = '" + qty.Text + "'" + "where itemCode = '" + itemCode.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
                getItemType();
                getItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("แก้ไขไปแล้ว");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ต้องการที่จะลบข้อมูลหรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.CommandText = "delete Item where itemCode = '" + itemCode.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ต้องการลบข้อมูล");
                    getItemType();
                    getItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ลบข้อมูลไปแล้ว");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการที่จะปิดหน้านี้", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select *,price*qty from Item where itemCode = '" + itemCode.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    itemName.Text = rs.GetString(1);
                    typeCode.Text = rs.GetString(2);
                    price.Text = rs.GetInt32(3) + "";
                    qty.Text = rs.GetInt32(4) + "";
                    amount.Text = rs.GetInt32(5) + "";
                }
                rs.Close();
            }
        }

        private void Brows_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = openFileDialog1)
            {
                openFileDialog.Filter = "Item Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
