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

namespace ReadingAnnouncement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "请选择学科" || button1.Text == "语文")
            {
                button1.Text = "English";
                textBox1.Text = "Please enter the books(things) we need.";
            }else if (button1.Text == "English")
            {
                button1.Text = "语文";
                textBox1.Text = "请输入需要准备的书本（物品）";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "请选择早晚读" || button2.Text == "早读")
            {
                button2.Text = "晚读";
            }else if (button2.Text == "晚读")
            {
                button2.Text = "早读";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\cache.html";
            StreamWriter writer = new StreamWriter(path, false, Encoding.Default);
            writer.Write("<html lang=\"zh-cn\"><head><meta charset=\"GB2312\"><title>读书时间</title></head><body>");
            if (button1.Text == "English")
            {
                writer.Write("<h1>This is an English ");
                if (button2.Text == "早读")
                {
                    writer.Write("Morning Reading");
                }
                else
                {
                    writer.Write("Evening Reading");
                }
                writer.Write("</h1>");
                writer.Write("<h2>Please prepare your " + textBox1.Text + "</h2>");
            }
            else if(button1.Text == "语文")
            {
                writer.Write("<h1>这是一次语文"+button2.Text+"</h1>");
                writer.Write("<h2>请准备你的" + textBox1.Text + "</h2>");
            }
            writer.Write("</body></html>");
            writer.Close();
            System.Diagnostics.Process.Start(path);
        }
    }
}
