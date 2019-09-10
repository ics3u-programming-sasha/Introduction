namespace PerAreaVolSashaM
{
    partial class frmPerAreaVol
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
            this.btnQPerimeter = new System.Windows.Forms.Button();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQPerimeter
            // 
            this.btnQPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQPerimeter.Location = new System.Drawing.Point(106, 68);
            this.btnQPerimeter.Name = "btnQPerimeter";
            this.btnQPerimeter.Size = new System.Drawing.Size(252, 102);
            this.btnQPerimeter.TabIndex = 0;
            this.btnQPerimeter.Text = "Calculate the perimeter of a rectangle with a length of 8cm and a width of 5cm.";
            this.btnQPerimeter.UseVisualStyleBackColor = true;
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAPerimeter.Location = new System.Drawing.Point(515, 107);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(45, 25);
            this.lblAPerimeter.TabIndex = 1;
            this.lblAPerimeter.Text = "???";
            this.lblAPerimeter.Click += new System.EventHandler(this.LblAPerimeter_Click);
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.btnQPerimeter);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQPerimeter;
        private System.Windows.Forms.Label lblAPerimeter;
    }
}

