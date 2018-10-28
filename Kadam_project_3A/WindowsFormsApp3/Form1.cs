using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class startwithtwo : Exception
        {


            public startwithtwo()
            {
                MessageBox.Show("An exception has occured the number cannot start with 2 for the second number");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = box2.Text;
                decimal Number1 = Convert.ToDecimal(box1.Text);
                decimal Number2 = Convert.ToDecimal(box2.Text);
                decimal number3 = Number1 / Number2;
                if (Number2 > 800)
                {
                    throw new OverflowException();
                };
                if (a.StartsWith("2"))
                {
                    throw new startwithtwo();
                }
                box3.Text = number3.ToString();
                box1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception has occured enter values in numbers only");
                box1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception has occured enter First Number less then 800");
                box1.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by zero exception has occured enter a number greater than zero for Second Number");
                box2.Focus();
            }
            catch (startwithtwo)
            {
                box1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
