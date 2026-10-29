using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSizeSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbSizeMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbSizeLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblCrustType.Text = "Thin";
                return;
            }

            if (rbThick.Checked)
            {
                lblCrustType.Text = "Thick";
                return;
            }
      
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkOlives.Checked)
            {
                sToppings = ", Olives";
            }

            if (chkMushrooms.Checked)
            {
                sToppings = ", Mushrooms";
            }

        }

        float GetSelectedSizePrice()
        {
            if (rbSizeSmall.Checked) 
            
                return Convert.ToSingle( rbSizeSmall.Tag);
            
            else if (rbSizeMedium.Checked)
            
                return Convert.ToSingle( rbSizeMedium.Tag);
            
            else rbSizeLarge.Checked  = (rbSizeLarge.Checked)
;
            return Convert.ToSingle( rbSizeLarge.Tag);
            
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
            return Convert.ToSingle(rbThin.Tag);

            else
                return Convert.ToSingle(rbThick.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrusyType.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }

        private void rbSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
    }
}
