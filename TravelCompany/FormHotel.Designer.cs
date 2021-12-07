
namespace TravelCompany
{
    partial class FormHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudReiting = new System.Windows.Forms.NumericUpDown();
            this.txtOpisanie = new System.Windows.Forms.RichTextBox();
            this.CLBadd = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCodeCity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudReiting)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Наименование отеля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Рейтинг (из пяти)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Город ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(217, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(136, 22);
            this.txtTitle.TabIndex = 20;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить отель";
            // 
            // nudReiting
            // 
            this.nudReiting.Location = new System.Drawing.Point(20, 114);
            this.nudReiting.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudReiting.Name = "nudReiting";
            this.nudReiting.Size = new System.Drawing.Size(150, 22);
            this.nudReiting.TabIndex = 30;
            this.nudReiting.ValueChanged += new System.EventHandler(this.nudReiting_ValueChanged);
            // 
            // txtOpisanie
            // 
            this.txtOpisanie.Location = new System.Drawing.Point(217, 114);
            this.txtOpisanie.Name = "txtOpisanie";
            this.txtOpisanie.Size = new System.Drawing.Size(264, 172);
            this.txtOpisanie.TabIndex = 31;
            this.txtOpisanie.Text = "";
            this.txtOpisanie.TextChanged += new System.EventHandler(this.txtOpisanie_TextChanged);
            // 
            // CLBadd
            // 
            this.CLBadd.CheckOnClick = true;
            this.CLBadd.FormattingEnabled = true;
            this.CLBadd.Location = new System.Drawing.Point(497, 61);
            this.CLBadd.Name = "CLBadd";
            this.CLBadd.Size = new System.Drawing.Size(267, 225);
            this.CLBadd.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дополнительные возможности";
            // 
            // cbCodeCity
            // 
            this.cbCodeCity.FormattingEnabled = true;
            this.cbCodeCity.Location = new System.Drawing.Point(20, 64);
            this.cbCodeCity.Name = "cbCodeCity";
            this.cbCodeCity.Size = new System.Drawing.Size(166, 24);
            this.cbCodeCity.TabIndex = 34;
            //this.cbCodeCity.SelectionChangeCommitted += new System.EventHandler(this.cbCodeCity_SelectionChangeCommitted);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 292);
            this.Controls.Add(this.cbCodeCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CLBadd);
            this.Controls.Add(this.txtOpisanie);
            this.Controls.Add(this.nudReiting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHotel";
            this.Text = "Добавить отель";
            ((System.ComponentModel.ISupportInitialize)(this.nudReiting)).EndInit();
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
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudReiting;
        private System.Windows.Forms.RichTextBox txtOpisanie;
        private System.Windows.Forms.CheckedListBox CLBadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCodeCity;
    }
}