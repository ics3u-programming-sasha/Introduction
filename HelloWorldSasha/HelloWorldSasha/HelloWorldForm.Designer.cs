namespace HelloWorldSasha
{
    partial class framHelloWorld
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
            this.lblName = new System.Windows.Forms.Label();
            this.picBeach = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBeach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGreeting.Font = new System.Drawing.Font("Georgia", 30F);
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGreeting.Location = new System.Drawing.Point(261, 35);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(261, 46);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 20F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(320, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "By Sasha";
            // 
            // picBeach
            // 
            this.picBeach.Image = global::HelloWorldSasha.Properties.Resources.Beach;
            this.picBeach.Location = new System.Drawing.Point(160, 144);
            this.picBeach.Name = "picBeach";
            this.picBeach.Size = new System.Drawing.Size(460, 282);
            this.picBeach.TabIndex = 2;
            this.picBeach.TabStop = false;
            // 
            // framHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBeach);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGreeting);
            this.Name = "framHelloWorld";
            this.Text = "Hello World by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picBeach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picBeach;
    }
}

