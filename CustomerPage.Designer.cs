namespace VP_Midterm_Project
{
    partial class CustomerPage
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
            this.FactoryName = new System.Windows.Forms.Label();
            this.dropDownBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FactoryName
            // 
            this.FactoryName.AutoSize = true;
            this.FactoryName.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryName.ForeColor = System.Drawing.Color.Indigo;
            this.FactoryName.Location = new System.Drawing.Point(284, 32);
            this.FactoryName.Name = "FactoryName";
            this.FactoryName.Size = new System.Drawing.Size(106, 41);
            this.FactoryName.TabIndex = 0;
            this.FactoryName.Text = "label1";
            this.FactoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropDownBox
            // 
            this.dropDownBox.BackColor = System.Drawing.Color.White;
            this.dropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dropDownBox.FormatString = "categories of items";
            this.dropDownBox.FormattingEnabled = true;
            this.dropDownBox.Items.AddRange(new object[] {
            "Automobile",
            "Clothes & Textiles",
            "Food",
            "Construction Materials",
            "Mobile parts"});
            this.dropDownBox.Location = new System.Drawing.Point(262, 125);
            this.dropDownBox.MaxDropDownItems = 5;
            this.dropDownBox.Name = "dropDownBox";
            this.dropDownBox.Size = new System.Drawing.Size(262, 36);
            this.dropDownBox.TabIndex = 1;
            this.dropDownBox.Tag = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(304, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dropDownBox);
            this.Controls.Add(this.FactoryName);
            this.Name = "CustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FactoryName;
        private System.Windows.Forms.ComboBox dropDownBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}