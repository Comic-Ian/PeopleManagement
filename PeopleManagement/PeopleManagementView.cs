using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PeopleManagement
{
    public partial class PeopleManagementView : Form
    {
        public PeopleManagementView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                String str = "";
                List<TextBox> list = new List<TextBox>();
                list.Add(textBox1);
                list.Add(textBox2);
                list.Add(textBox3);

                for (int i = 0; i < list.Count; i++)
                {
                    str += list[i].Text + ",";
                    
                }
                MessageBox.Show("录入成功！");

                string[] shuzu = str.Split(',');
                for (int j = 0; j < shuzu.Length; j++)
                {
                    listBox1.Items.Add(shuzu[j]);
                }
            }
            else
            {
                MessageBox.Show("录入失败！姓名、性别或者年龄不能为空");
            }
            
        }
            
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
