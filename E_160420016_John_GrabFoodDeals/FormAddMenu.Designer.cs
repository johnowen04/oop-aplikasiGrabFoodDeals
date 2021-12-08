
namespace E_160420016_John_GrabFoodDeals
{
    partial class FormAddMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMenuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMenuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMenuType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMenuDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRestaurantName = new System.Windows.Forms.ComboBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Restaurant :";
            // 
            // textBoxMenuId
            // 
            this.textBoxMenuId.Location = new System.Drawing.Point(128, 42);
            this.textBoxMenuId.Name = "textBoxMenuId";
            this.textBoxMenuId.Size = new System.Drawing.Size(211, 20);
            this.textBoxMenuId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Menu ID :";
            // 
            // textBoxMenuName
            // 
            this.textBoxMenuName.Location = new System.Drawing.Point(128, 70);
            this.textBoxMenuName.Name = "textBoxMenuName";
            this.textBoxMenuName.Size = new System.Drawing.Size(211, 20);
            this.textBoxMenuName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Menu Name :";
            // 
            // textBoxMenuType
            // 
            this.textBoxMenuType.Location = new System.Drawing.Point(128, 98);
            this.textBoxMenuType.Name = "textBoxMenuType";
            this.textBoxMenuType.Size = new System.Drawing.Size(211, 20);
            this.textBoxMenuType.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Menu Type :";
            // 
            // textBoxMenuDescription
            // 
            this.textBoxMenuDescription.Location = new System.Drawing.Point(128, 128);
            this.textBoxMenuDescription.Multiline = true;
            this.textBoxMenuDescription.Name = "textBoxMenuDescription";
            this.textBoxMenuDescription.Size = new System.Drawing.Size(211, 80);
            this.textBoxMenuDescription.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Menu Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Menu Price :";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(128, 216);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(211, 20);
            this.numericUpDownPrice.TabIndex = 15;
            // 
            // comboBoxRestaurantName
            // 
            this.comboBoxRestaurantName.FormattingEnabled = true;
            this.comboBoxRestaurantName.Location = new System.Drawing.Point(128, 13);
            this.comboBoxRestaurantName.Name = "comboBoxRestaurantName";
            this.comboBoxRestaurantName.Size = new System.Drawing.Size(211, 21);
            this.comboBoxRestaurantName.TabIndex = 16;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(16, 279);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(323, 147);
            this.listBoxData.TabIndex = 17;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(264, 244);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 442);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.comboBoxRestaurantName);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMenuDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMenuType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMenuName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMenuId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddMenu";
            this.Text = "Add Menu";
            this.Load += new System.EventHandler(this.FormAddMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMenuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMenuName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMenuType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMenuDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxRestaurantName;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonSave;
    }
}