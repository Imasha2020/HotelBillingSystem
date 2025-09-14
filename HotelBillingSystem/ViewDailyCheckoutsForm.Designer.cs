namespace HotelBillingSystem
{
    partial class ViewDailyCheckoutsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResturantCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WellnessCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirPortCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackHomeBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.name,
            this.CheckInDate,
            this.RoomType,
            this.BarCharges,
            this.ResturantCharges,
            this.WellnessCharges,
            this.AirPortCharges,
            this.NetPayment});
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // CheckInDate
            // 
            this.CheckInDate.HeaderText = "Check-in Date";
            this.CheckInDate.MinimumWidth = 6;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Width = 125;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.Width = 125;
            // 
            // BarCharges
            // 
            this.BarCharges.HeaderText = "Bar/Lounges Charges";
            this.BarCharges.MinimumWidth = 6;
            this.BarCharges.Name = "BarCharges";
            this.BarCharges.Width = 125;
            // 
            // ResturantCharges
            // 
            this.ResturantCharges.HeaderText = "Resturant Charges";
            this.ResturantCharges.MinimumWidth = 6;
            this.ResturantCharges.Name = "ResturantCharges";
            this.ResturantCharges.Width = 125;
            // 
            // WellnessCharges
            // 
            this.WellnessCharges.HeaderText = "Wellness & Fitness Charges";
            this.WellnessCharges.MinimumWidth = 6;
            this.WellnessCharges.Name = "WellnessCharges";
            this.WellnessCharges.Width = 125;
            // 
            // AirPortCharges
            // 
            this.AirPortCharges.HeaderText = "AirPort Pickup Charges";
            this.AirPortCharges.MinimumWidth = 6;
            this.AirPortCharges.Name = "AirPortCharges";
            this.AirPortCharges.Width = 125;
            // 
            // NetPayment
            // 
            this.NetPayment.HeaderText = "Net Payment";
            this.NetPayment.MinimumWidth = 6;
            this.NetPayment.Name = "NetPayment";
            this.NetPayment.Width = 125;
            // 
            // BackHomeBtn2
            // 
            this.BackHomeBtn2.Location = new System.Drawing.Point(892, 385);
            this.BackHomeBtn2.Name = "BackHomeBtn2";
            this.BackHomeBtn2.Size = new System.Drawing.Size(166, 23);
            this.BackHomeBtn2.TabIndex = 16;
            this.BackHomeBtn2.Text = "BACK TO HOME";
            this.BackHomeBtn2.UseVisualStyleBackColor = true;
            this.BackHomeBtn2.Click += new System.EventHandler(this.BackHomeBtn2_Click);
            // 
            // ViewDailyCheckoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.BackHomeBtn2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDailyCheckoutsForm";
            this.Text = "ViewDailyCheckoutsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResturantCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn WellnessCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirPortCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPayment;
        private System.Windows.Forms.Button BackHomeBtn2;
    }
}