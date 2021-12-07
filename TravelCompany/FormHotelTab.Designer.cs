
namespace TravelCompany
{
    partial class FormHotelTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotelTab));
            this.btnClose = new System.Windows.Forms.Button();
            this.DGVhotel = new System.Windows.Forms.DataGridView();
            this.btnHotel = new System.Windows.Forms.Button();
            this.DGVadditional_features = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVadditional_features)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(935, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 73);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Закрыть и вернуться в меню";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DGVhotel
            // 
            this.DGVhotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhotel.Location = new System.Drawing.Point(16, 48);
            this.DGVhotel.Name = "DGVhotel";
            this.DGVhotel.RowHeadersWidth = 51;
            this.DGVhotel.RowTemplate.Height = 24;
            this.DGVhotel.Size = new System.Drawing.Size(913, 348);
            this.DGVhotel.TabIndex = 26;
            this.DGVhotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVhotel_CellContentClick);
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(935, 352);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(149, 44);
            this.btnHotel.TabIndex = 27;
            this.btnHotel.Text = "Добавить отель";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // DGVadditional_features
            // 
            this.DGVadditional_features.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVadditional_features.Location = new System.Drawing.Point(16, 486);
            this.DGVadditional_features.Name = "DGVadditional_features";
            this.DGVadditional_features.RowHeadersWidth = 51;
            this.DGVadditional_features.RowTemplate.Height = 24;
            this.DGVadditional_features.Size = new System.Drawing.Size(402, 260);
            this.DGVadditional_features.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Таблица \"Отель и его дополнительные возможности\"";
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(216, 15);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(412, 22);
            this.txtSearch1.TabIndex = 31;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.Location = new System.Drawing.Point(634, 7);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(40, 38);
            this.btnSearch1.TabIndex = 30;
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(69, 448);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(268, 22);
            this.txtSearch2.TabIndex = 33;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch2.Image")));
            this.btnSearch2.Location = new System.Drawing.Point(343, 440);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(40, 38);
            this.btnSearch2.TabIndex = 32;
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // FormHotelTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 758);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVadditional_features);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.DGVhotel);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHotelTab";
            this.Text = "Отели";
            ((System.ComponentModel.ISupportInitialize)(this.DGVhotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVadditional_features)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView DGVhotel;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.DataGridView DGVadditional_features;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnSearch2;
    }
}