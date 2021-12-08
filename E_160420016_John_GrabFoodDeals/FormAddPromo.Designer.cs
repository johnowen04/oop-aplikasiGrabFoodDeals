
namespace E_160420016_John_GrabFoodDeals
{
    partial class FormAddPromo
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
            this.comboBoxRestaurantName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPromoName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPromoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerValidDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMaximumPrice = new System.Windows.Forms.NumericUpDown();
            this.listBoxDataPromo = new System.Windows.Forms.ListBox();
            this.listBoxDataRestaurant = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRestaurantName
            // 
            this.comboBoxRestaurantName.FormattingEnabled = true;
            this.comboBoxRestaurantName.Location = new System.Drawing.Point(125, 162);
            this.comboBoxRestaurantName.Name = "comboBoxRestaurantName";
            this.comboBoxRestaurantName.Size = new System.Drawing.Size(213, 21);
            this.comboBoxRestaurantName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choose Restaurant :";
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(263, 189);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(75, 23);
            this.buttonJoin.TabIndex = 19;
            this.buttonJoin.Text = "Join Promo";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Valid Date :";
            // 
            // textBoxPromoName
            // 
            this.textBoxPromoName.Location = new System.Drawing.Point(127, 41);
            this.textBoxPromoName.Name = "textBoxPromoName";
            this.textBoxPromoName.Size = new System.Drawing.Size(211, 20);
            this.textBoxPromoName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Promo Name :";
            // 
            // textBoxPromoId
            // 
            this.textBoxPromoId.Location = new System.Drawing.Point(127, 13);
            this.textBoxPromoId.Name = "textBoxPromoId";
            this.textBoxPromoId.Size = new System.Drawing.Size(211, 20);
            this.textBoxPromoId.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Promo ID :";
            // 
            // dateTimePickerValidDate
            // 
            this.dateTimePickerValidDate.Location = new System.Drawing.Point(127, 70);
            this.dateTimePickerValidDate.Name = "dateTimePickerValidDate";
            this.dateTimePickerValidDate.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerValidDate.TabIndex = 25;
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Location = new System.Drawing.Point(127, 101);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(211, 20);
            this.numericUpDownDiscount.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Discount (%) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Maximum Price (Rp) :";
            // 
            // numericUpDownMaximumPrice
            // 
            this.numericUpDownMaximumPrice.Location = new System.Drawing.Point(127, 133);
            this.numericUpDownMaximumPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownMaximumPrice.Name = "numericUpDownMaximumPrice";
            this.numericUpDownMaximumPrice.Size = new System.Drawing.Size(211, 20);
            this.numericUpDownMaximumPrice.TabIndex = 29;
            // 
            // listBoxDataPromo
            // 
            this.listBoxDataPromo.FormattingEnabled = true;
            this.listBoxDataPromo.Location = new System.Drawing.Point(18, 218);
            this.listBoxDataPromo.Name = "listBoxDataPromo";
            this.listBoxDataPromo.Size = new System.Drawing.Size(320, 251);
            this.listBoxDataPromo.TabIndex = 30;
            // 
            // listBoxDataRestaurant
            // 
            this.listBoxDataRestaurant.FormattingEnabled = true;
            this.listBoxDataRestaurant.Location = new System.Drawing.Point(362, 36);
            this.listBoxDataRestaurant.Name = "listBoxDataRestaurant";
            this.listBoxDataRestaurant.Size = new System.Drawing.Size(323, 433);
            this.listBoxDataRestaurant.TabIndex = 31;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(182, 189);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save Promo";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Restaurant yang termasuk dalam promo :";
            // 
            // FormAddPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxDataRestaurant);
            this.Controls.Add(this.listBoxDataPromo);
            this.Controls.Add(this.numericUpDownMaximumPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.dateTimePickerValidDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPromoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPromoId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.comboBoxRestaurantName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPromo";
            this.Text = "Add Promo";
            this.Load += new System.EventHandler(this.FormAddPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRestaurantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPromoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPromoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidDate;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMaximumPrice;
        private System.Windows.Forms.ListBox listBoxDataPromo;
        private System.Windows.Forms.ListBox listBoxDataRestaurant;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label7;
    }
}