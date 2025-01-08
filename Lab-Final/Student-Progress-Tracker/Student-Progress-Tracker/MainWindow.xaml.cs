using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class frmMain : form
    {
        SqlConnection con = new SqlConnection(@"AUMC-LAB3-10\SQLEXPRESS;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public frmMain()
        {
            InitializeComponent();
            DisplayData();
            load_grid();
        }
        void load_grid()
        {
            SqlCommand cmd = new SqlCommand("Select * from student");
            DataTable dt = new DataTable();
            dt.Load(cmd);


        public void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_box1.Text != "" && txt_box2.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tbl_Students(Name, Age) VALUES(@name, @age)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_box1.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txt_Age.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Students", con);
            adapt.Fill(dt);
            dgt.DataSource = dt;
            con.Close();
        }

        public void ClearData()
        {
            txt_Name.Text = "";
            txt_Age.Text = "";
            ID = 0;
        }
        public void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Age.Text != "")
            {
                cmd = new SqlCommand("UPDATE tbl_Students SET Name=@name, Age=@age WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txt_Age.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("DELETE FROM tbl_Students WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select Record to Delete");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Age.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}