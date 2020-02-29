using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Addition action
        private void button1_Click(object sender, EventArgs e)
        {

            // check validation
            int er = 0;
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            string i = textBoxNum1.Text;
            string k = textBoxNum2.Text;
            int j = 0;
            if (!int.TryParse(i, out j))
            {
                label4.Text = "Invalide Input";
                label4.Visible = true;
                er++;

            }
            else if (!int.TryParse(k, out j))
            {
                label5.Text = "Invalide Input";
                label5.Visible = true;
                er++;

            }

            else if (textBoxNum1.Text == "")
            {
                er++;
                label4.Text = "Please insert number..";
                label4.Visible = true;
            }
            else if (textBoxNum2.Text=="")
            {
                er++;
                label5.Text = "Please Insert number..";
                label5.Visible = true;
            }
            if (er > 0)
            {
                return;
            }

           // convert data type string to double
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);
            double result = 0;



            result = num1 + num2; // add two  numbers 
            textBoxResult.Text = result.ToString();
            


        }


        // Action Subtract 
        private void button2_Click(object sender, EventArgs e)
        {
            // Check validation
            int er = 0;
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            string i = textBoxNum1.Text;
            string k = textBoxNum2.Text;
            int j = 0;
            if (!int.TryParse(i, out j))
            {
                label4.Text = "Invalide Input";
                label4.Visible = true;
                er++;

            }
            else if (!int.TryParse(k, out j))
            {
                label5.Text = "Invalide Input";
                label5.Visible = true;
                er++;

            }

            else if (textBoxNum1.Text == "")
            {
                er++;
                label4.Text = "Please insert number..";
                label4.Visible = true;
            }
            else if (textBoxNum2.Text == "")
            {
                er++;
                label5.Text = "Please Insert number..";
                label5.Visible = true;
            }
            if (er > 0)
            {
                return;
            }

            try
            {
                // convert data type string to double
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double result = 0;
                result = num1 - num2;

                textBoxResult.Text = result.ToString();

            }
            catch(Exception ex)
            {
                label6.Text = "Input is not valide";
                label6.Visible = true;

            }
        }


        // Action Multiply 
        private void button3_Click(object sender, EventArgs e)
        {
            // Check validation
            int er = 0;
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            string i = textBoxNum1.Text;
            string k = textBoxNum2.Text;
            int j = 0;
            if (!int.TryParse(i, out j))
            {
                label4.Text = "Invalide Input";
                label4.Visible = true;
                er++;

            }
            else if (!int.TryParse(k, out j))
            {
                label5.Text = "Invalide Input";
                label5.Visible = true;
                er++;

            }

            else if (textBoxNum1.Text == "")
            {
                er++;
                label4.Text = "Please insert number..";
                label4.Visible = true;
            }
            else if (textBoxNum2.Text == "")
            {
                er++;
                label5.Text = "Please Insert number..";
                label5.Visible = true;
            }
            if (er > 0)
            {
                return;
            }

            try
            {
                // convert data type string to double
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double result = 0;

                result = num1 * num2; // Multiply two numbers
                textBoxResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                label6.Text = "Input is not valide";
                label6.Visible = true;

            }
        }

        // Action Division
        private void button4_Click(object sender, EventArgs e)
        {
            int er = 0;
            label5.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            string i = textBoxNum1.Text;
            string k = textBoxNum2.Text;
            int j = 0;
            if (!int.TryParse(i, out j))
            {
                label4.Text = "Invalide Input";
                label4.Visible = true;
                er++;

            }
            else if (!int.TryParse(k, out j))
            {
                label5.Text = "Invalide Input";
                label5.Visible = true;
                er++;

            }

            else if (textBoxNum1.Text == "")
            {
                er++;
                label4.Text = "Please insert number..";
                label4.Visible = true;
            }
            else if (textBoxNum2.Text == "")
            {
                er++;
                label5.Text = "Please Insert number..";
                label5.Visible = true;
            }
            if (er > 0)
            {
                return;
            }

            try
            {
                // convert data type string to double
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double result = 0;

                result = num1 / num2; // Divide two numbers

                if (Double.IsInfinity(result)) // if result is infinity
                {
                    textBoxResult.Text = "∞";
                    label6.Text = "Infinity";
                    label6.Visible = true;
                }
                else
                {
                    textBoxResult.Text = result.ToString();
                }

            }
            catch (Exception ex)
            {
                label6.Text = "Input is not valide";
                label6.Visible = true;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
            textBoxResult.Text = "";
            label6.Text = "";
            label6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }


    }
}
