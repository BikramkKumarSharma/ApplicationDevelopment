using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingApp
{
    public partial class Form2 : Form
    {
        public List<RatingAppModal> listData = new List<RatingAppModal>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RatingAppModal ratingAppModal = new RatingAppModal();

            foreach (var item in listData)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = index + 1;
                dataGridView1.Rows[index].Cells[1].Value = item.CustomerName;
                dataGridView1.Rows[index].Cells[2].Value = item.ContactNumber;
                dataGridView1.Rows[index].Cells[3].Value = item.Email;
                dataGridView1.Rows[index].Cells[4].Value = ratingAppModal.GetRating(item.FoodQuality) + " - " + item.FoodQuality;
                dataGridView1.Rows[index].Cells[5].Value = ratingAppModal.GetRating(item.StaffFriendliness) + " - " + item.StaffFriendliness;
                dataGridView1.Rows[index].Cells[6].Value = ratingAppModal.GetRating(item.Cleanliness) + " - " + item.Cleanliness;
                dataGridView1.Rows[index].Cells[7].Value = ratingAppModal.GetRating(item.OrderAccuracy) + " - " + item.OrderAccuracy;
                dataGridView1.Rows[index].Cells[8].Value = ratingAppModal.GetRating(item.ResturantAmbiance) + " - " + item.ResturantAmbiance;
                dataGridView1.Rows[index].Cells[9].Value = ratingAppModal.GetRating(item.ValueforMoney) + " - " + item.ValueforMoney;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
