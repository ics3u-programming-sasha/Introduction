namespace HelloIntSasha
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbGreetings = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.grbGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Adobe Devanagari", 50F);
            this.lblGreeting.ForeColor = System.Drawing.Color.White;
            this.lblGreeting.Location = new System.Drawing.Point(209, 96);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(375, 91);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // grbGreetings
            // 
            this.grbGreetings.Controls.Add(this.radItalian);
            this.grbGreetings.Controls.Add(this.radSpanish);
            this.grbGreetings.Controls.Add(this.radFrench);
            this.grbGreetings.Controls.Add(this.radEnglish);
            this.grbGreetings.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.grbGreetings.ForeColor = System.Drawing.Color.White;
            this.grbGreetings.Location = new System.Drawing.Point(42, 250);
            this.grbGreetings.Name = "grbGreetings";
            this.grbGreetings.Size = new System.Drawing.Size(704, 118);
            this.grbGreetings.TabIndex = 1;
            this.grbGreetings.TabStop = false;
            this.grbGreetings.Text = "Language Select";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(28, 45);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(121, 35);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radFrench.Location = new System.Drawing.Point(194, 45);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(128, 35);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radSpanish.Location = new System.Drawing.Point(376, 45);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(127, 35);
            this.radSpanish.TabIndex = 2;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radItalian.Location = new System.Drawing.Point(548, 45);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(118, 35);
            this.radItalian.TabIndex = 3;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "italiano";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.RadItalian_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbGreetings);
            this.Controls.Add(this.lblGreeting);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "frmHelloInt";
            this.Text = "Hello, World! International by Sasha";
            this.grbGreetings.ResumeLayout(false);
            this.grbGreetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbGreetings;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radFrench;
    }
}

