using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_Project
{
    public partial class Form1 : Form
    {


        void ResetForm()
        {

            //reset Groups
            btnPizzaOrder.Enabled = true;
            label2.Enabled  = true;
            grpBox1.Enabled = true;
            grpBox2.Enabled = true;
            grpBox3.Enabled = true;

            //reset Size
            radbtn2.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            grpBox2radio1.Checked = true;

            //reset Where to Eat
            grpBox3radio1.Checked = true;

            //Reset Order Button
            //btnOrderPizza.Enabled = true;

        }


        void GorupDisebld()
        {
            btnPizzaOrder.Enabled = false;
            label2.Enabled = false;
            grpBox1.Enabled = false;
            grpBox2.Enabled = false;
            grpBox3.Enabled = false;
        }


        void UpdateToppings()
        {

            CalculateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

                lblToppings.Text = sToppings;
        }

        float GetSelectedSizePrice()
        {
            if (radbtn1.Checked)

                return Convert.ToSingle(radbtn1.Tag);

            else if (radbtn2.Checked)

                return Convert.ToSingle(radbtn2.Tag);

            else
                return Convert.ToSingle(radbtn3.Tag);

        }

        void GetSelectedSizeOrder()
        {
            CalculateTotalPrice();
            if (radbtn1.Checked)
            {
                labNameOrderSize.Text = "Size: " + "Small";
                return;
            }

            if (radbtn2.Checked)
            {
                labNameOrderSize.Text = "Size: " + "Meduim";
                return;
            }
                        
            if (radbtn3.Checked)
            {
                labNameOrderSize.Text = "Size: " + "Larg";
                return;
            }

        }


        void GetSelectedOrderCurstType ()
        {
            CalculateTotalPrice();
            if (grpBox2radio1.Checked)
            {
                labCurstType.Text = "Curst Type: " + "Thin Curst";
            }

            if (grpBox2radio2.Checked)
            {
                labCurstType.Text = "Curst Type: " + "Think Curst";
            }
        }
               
        void GetSelectedOrderWhereToEat()
        {
            CalculateTotalPrice();
            if (grpBox3radio1.Checked)
            {
                labWhereToEat.Text = "Where To Eat: " + "Eat In";
            }

            if (grpBox3radio2.Checked)
            {
                labWhereToEat.Text = "Where To Eat: " + "Take Out";
            }
        }

        float GetSelectedCurstType()
        {
            if (grpBox2radio1.Checked)
                return Convert.ToSingle(grpBox2radio1.Tag);
            else
                return Convert.ToSingle(grpBox2radio2.Tag);

        }
               
        
        float GetSelectedToppings()
        {

            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
                          
            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
                       
            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }


            return ToppingsTotalPrice;


        }

        
        float GetCalculateTotalPrice ()
        {
             return GetSelectedSizePrice() + GetSelectedCurstType() + GetSelectedToppings();
        }        
        
        void CalculateTotalPrice ()
        {
            labPrice.Text = "$" + GetCalculateTotalPrice() ;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radbtn1_CheckedChanged_1(object sender, EventArgs e)
        {
            GetSelectedSizeOrder();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void radbtn2_CheckedChanged_1(object sender, EventArgs e)
        {
            GetSelectedSizeOrder();
        }

        private void radbtn3_CheckedChanged_1(object sender, EventArgs e)
        {
            GetSelectedSizeOrder();
        }

        private void grpBox2radio1_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectedOrderCurstType();
        }

        private void grpBox2radio2_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectedOrderCurstType();
        }

        private void grpBox3radio1_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectedOrderWhereToEat();
        }

        private void grpBox3radio2_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectedOrderWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void lblToppings_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Maximized;
        }

        private void btnPizzaOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfuly", "Success" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                GorupDisebld();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
