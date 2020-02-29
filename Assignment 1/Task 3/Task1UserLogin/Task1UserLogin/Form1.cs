using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1UserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validation 
            int er = 0;
            label3.Visible = false;
            label4.Visible = false;
            if (textBox1.Text=="")
            {
                er++;
                label3.Text ="Insert Username..";
                label3.Visible = true;
            }
            else if (textBox2.Text == "")
            {
                er++;
                label4.Text = "Insert Password..";
                label4.Visible = true;
            }
            if (er > 0)
            {
                return;
            }

            // create dictionary
            Dictionary<string, string> Database = new Dictionary<string, string>()
                                            {
                                                {"admin","admin123"},
                                                {"roy", "roy123"},
                                                {"moni","moni123"}
                                            };

            string name = textBox1.Text;
            string password = textBox2.Text;
            string j;

            bool i = (Database.TryGetValue(name, out j)); // Finding username
            if (i == true)
            {
                if (j == password) // Match password
                {
                    label5.Text = "Welcome " + name;
                }
                else
                {
                    label4.Text = "Password wrong..";
                    label4.Visible = true;
                }
            }
            else
            {
                label3.Text = "Username wrong..";
                label3.Visible = true;
            }

            
        }
    }
}
