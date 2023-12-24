using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiService.Forms
{
    public partial class dateSelectionForm : Form
    {
        public DateTime SelectedFromDate;
        public DateTime SelectedToDate;
        public dateSelectionForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SelectedFromDate = fromDateTimePicker.Value;
            SelectedToDate = toDateTimePicker.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
