using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            NutritionForm nutriForm = new NutritionForm();

            if (bananaRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 banan";
                nutriForm.caloriesLabel.Text = "100";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.cardLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 popcorn";
                nutriForm.caloriesLabel.Text = "31";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.cardLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 duża babeczka";
                nutriForm.caloriesLabel.Text = "385";
                nutriForm.fatLabel.Text = "9";
                nutriForm.cardLabel.Text = "67";
            }
            nutriForm.ShowDialog();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
