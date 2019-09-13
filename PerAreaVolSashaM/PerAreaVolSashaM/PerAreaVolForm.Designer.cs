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
            this.lblQPerimeter = new System.Windows.Forms.Label();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.btnQPerimeter = new System.Windows.Forms.Button();
            this.btnQArea = new System.Windows.Forms.Button();
            this.lblAArea = new System.Windows.Forms.Label();
            this.btnQVolume = new System.Windows.Forms.Button();
            this.lblAVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQPerimeter
            // 
            this.lblQPerimeter.AutoSize = true;
            this.lblQPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQPerimeter.Location = new System.Drawing.Point(73, 151);
            this.lblQPerimeter.Name = "lblQPerimeter";
            this.lblQPerimeter.Size = new System.Drawing.Size(0, 17);
            this.lblQPerimeter.TabIndex = 0;
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAPerimeter.Location = new System.Drawing.Point(503, 89);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(45, 25);
            this.lblAPerimeter.TabIndex = 1;
            this.lblAPerimeter.Text = "???";
            // 
            // btnQPerimeter
            // 
            this.btnQPerimeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQPerimeter.Location = new System.Drawing.Point(110, 54);
            this.btnQPerimeter.Name = "btnQPerimeter";
            this.btnQPerimeter.Size = new System.Drawing.Size(278, 94);
            this.btnQPerimeter.TabIndex = 2;
            this.btnQPerimeter.Text = "Calculate the perimeter of a rectangle with a length of 5cm and a width of 8cm.";
            this.btnQPerimeter.UseVisualStyleBackColor = false;
            this.btnQPerimeter.Click += new System.EventHandler(this.BtnQPerimeter_Click);
            // 
            // btnQArea
            // 
            this.btnQArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQArea.ForeColor = System.Drawing.Color.Black;
            this.btnQArea.Location = new System.Drawing.Point(110, 180);
            this.btnQArea.Name = "btnQArea";
            this.btnQArea.Size = new System.Drawing.Size(278, 98);
            this.btnQArea.TabIndex = 3;
            this.btnQArea.Text = "Calculate the area of a circle with a radius of 7cm.";
            this.btnQArea.UseVisualStyleBackColor = false;
            this.btnQArea.Click += new System.EventHandler(this.BtnQArea_Click);
            // 
            // lblAArea
            // 
            this.lblAArea.AutoSize = true;
            this.lblAArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAArea.Location = new System.Drawing.Point(503, 217);
            this.lblAArea.Name = "lblAArea";
            this.lblAArea.Size = new System.Drawing.Size(45, 25);
            this.lblAArea.TabIndex = 4;
            this.lblAArea.Text = "???";
            // 
            // btnQVolume
            // 
            this.btnQVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQVolume.Location = new System.Drawing.Point(110, 310);
            this.btnQVolume.Name = "btnQVolume";
            this.btnQVolume.Size = new System.Drawing.Size(278, 98);
            this.btnQVolume.TabIndex = 5;
            this.btnQVolume.Text = "Calculate the volume of a sphere with a radius of 4cm.";
            this.btnQVolume.UseVisualStyleBackColor = false;
            this.btnQVolume.Click += new System.EventHandler(this.BtnQVolume_Click_1);
            // 
            // lblAVolume
            // 
            this.lblAVolume.AutoSize = true;
            this.lblAVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAVolume.Location = new System.Drawing.Point(503, 347);
            this.lblAVolume.Name = "lblAVolume";
            this.lblAVolume.Size = new System.Drawing.Size(45, 25);
            this.lblAVolume.TabIndex = 6;
            this.lblAVolume.Text = "???";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.lblAVolume);
            this.Controls.Add(this.btnQVolume);
            this.Controls.Add(this.lblAArea);
            this.Controls.Add(this.btnQArea);
            this.Controls.Add(this.btnQPerimeter);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.lblQPerimeter);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQPerimeter;
        private System.Windows.Forms.Label lblAPerimeter;
        private System.Windows.Forms.Button btnQPerimeter;
        private System.Windows.Forms.Button btnQArea;
        private System.Windows.Forms.Label lblAArea;
        private System.Windows.Forms.Button btnQVolume;
        private System.Windows.Forms.Label lblAVolume;
    }
}

