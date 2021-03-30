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
    public partial class RemovePartForm : Form
    {
        bool changeIsMade = false;

        public RemovePartForm()
        {
            InitializeComponent();
        }

        private void RemovePart_Load(object sender, EventArgs e)
        {
            // Get all parts ordered by name, than by price
            comboBoxParts.Items.AddRange(Items.AllParts.OrderBy(x => x.GetType().Name).ThenBy(x => x.Price).ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (changeIsMade) DialogResult = DialogResult.OK;
            else
            {
                DialogResult = DialogResult.None;
                Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxParts.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете част за премахване", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("На път сте да премахнете част. Това действие не може да бъде отменено. Искате ли да продължите?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                // Remove selected part and reload parts
                Items.AllParts.Remove(comboBoxParts.SelectedItem as Part);
                comboBoxParts.Items.Clear();
                comboBoxParts.Items.AddRange(Items.AllParts.OrderBy(x => x.GetType().Name).ThenBy(x => x.Price).ToArray());
                MessageBox.Show($"Частта {comboBoxParts.SelectedItem} беше премахната успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changeIsMade = true;
            }
        }
    }
}
