namespace _2018_10_12_Kivetelkezeles
{
    partial class Form_kivetelkezeles
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
            this.TextBox_path = new System.Windows.Forms.TextBox();
            this.Button_create_file = new System.Windows.Forms.Button();
            this.Button_open_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_path
            // 
            this.TextBox_path.Location = new System.Drawing.Point(12, 20);
            this.TextBox_path.Name = "TextBox_path";
            this.TextBox_path.Size = new System.Drawing.Size(162, 20);
            this.TextBox_path.TabIndex = 0;
            // 
            // Button_create_file
            // 
            this.Button_create_file.Location = new System.Drawing.Point(189, 20);
            this.Button_create_file.Name = "Button_create_file";
            this.Button_create_file.Size = new System.Drawing.Size(92, 23);
            this.Button_create_file.TabIndex = 1;
            this.Button_create_file.Text = "Fájl létrehozás";
            this.Button_create_file.UseVisualStyleBackColor = true;
            // 
            // Button_open_file
            // 
            this.Button_open_file.Location = new System.Drawing.Point(100, 49);
            this.Button_open_file.Name = "Button_open_file";
            this.Button_open_file.Size = new System.Drawing.Size(87, 23);
            this.Button_open_file.TabIndex = 2;
            this.Button_open_file.Text = "Fájl beolvasás";
            this.Button_open_file.UseVisualStyleBackColor = true;
            // 
            // Form_kivetelkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.Button_open_file);
            this.Controls.Add(this.Button_create_file);
            this.Controls.Add(this.TextBox_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_kivetelkezeles";
            this.Text = "Kivételkezelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_path;
        private System.Windows.Forms.Button Button_create_file;
        private System.Windows.Forms.Button Button_open_file;
    }
}

