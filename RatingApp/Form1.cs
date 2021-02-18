using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingApp
{
    public partial class Form1 : Form
    {
        List<RatingAppModal> listData = new List<RatingAppModal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lebBoxFoodQuality.Text.Equals(string.Empty))
                MessageBox.Show("please Select Food Quality for your review");
            else if (lebBoxStaffFriendliness.Text.Equals(string.Empty))
                MessageBox.Show("please Select Staff Friendliness for review");
            else if (lebBoxCleanliness.Text.Equals(string.Empty))
                MessageBox.Show("please Select Cleanliness for review");
            else if (lebBoxOrderAccuracy.Text.Equals(string.Empty))
                MessageBox.Show("please Select Order Accuracy for review");
            else if (lebBoxResturantAmbiance.Text.Equals(string.Empty))
                MessageBox.Show("please Select Resturant Ambiance for review");
            else if (lebBoxValueforMoney.Text.Equals(string.Empty))
                MessageBox.Show("please Select Value for Money in ours resturent for your review");
            else
            {
                string FileName = Application.StartupPath + @"\dataFile.csv";
                TextWriter tw = new StreamWriter(FileName);

                foreach (var item in listData)
                {
                    tw.WriteLine(item.CustomerName + "," + item.ContactNumber + "," + item.Email + "," + item.FoodQuality + "," + item.StaffFriendliness + "," + item.Cleanliness + "," + item.OrderAccuracy + "," + item.ResturantAmbiance + "," + item.ValueforMoney);
                }

                tw.WriteLine(txtCustomerName.Text + "," + txtContactNumber.Text + "," + txtEmailId.Text + "," + lebBoxFoodQuality.Text + "," + lebBoxStaffFriendliness.Text + "," + lebBoxCleanliness.Text + "," + lebBoxOrderAccuracy.Text + "," + lebBoxResturantAmbiance.Text + "," + lebBoxValueforMoney.Text);
                tw.Close();

                txtCustomerName.Text = string.Empty;
                txtContactNumber.Text = string.Empty;
                txtEmailId.Text = string.Empty;

                MessageBox.Show("Rated data added Successfully.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RatingAppModal ratingAppModal = new RatingAppModal();
            ratingAppModal.LoadRatingData(listData, Application.StartupPath + "\\dataFile.csv");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            RatingAppModal ratingAppModal = new RatingAppModal();
            ratingAppModal.LoadRatingData(listData, Application.StartupPath + @"\dataFile.csv");

            Form2 form2 = new Form2();
            form2.listData = listData;
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSV Files(*.csv)|*.csv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileData = open.FileName;

                RatingAppModal ratingAppModal = new RatingAppModal();
                ratingAppModal.LoadRatingData(listData, fileData);

                if (File.Exists(Application.StartupPath + @"\dataFile.csv"))
                {
                    File.Delete(Application.StartupPath + @"\dataFile.csv");
                }

                

                    File.Copy(fileData, Application.StartupPath + @"\dataFile.csv");

                    MessageBox.Show("Rating File Loaded Successfully.");

                    Form2 form2 = new Form2();
                    form2.listData = listData;
                    form2.ShowDialog();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FoodQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}