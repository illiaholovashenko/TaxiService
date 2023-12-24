using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.Models;
using static TaxiService.Models.Review;

namespace TaxiService.Forms
{
    public partial class ReviewForm : Form
    {
        Passenger passenger;
        int orderId;
        Review review;
        public ReviewForm(Passenger passenger, int orderId)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.orderId = orderId;
        }

        private void reviewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reviewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter.Fill(this.taxiDataSet.Review);
            if (GetReview("Order_id", orderId.ToString()) != null)
            {
                review = GetReview("Order_id", orderId.ToString());
            }
            else
            {
                review = new Review(0, "", DateTime.Now, orderId);
            }
            ratingNumericUpDown.Value = Convert.ToDecimal(review.Rating);
            commentTextBox.Text = review.Comment;
        }

        private void setReviewButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви підтверджуєте оновлення даних?",
                "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GetReview("Order_id", orderId.ToString()) != null)
                {
                    //update
                    reviewTableAdapter.CustomUpdateQuery(Convert.ToDouble(ratingNumericUpDown.Value),
                        commentTextBox.Text, orderId);
                }
                else
                {
                    //insert
                    reviewTableAdapter.InsertQuery(Convert.ToDouble(ratingNumericUpDown.Value),
                        commentTextBox.Text, review.CreationDateTime, orderId);
                }
                OrdersViewForm orders = new OrdersViewForm(passenger);
                orders.Show();
                this.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrdersViewForm orders = new OrdersViewForm(passenger);
            orders.Show();
            this.Hide();
        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
