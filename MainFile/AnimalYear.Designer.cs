namespace MainFile
{
    partial class AnimalYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalYear));
            this.Animal = new System.Windows.Forms.Label();
            this.Animal1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Animal
            // 
            this.Animal.BackColor = System.Drawing.Color.Transparent;
            this.Animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Animal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Animal.ForeColor = System.Drawing.Color.White;
            this.Animal.Location = new System.Drawing.Point(356, 40);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(131, 44);
            this.Animal.TabIndex = 0;
            this.Animal.Text = "label1";
            this.Animal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Animal.Click += new System.EventHandler(this.Animal_Click);
            // 
            // Animal1
            // 
            this.Animal1.BackColor = System.Drawing.Color.Transparent;
            this.Animal1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Animal1.ForeColor = System.Drawing.Color.White;
            this.Animal1.Location = new System.Drawing.Point(49, 118);
            this.Animal1.Name = "Animal1";
            this.Animal1.Size = new System.Drawing.Size(857, 128);
            this.Animal1.TabIndex = 1;
            this.Animal1.Text = "label1";
            this.Animal1.Click += new System.EventHandler(this.Animal1_Click);
            // 
            // AnimalYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.Animal1);
            this.Controls.Add(this.Animal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "AnimalYear";
            this.Text = "Животное по китайскому календарю";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Animal;
        private System.Windows.Forms.Label Animal1;
    }
}