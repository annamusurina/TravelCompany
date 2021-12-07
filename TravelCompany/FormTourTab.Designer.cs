
namespace TravelCompany
{
    partial class FormTourTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTourTab));
            this.btnClose = new System.Windows.Forms.Button();
            this.DGVtour = new System.Windows.Forms.DataGridView();
            this.btnTour = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1483, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 73);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Закрыть и вернуться в меню";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DGVtour
            // 
            this.DGVtour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtour.Location = new System.Drawing.Point(16, 49);
            this.DGVtour.Name = "DGVtour";
            this.DGVtour.RowHeadersWidth = 51;
            this.DGVtour.RowTemplate.Height = 24;
            this.DGVtour.Size = new System.Drawing.Size(1450, 348);
            this.DGVtour.TabIndex = 26;
            this.DGVtour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVtour_CellContentClick);
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(1483, 353);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(149, 44);
            this.btnTour.TabIndex = 27;
            this.btnTour.Text = "Добавить тур";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(653, 16);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(406, 22);
            this.txtSearch2.TabIndex = 29;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch2.Image")));
            this.btnSearch2.Location = new System.Drawing.Point(1065, 8);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(40, 38);
            this.btnSearch2.TabIndex = 28;
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(191, 21);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(168, 22);
            this.txtSearch1.TabIndex = 31;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.Location = new System.Drawing.Point(365, 8);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(40, 38);
            this.btnSearch1.TabIndex = 30;
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "По номеру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "По отелю";
            // 
            // FormTourTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.DGVtour);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTourTab";
            this.Text = "Туры";
            ((System.ComponentModel.ISupportInitialize)(this.DGVtour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView DGVtour;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}