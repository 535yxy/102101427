using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    //f=0,下一个输入需要数字;f=2,可以取等号计算
    //数字类和符号类个体间模块高度相似，可以考虑简化为函数
    public partial class Form1 : Form
    {
        public double lef, rig, rul;
        public string flag = " ";
        public int f = 0;
        public string g = " ";
        public Form1()
        {
            InitializeComponent();
        }

        public void sct()
        {
            textBox1.Text = "";
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "6";
            f = 2;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "2";
            f = 2;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "4";
            f = 2;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "3";
            f = 2;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "5";
            f = 2;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "7";
            f = 2;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "8";
            f = 2;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "9";
            f = 2;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "+";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button13_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                rig = Convert.ToDouble(textBox1.Text);
                if (flag == "In")
                {
                    rul = Math.Log(rig, Math.E);
                }
                if (flag == " ")
                {
                    rul = rig;
                }
                if (flag == "sin")
                {
                    rul = Math.Round(Math.Sin(Math.PI * rig / 180), 5);
                }
                if (flag == "tan")
                {
                    rul = Math.Round(Math.Tan(Math.PI * rig / 180), 5);
                }
                if (flag == "cos")
                {
                    rul = Math.Round(Math.Cos(Math.PI * rig / 180), 5);
                }
                if (flag == "^")
                {
                    rul = Math.Pow(lef, rig);
                }
                if (flag == "+")
                {
                    rul = lef + rig;
                }
                if (flag == "-")
                {
                    rul = lef - rig;
                }
                if (flag == "*")
                {
                    rul = lef * rig;
                }
                if (flag == "/")
                {
                    if (rig != 0)
                    {
                        rul = lef / rig;
                    }
                }
                if (flag == "%")
                {
                    rul = lef % rig;
                }
                textBox1.Text = rul.ToString();
                if (flag == "/")
                {
                    if (rig == 0)
                    {
                        textBox1.Text = "除数不能为0";
                        f = 0;
                    }
                }
                if (textBox1.Text == "NaN")
                {
                    f = 0;
                }
            }
            g = textBox1.Text;
        }

        public void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            f = 0;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "0";
            f = 2;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            f = 0;
        }
        public void button24_Click(object sender, EventArgs e)
        {

        }

        public void button21_Click(object sender, EventArgs e)
        {
            sct();
            textBox1.Text += "sin(输入度数)";
            flag = "sin";
            f = 0;
        }

        public void button22_Click(object sender, EventArgs e)
        {
            sct();
            textBox1.Text += "cos(输入度数)";
            flag = "cos";
            f = 0;
        }

        public void button17_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "^";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button12_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "/";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "-";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button11_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "*";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button20_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBox1.Text = "error（格式错误）";
            }
            if (f == 2)
            {
                lef = Convert.ToDouble(textBox1.Text);
                flag = "%";
                textBox1.Text = "";
                f = 0;
            }
        }

        public void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        public void button23_Click(object sender, EventArgs e)
        {
            sct();
            textBox1.Text += "tan(输入度数)";
            flag = "tan";
            f = 0;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            sct();
            textBox1.Text += "In";
            flag = "In";
            f = 0;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                sct();
            }
            textBox1.Text += "1";
            f = 2;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
