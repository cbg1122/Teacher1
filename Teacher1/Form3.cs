
namespace Teacher1
{
    using System.Data.SqlClient;
    using System.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    public partial class Form3 : Form
    {
        string strCon = @"data source=(local);initial catalog=C#EX5;integrated security=true";
        public Form3()
        {
            InitializeComponent();
            InitStudent();
            InitGender();
        }
    
        public void InitGender()
        {
            comboBox1.Items.Add("7:00-9:00,上午");
            comboBox1.Items.Add("10:00-12:00,上午");
            comboBox1.Items.Add("1:00-3:00,下午");
            comboBox1.Items.Add("3:30-5:30,下午");
            comboBox1.Items.Add("7:00-9:00,晚上");
        }
        public void InitStudent()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strCmd = "select * from Book2";
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
