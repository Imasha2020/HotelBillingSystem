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
            this.BackHomeBtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewDailyCheckoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 450);
            this.Controls.Add(this.BackHomeBtn2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDailyCheckoutsForm";
            this.Text = "ViewDailyCheckoutsForm";
            this.Load += new System.EventHandler(this.ViewDailyCheckoutsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackHomeBtn2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}