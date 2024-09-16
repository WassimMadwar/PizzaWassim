using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rb_Normal.Checked = true;
        }
        
        //******************************************************************
        void ResetForm()
        {
            btn_OkOrder.Enabled = true;
            Size_Box.Enabled = true;
            CrustType_Box.Enabled = true;
            Toppings_Box.Enabled = true;
            rb_Normal.Checked = true;
            rb_Smal.Checked = true;
            tb_Eat.Text = "Gast";
            rb_TakeOut.    Checked = false;
            rb_EatIn.      Checked = false;
            chk_ExtraChese.Checked = false;
            chk_Mushrooms. Checked = false;
            chk_Olives.    Checked = false;
            chk_Onion.     Checked = false;
            chk_Pappers.   Checked = false;
            chk_Tomatoes.  Checked = false;
            rb_Thin.       Checked = false;
            rb_Think.      Checked = false;
        }

        void UpdateOrderSummary()
        {

            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateTotalPrice();
            //UpdateWhereToEat();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rb_Smal.Checked)
            {
                tb_SizePizza.Text = " Small";
                return;
            }

            if (rb_Medium.Checked)
            {
                tb_SizePizza.Text = " Medium";
                return;
            }

            if (rb_Large.Checked)
            {
                tb_SizePizza.Text = " Large";
                return;
            }

        }

        void UpdateCrust()
        {

            UpdateTotalPrice();


            if(rb_Normal.Checked)
            {
                tb_CrustType.Text = " Normal Crust";
                return;
            }

            if (rb_Thin.Checked)
            {
                tb_CrustType.Text = " Thin Crust";
                return;
            }

            if (rb_Think.Checked)
            {
                tb_CrustType.Text = " Think Crust";
                return;
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chk_ExtraChese.Checked)
            {
                sToppings = " ExtraChese ";
            }

            if (chk_Olives.Checked)
            {
                sToppings += ", Olives ";
            }

            if (chk_Mushrooms.Checked)
            {
                sToppings += ", Mushrooms ";
            }

            if (chk_Tomatoes.Checked)
            {
                sToppings += ", Tomatoes ";
            }

            if (chk_Onion.Checked)
            {
                sToppings += ", Onion ";
            }

            if (chk_Pappers.Checked)
            {
                sToppings += ", G.Pappers ";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings=="")
            {
                sToppings = " No Toppings ";
            }

            tb_Toppings.Text = sToppings;

        }
        
        //******************************************************************
        
        void UpdateTotalPrice()
        {
            tb_TotalPrise.Text = CalculateTotalPrice().ToString();
        }

        void UpdateWhereToEat()
        {
            if (rb_TakeOut.Checked)
            {
                tb_Eat.Text = " Take Way";
            }
            else
            {
                tb_Eat.Text = "Gast";
            }
        }

        float GetSelectedSizePrice()
        {
            if (rb_Smal.Checked)
                return Convert.ToSingle(rb_Smal.Tag);

            else if (rb_Medium.Checked)
                return Convert.ToSingle(rb_Medium.Tag);

            else 
                return Convert.ToSingle(rb_Large.Tag);
        }

        float CalculateToppingsPrice()
        {

            float ToppingsTotalPrice = 0;

            if(chk_ExtraChese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_ExtraChese.Tag);
            }

            if (chk_Onion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Onion.Tag);
            }

            if (chk_Tomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Tomatoes.Tag);
            }

            if (chk_Pappers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Pappers.Tag);
            }

            if (chk_Olives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Olives.Tag);
            }

            if (chk_Mushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chk_Mushrooms.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrutPrice()
        {

            if (rb_Thin.Checked)
            {
                return Convert.ToSingle(rb_Thin.Tag);
            }

            else if (rb_Normal.Checked)
            {
                return Convert.ToSingle(rb_Normal.Tag);
            }

            else
            {
                return Convert.ToSingle(rb_Think.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            return( GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice());
        }

        private void rb_Smal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_Medium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_Large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        //******************************************************************

        private void rb_Normal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rb_Thin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rb_Think_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        //******************************************************************
        //******************************************************************
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btn_OkOrder_Click(object sender, EventArgs e)
        {

            //the second Position to the Caption ,the thirds  to the Buttons, the forth to Icon, fifth to the TabIndex 
            if (MessageBox.Show(" Do you wont  to Kasen ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form FormOrderMessage = new FormConfirmOrder();
                FormOrderMessage.ShowDialog();
                btn_OkOrder.Enabled = false;
                Size_Box.Enabled = false;
                CrustType_Box.Enabled = false;
                Toppings_Box.Enabled = false;
            }
        }
        private void btn_RestForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //******************************************************************
        //******************************************************************
        private void chk_ExtraChese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Pappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void WhereToEat_Box_Validated(object sender, EventArgs e)
        {

        }

        private void WhereToEat_Box_DragEnter(object sender, DragEventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rb_TakeOut_CheckedChanged(object sender, EventArgs e)
        {

            UpdateWhereToEat();
        }

        //******************************************************************
        //******************************************************************


    }
}
