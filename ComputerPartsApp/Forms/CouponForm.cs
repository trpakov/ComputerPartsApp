using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class CouponForm : Form
    {
        internal Computer PC { get; private set; }

        public CouponForm()
        {
            InitializeComponent();
        }

        internal CouponForm(Computer pc)
        {
            InitializeComponent();
            PC = pc;
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            var isCorrect = PC.ApplyCoupon(textBoxCoupon.Text);

            if (!isCorrect)
            {
                var dResult = MessageBox.Show("Невалиден код за отстъпка", "Грешка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                if (dResult == DialogResult.Cancel) Close();            
            }
            else
            {
                MessageBox.Show("Успешно приложихте код за отстъпка!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
