
namespace E_160420016_John_GrabFoodDeals
{
    partial class FormDisplayMenu
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRestaurantName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(18, 34);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(404, 407);
            this.listBoxData.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of menu available in restaurant :";
            // 
            // comboBoxRestaurantName
            // 
            this.comboBoxRestaurantName.FormattingEnabled = true;
            this.comboBoxRestaurantName.Location = new System.Drawing.Point(197, 7);
            this.comboBoxRestaurantName.Name = "comboBoxRestaurantName";
            this.comboBoxRestaurantName.Size = new System.Drawing.Size(225, 21);
            this.comboBoxRestaurantName.TabIndex = 6;
            this.comboBoxRestaurantName.SelectedValueChanged += new System.EventHandler(this.comboBoxRestaurantName_SelectedValueChanged);
            // 
            // FormDisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 453);
            this.Controls.Add(this.comboBoxRestaurantName);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.label1);
            this.Name = "FormDisplayMenu";
            this.Text = "Display Menu";
            this.Load += new System.EventHandler(this.FormDisplayMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRestaurantName;
    }
}