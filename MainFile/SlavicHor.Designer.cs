namespace MainFile
{
    partial class SlavicHor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlavicHor));
            this.SlavHo = new System.Windows.Forms.Label();
            this.SlavHo1 = new System.Windows.Forms.Label();
            this.SlavHo2 = new System.Windows.Forms.Label();
            this.SlavHo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SlavHo
            // 
            this.SlavHo.BackColor = System.Drawing.Color.Transparent;
            this.SlavHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlavHo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlavHo.ForeColor = System.Drawing.Color.White;
            this.SlavHo.Location = new System.Drawing.Point(286, 9);
            this.SlavHo.Name = "SlavHo";
            this.SlavHo.Size = new System.Drawing.Size(307, 44);
            this.SlavHo.TabIndex = 0;
            this.SlavHo.Text = "label1";
            this.SlavHo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SlavHo.Click += new System.EventHandler(this.SlavHop_Click);
            // 
            // SlavHo1
            // 
            this.SlavHo1.BackColor = System.Drawing.Color.Transparent;
            this.SlavHo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlavHo1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlavHo1.ForeColor = System.Drawing.Color.White;
            this.SlavHo1.Location = new System.Drawing.Point(93, 67);
            this.SlavHo1.Name = "SlavHo1";
            this.SlavHo1.Size = new System.Drawing.Size(691, 48);
            this.SlavHo1.TabIndex = 1;
            this.SlavHo1.Text = "label2";
            this.SlavHo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SlavHo2
            // 
            this.SlavHo2.BackColor = System.Drawing.Color.Transparent;
            this.SlavHo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlavHo2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlavHo2.ForeColor = System.Drawing.Color.White;
            this.SlavHo2.Location = new System.Drawing.Point(35, 137);
            this.SlavHo2.Name = "SlavHo2";
            this.SlavHo2.Size = new System.Drawing.Size(865, 147);
            this.SlavHo2.TabIndex = 2;
            this.SlavHo2.Text = "label3";
            // 
            // SlavHo3
            // 
            this.SlavHo3.BackColor = System.Drawing.Color.Transparent;
            this.SlavHo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlavHo3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlavHo3.ForeColor = System.Drawing.Color.White;
            this.SlavHo3.Location = new System.Drawing.Point(35, 301);
            this.SlavHo3.Name = "SlavHo3";
            this.SlavHo3.Size = new System.Drawing.Size(856, 157);
            this.SlavHo3.TabIndex = 3;
            this.SlavHo3.Text = "label4";
            this.SlavHo3.Click += new System.EventHandler(this.label1_Click);
            // 
            // SlavicHor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.SlavHo3);
            this.Controls.Add(this.SlavHo2);
            this.Controls.Add(this.SlavHo1);
            this.Controls.Add(this.SlavHo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "SlavicHor";
            this.Text = "Славянский гороскоп";
            this.Load += new System.EventHandler(this.SlavicHor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SlavHo;
        private System.Windows.Forms.Label SlavHo1;
        private System.Windows.Forms.Label SlavHo2;
        private System.Windows.Forms.Label SlavHo3;
    }
}