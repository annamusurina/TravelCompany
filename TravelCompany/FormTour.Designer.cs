
namespace TravelCompany
{
    partial class FormTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTour));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFromWhere = new System.Windows.Forms.TextBox();
            this.txtToWhere = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOpisanie = new System.Windows.Forms.RichTextBox();
            this.cbCodeHotel = new System.Windows.Forms.ComboBox();
            this.cbCodeTransport = new System.Windows.Forms.ComboBox();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Откуда отправляется";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Куда прибывает";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Количество человек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Транспорт ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Отель ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(228, 169);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 22);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtFromWhere
            // 
            this.txtFromWhere.Location = new System.Drawing.Point(228, 74);
            this.txtFromWhere.Name = "txtFromWhere";
            this.txtFromWhere.Size = new System.Drawing.Size(136, 22);
            this.txtFromWhere.TabIndex = 20;
            this.txtFromWhere.TextChanged += new System.EventHandler(this.txtFromWhere_TextChanged);
            // 
            // txtToWhere
            // 
            this.txtToWhere.Location = new System.Drawing.Point(228, 122);
            this.txtToWhere.Name = "txtToWhere";
            this.txtToWhere.Size = new System.Drawing.Size(136, 22);
            this.txtToWhere.TabIndex = 19;
            this.txtToWhere.TextChanged += new System.EventHandler(this.txtToWhere_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(28, 169);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(153, 22);
            this.txtNumber.TabIndex = 18;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавить тур";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Описание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Дата прибытия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Дата отправления";
            // 
            // txtOpisanie
            // 
            this.txtOpisanie.Location = new System.Drawing.Point(401, 169);
            this.txtOpisanie.Name = "txtOpisanie";
            this.txtOpisanie.Size = new System.Drawing.Size(166, 178);
            this.txtOpisanie.TabIndex = 36;
            this.txtOpisanie.Text = "";
            this.txtOpisanie.TextChanged += new System.EventHandler(this.txtOpisanie_TextChanged);
            // 
            // cbCodeHotel
            // 
            this.cbCodeHotel.FormattingEnabled = true;
            this.cbCodeHotel.Location = new System.Drawing.Point(28, 71);
            this.cbCodeHotel.Name = "cbCodeHotel";
            this.cbCodeHotel.Size = new System.Drawing.Size(166, 24);
            this.cbCodeHotel.TabIndex = 41;
            //this.cbCodeHotel.SelectionChangeCommitted += new System.EventHandler(this.cbCodeHotel_SelectionChangeCommitted);
            // 
            // cbCodeTransport
            // 
            this.cbCodeTransport.FormattingEnabled = true;
            this.cbCodeTransport.Location = new System.Drawing.Point(28, 122);
            this.cbCodeTransport.Name = "cbCodeTransport";
            this.cbCodeTransport.Size = new System.Drawing.Size(166, 24);
            this.cbCodeTransport.TabIndex = 42;
            //this.cbCodeTransport.SelectionChangeCommitted += new System.EventHandler(this.cbCodeTransport_SelectionChangeCommitted);
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(401, 124);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(166, 22);
            this.DateTo.TabIndex = 43;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(401, 77);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(166, 22);
            this.DateFrom.TabIndex = 44;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 369);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.cbCodeTransport);
            this.Controls.Add(this.cbCodeHotel);
            this.Controls.Add(this.txtOpisanie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFromWhere);
            this.Controls.Add(this.txtToWhere);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTour";
            this.Text = "Добавить тур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFromWhere;
        private System.Windows.Forms.TextBox txtToWhere;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtOpisanie;
        private System.Windows.Forms.ComboBox cbCodeHotel;
        private System.Windows.Forms.ComboBox cbCodeTransport;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
    }
}