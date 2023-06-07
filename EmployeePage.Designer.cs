namespace VP_Midterm_Project
{
    partial class EmployeePage
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
            this.Manufacture_button = new System.Windows.Forms.Button();
            this.Warehouse_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Manufacture_button
            // 
            this.Manufacture_button.BackColor = System.Drawing.Color.Indigo;
            this.Manufacture_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manufacture_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacture_button.ForeColor = System.Drawing.Color.White;
            this.Manufacture_button.Location = new System.Drawing.Point(128, 138);
            this.Manufacture_button.Name = "Manufacture_button";
            this.Manufacture_button.Size = new System.Drawing.Size(237, 42);
            this.Manufacture_button.TabIndex = 0;
            this.Manufacture_button.Text = "Manufacture";
            this.Manufacture_button.UseVisualStyleBackColor = false;
            this.Manufacture_button.Click += new System.EventHandler(this.Manufacture_button_Click);
            // 
            // Warehouse_button
            // 
            this.Warehouse_button.BackColor = System.Drawing.Color.Indigo;
            this.Warehouse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warehouse_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warehouse_button.ForeColor = System.Drawing.Color.White;
            this.Warehouse_button.Location = new System.Drawing.Point(129, 211);
            this.Warehouse_button.Name = "Warehouse_button";
            this.Warehouse_button.Size = new System.Drawing.Size(236, 43);
            this.Warehouse_button.TabIndex = 1;
            this.Warehouse_button.Text = "Warehouse inspection";
            this.Warehouse_button.UseVisualStyleBackColor = false;
            this.Warehouse_button.Click += new System.EventHandler(this.Warehouse_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Indigo;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.White;
            this.Back_button.Location = new System.Drawing.Point(12, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(88, 38);
            this.Back_button.TabIndex = 2;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 339);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Warehouse_button);
            this.Controls.Add(this.Manufacture_button);
            this.Name = "EmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Manufacture_button;
        private System.Windows.Forms.Button Warehouse_button;
        private System.Windows.Forms.Button Back_button;
    }
}