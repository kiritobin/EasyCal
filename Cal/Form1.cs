using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        public double num1;
        public int temp = 0;//记录存储计算方式
        public Form1()
        {
            InitializeComponent();
        }
       
        private void eq_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                //加法运算
                case 1:
                    try
                    {
                        result.Text = (num1 + double.Parse(result.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        temp = 0;
                    }
                    break;
                //减法运算
                case 2:
                    try
                    {
                        result.Text = (num1 - double.Parse(result.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        temp = 0;
                    }
                    break;
                //乘法运算
                case 3:
                    try
                    {
                        result.Text = (num1 * double.Parse(result.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        temp = 0;
                    }
                    break;
                //除法运算，讨论分母为零的情况
                case 4:
                    if (double.Parse(result.Text)==0)
                    {
                        MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        result.ResetText();
                    }
                    else
                    {
                        result.Text = (num1 / double.Parse(result.Text)).ToString(); temp = 0;
                    }
                    break;
                case 5:
                    try
                    {
                        result.Text = (num1 % double.Parse(result.Text)).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        temp = 0;
                    }
                    break;
            }
        }

        private void empty_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            num1 = 0;
            temp = 0;
            //清除
            //if (result.Text.Length > 0)
            //{
            //    result.Text = result.Text.Substring(0, result.Text.Length - 1);
            //}
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "0";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "1";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "2";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "2";
            }
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "3";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "4";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "5";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "6";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "7";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "8";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "9";
            }
            else
            {
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + "9";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            //小数点按键，初始为空，直接按 . 键则显示为0.多少
            if (result.Text == "")
            {
                result.Text = "0.";
            }
            //如果再次输入.则返回都输入的字符后边并提示信息
            else if (result.Text.IndexOf(".") >= 0)
            {
                MessageBox.Show("已经输入小数点,无须再次输入", "提示");
            }
            else
                //前边有数字时，则直接在后边加上.
                result.Text = result.Text + ".";
        }

        private void add_Click(object sender, EventArgs e)
        {
            temp = 1;
            try
            {
                num1 = double.Parse(result.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                result.Text = "";//随后让文本框归空
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            temp = 3;
            try
            {
                num1 = double.Parse(result.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                result.Text = "";//随后让文本框归空
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            temp = 2;
            try
            {
                num1 = double.Parse(result.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            { 
            result.Text = "";//随后让文本框归空
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            temp = 4;
            try
            {
                num1 = double.Parse(result.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                result.Text = "";//随后让文本框归空
            }
        }

        private void per_Click(object sender, EventArgs e)
        {
            temp = 5;
            try
            {
                num1 = double.Parse(result.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                result.Text = "";//随后让文本框归空
            }
        }

        private void opp_Click(object sender, EventArgs e)
        {
            //temp = 6;
            try
               {
                 result.Text = (-double.Parse(result.Text)).ToString();
               }
            catch (Exception)
                {
                    MessageBox.Show("还没输入数字呢", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            finally
                   {
                temp = 0;
                    }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            if (result.Text.Length > 18&& result.Text.Length<36)
            {
                result.Font = new Font(result.Font.FontFamily, 15, result.Font.Style);
            }
            if (result.Text.Length > 36&&result.Text.Length<45)
            {
                result.Font = new Font(result.Font.FontFamily, 10, result.Font.Style);
            }
            if (result.Text.Length > 45)
            {
                MessageBox.Show("超出范围，将要清空了！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result.ResetText();
                result.Font = new Font(result.Font.FontFamily, 20, result.Font.Style);
            }
        }
    }
}
