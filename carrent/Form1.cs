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
        private readonly car_rental_dbEntities car_Rental_DbEntities;
            
        public Form1()
        {
            InitializeComponent();
            car_Rental_DbEntities = new car_rental_dbEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String custname = nam.Text;
                var date_returned = dren.Value;
                var cartype = cardrop.Text;
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
                    var carrecord = new tab2();
                    carrecord.name = custname;
                    carrecord.dateofrented = date_returned;
                    carrecord.typeofcar = (int)cardrop.SelectedValue;
                    car_Rental_DbEntities.tab2.Add(carrecord);
                    car_Rental_DbEntities.SaveChanges();


                    MessageBox.Show($"cusntomer name  {custname}\n" + $"date returnned  {date_returned}\n" + $"car type {cartype}\n" + "thank you for ordering");
                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

                }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = car_Rental_DbEntities.tab1.ToList();
            cardrop.DisplayMember = "name";
            cardrop.ValueMember = "id";
            cardrop.DataSource = cars;
        }
    }
    }

