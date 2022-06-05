using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String custname = nam.Text;
                String date_returned = dren.Value.ToString();
                var cartype = cardrop.SelectedItem.ToString();
                var isInvalid = true;
                var errormes = "";
                if (string.IsNullOrWhiteSpace(custname) || string.IsNullOrWhiteSpace(cartype))
                {
                    isInvalid = false;
                    MessageBox.Show("kindly enter the details ");
                    errormes += "Please fill the correct message";
                }
                if (isInvalid)
                {
                    MessageBox.Show($"cusntomer name  {custname}\n" + $"date returnned  {date_returned}\n" + $"car type {cartype}\n" + "thank you for ordering");
                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

                }
        }
    }

