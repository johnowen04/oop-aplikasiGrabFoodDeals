
namespace E_160420016_John_GrabFoodDeals
{
    partial class FormAddRestaurant
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRestaurantAddress = new System.Windows.Forms.TextBox();
            this.textBoxRestaurantName = new System.Windows.Forms.TextBox();
            this.textBoxRestaurantId = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurant Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restaurant Address :";
            // 
            // textBoxRestaurantAddress
            // 
            this.textBoxRestaurantAddress.Location = new System.Drawing.Point(125, 67);
            this.textBoxRestaurantAddress.Name = "textBoxRestaurantAddress";
            this.textBoxRestaurantAddress.Size = new System.Drawing.Size(211, 20);
            this.textBoxRestaurantAddress.TabIndex = 3;
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(125, 41);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(211, 20);
            this.textBoxRestaurantName.TabIndex = 4;
            // 
            // textBoxRestaurantId
            // 
            this.textBoxRestaurantId.Location = new System.Drawing.Point(125, 12);
            this.textBoxRestaurantId.Name = "textBoxRestaurantId";
            this.textBoxRestaurantId.Size = new System.Drawing.Size(211, 20);
            this.textBoxRestaurantId.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(261, 93);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(16, 134);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(323, 147);
            this.listBoxData.TabIndex = 7;
            // 
            // FormAddRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 293);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRestaurantId);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.textBoxRestaurantAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddRestaurant";
            this.Text = "Add Restaurant";
            this.Load += new System.EventHandler(this.FormAddRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRestaurantAddress;
        private System.Windows.Forms.TextBox textBoxRestaurantName;
        private System.Windows.Forms.TextBox textBoxRestaurantId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxData;
    }
}