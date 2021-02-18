
namespace RatingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lebBoxValueforMoney = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lebBoxResturantAmbiance = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lebBoxOrderAccuracy = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lebBoxCleanliness = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lebBoxStaffFriendliness = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lebBoxFoodQuality = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.btnLoadData);
            this.panel1.Controls.Add(this.btnShowData);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lebBoxValueforMoney);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lebBoxResturantAmbiance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lebBoxOrderAccuracy);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lebBoxCleanliness);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lebBoxStaffFriendliness);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lebBoxFoodQuality);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmailId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 581);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(490, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(149, 39);
            this.txtContactNumber.Mask = "(999) 000-0000";
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(362, 22);
            this.txtContactNumber.TabIndex = 2;
            this.txtContactNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtContactNumber_MaskInputRejected);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(359, 118);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(103, 68);
            this.btnLoadData.TabIndex = 20;
            this.btnLoadData.Text = "Load Data From CSV";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(185, 139);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(103, 27);
            this.btnShowData.TabIndex = 19;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lebBoxValueforMoney
            // 
            this.lebBoxValueforMoney.FormattingEnabled = true;
            this.lebBoxValueforMoney.ItemHeight = 16;
            this.lebBoxValueforMoney.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxValueforMoney.Location = new System.Drawing.Point(388, 481);
            this.lebBoxValueforMoney.Name = "lebBoxValueforMoney";
            this.lebBoxValueforMoney.Size = new System.Drawing.Size(186, 68);
            this.lebBoxValueforMoney.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Value for Money :";
            // 
            // lebBoxResturantAmbiance
            // 
            this.lebBoxResturantAmbiance.FormattingEnabled = true;
            this.lebBoxResturantAmbiance.ItemHeight = 16;
            this.lebBoxResturantAmbiance.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxResturantAmbiance.Location = new System.Drawing.Point(379, 346);
            this.lebBoxResturantAmbiance.Name = "lebBoxResturantAmbiance";
            this.lebBoxResturantAmbiance.Size = new System.Drawing.Size(186, 68);
            this.lebBoxResturantAmbiance.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resturant Ambiance :";
            // 
            // lebBoxOrderAccuracy
            // 
            this.lebBoxOrderAccuracy.FormattingEnabled = true;
            this.lebBoxOrderAccuracy.ItemHeight = 16;
            this.lebBoxOrderAccuracy.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxOrderAccuracy.Location = new System.Drawing.Point(388, 222);
            this.lebBoxOrderAccuracy.Name = "lebBoxOrderAccuracy";
            this.lebBoxOrderAccuracy.Size = new System.Drawing.Size(186, 68);
            this.lebBoxOrderAccuracy.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Order Accuracy :";
            // 
            // lebBoxCleanliness
            // 
            this.lebBoxCleanliness.FormattingEnabled = true;
            this.lebBoxCleanliness.ItemHeight = 16;
            this.lebBoxCleanliness.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxCleanliness.Location = new System.Drawing.Point(17, 481);
            this.lebBoxCleanliness.Name = "lebBoxCleanliness";
            this.lebBoxCleanliness.Size = new System.Drawing.Size(186, 68);
            this.lebBoxCleanliness.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cleanliness :";
            // 
            // lebBoxStaffFriendliness
            // 
            this.lebBoxStaffFriendliness.FormattingEnabled = true;
            this.lebBoxStaffFriendliness.ItemHeight = 16;
            this.lebBoxStaffFriendliness.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxStaffFriendliness.Location = new System.Drawing.Point(17, 346);
            this.lebBoxStaffFriendliness.Name = "lebBoxStaffFriendliness";
            this.lebBoxStaffFriendliness.Size = new System.Drawing.Size(186, 68);
            this.lebBoxStaffFriendliness.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Staff Friendliness :";
            // 
            // lebBoxFoodQuality
            // 
            this.lebBoxFoodQuality.FormattingEnabled = true;
            this.lebBoxFoodQuality.ItemHeight = 16;
            this.lebBoxFoodQuality.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.lebBoxFoodQuality.Location = new System.Drawing.Point(17, 222);
            this.lebBoxFoodQuality.Name = "lebBoxFoodQuality";
            this.lebBoxFoodQuality.Size = new System.Drawing.Size(186, 68);
            this.lebBoxFoodQuality.TabIndex = 7;
            this.lebBoxFoodQuality.SelectedIndexChanged += new System.EventHandler(this.FoodQuality_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Food Quality :";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(149, 67);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(362, 22);
            this.txtEmailId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Id. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Number :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(149, 11);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(362, 22);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 605);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rating App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lebBoxFoodQuality;
        private System.Windows.Forms.ListBox lebBoxValueforMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lebBoxResturantAmbiance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lebBoxOrderAccuracy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lebBoxCleanliness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lebBoxStaffFriendliness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.MaskedTextBox txtContactNumber;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnExit;
    }
}

