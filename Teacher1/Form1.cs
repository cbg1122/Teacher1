using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher1
{
    public partial class TeManage : Form
    {
        public Form3 form3;
        public Form2 form2;
        public Form4 form4;
        public Form5 form5;
        public TeManage()
        {
            InitializeComponent();
        }

        private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        private void 学生成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
        }
    }
}
