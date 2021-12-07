
namespace TravelCompany
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodeWorker = new System.Windows.Forms.ComboBox();
            this.cbCodeClient = new System.Windows.Forms.ComboBox();
            this.DGVtour = new System.Windows.Forms.DataGridView();
            this.DateRegistr = new System.Windows.Forms.DateTimePicker();
            this.txtCodeTour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtour)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Дата регистрации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Тур ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Клент ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сотрудник ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(35, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить заказ";
            // 
            // cbCodeWorker
            // 
            this.cbCodeWorker.FormattingEnabled = true;
            this.cbCodeWorker.Location = new System.Drawing.Point(21, 65);
            this.cbCodeWorker.Name = "cbCodeWorker";
            this.cbCodeWorker.Size = new System.Drawing.Size(166, 24);
            this.cbCodeWorker.TabIndex = 30;
            //this.cbCodeWorker.SelectionChangeCommitted += new System.EventHandler(this.cbCodeWorker_SelectionChangeCommitted);
            // 
            // cbCodeClient
            // 
            this.cbCodeClient.FormattingEnabled = true;
            this.cbCodeClient.Location = new System.Drawing.Point(21, 113);
            this.cbCodeClient.Name = "cbCodeClient";
            this.cbCodeClient.Size = new System.Drawing.Size(166, 24);
            this.cbCodeClient.TabIndex = 31;
            //this.cbCodeClient.SelectionChangeCommitted += new System.EventHandler(this.cbCodeClient_SelectionChangeCommitted);
            // 
            // DGVtour
            // 
            this.DGVtour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtour.Location = new System.Drawing.Point(402, 20);
            this.DGVtour.Name = "DGVtour";
            this.DGVtour.RowHeadersWidth = 51;
            this.DGVtour.RowTemplate.Height = 24;
            this.DGVtour.Size = new System.Drawing.Size(1450, 348);
            this.DGVtour.TabIndex = 34;
            this.DGVtour.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVtour_CellMouseClick);
            // 
            // DateRegistr
            // 
            this.DateRegistr.Location = new System.Drawing.Point(221, 115);
            this.DateRegistr.Name = "DateRegistr";
            this.DateRegistr.Size = new System.Drawing.Size(166, 22);
            this.DateRegistr.TabIndex = 35;
            this.DateRegistr.ValueChanged += new System.EventHandler(this.DateRegistr_ValueChanged);
            // 
            // txtCodeTour
            // 
            this.txtCodeTour.Location = new System.Drawing.Point(221, 67);
            this.txtCodeTour.Name = "txtCodeTour";
            this.txtCodeTour.Size = new System.Drawing.Size(166, 22);
            this.txtCodeTour.TabIndex = 36;
            this.txtCodeTour.TextChanged += new System.EventHandler(this.txtCodeTour_TextChanged_1);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 380);
            this.Controls.Add(this.txtCodeTour);
            this.Controls.Add(this.DateRegistr);
            this.Controls.Add(this.DGVtour);
            this.Controls.Add(this.cbCodeClient);
            this.Controls.Add(this.cbCodeWorker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.DGVtour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodeWorker;
        private System.Windows.Forms.ComboBox cbCodeClient;
        private System.Windows.Forms.DataGridView DGVtour;
        private System.Windows.Forms.DateTimePicker DateRegistr;
        private System.Windows.Forms.TextBox txtCodeTour;
    }
}