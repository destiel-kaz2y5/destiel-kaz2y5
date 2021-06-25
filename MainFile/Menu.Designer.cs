namespace MainFile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ZnakZod = new System.Windows.Forms.Button();
            this.YearChi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataHap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SlavBut = new System.Windows.Forms.Button();
            this.DruidBut = new System.Windows.Forms.Button();
            this.ZodCom = new System.Windows.Forms.Button();
            this.DateH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZnakZod
            // 
            this.ZnakZod.BackColor = System.Drawing.Color.Transparent;
            this.ZnakZod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZnakZod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZnakZod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZnakZod.ForeColor = System.Drawing.Color.White;
            this.ZnakZod.Location = new System.Drawing.Point(677, 83);
            this.ZnakZod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ZnakZod.Name = "ZnakZod";
            this.ZnakZod.Size = new System.Drawing.Size(221, 86);
            this.ZnakZod.TabIndex = 0;
            this.ZnakZod.Text = "Знак зодиака";
            this.ZnakZod.UseVisualStyleBackColor = false;
            this.ZnakZod.Click += new System.EventHandler(this.ZnakZod_Click);
            // 
            // YearChi
            // 
            this.YearChi.BackColor = System.Drawing.Color.Transparent;
            this.YearChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.YearChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearChi.ForeColor = System.Drawing.Color.White;
            this.YearChi.Location = new System.Drawing.Point(431, 236);
            this.YearChi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.YearChi.Name = "YearChi";
            this.YearChi.Size = new System.Drawing.Size(221, 86);
            this.YearChi.TabIndex = 1;
            this.YearChi.Text = "Животное по китайскому календарю";
            this.YearChi.UseVisualStyleBackColor = false;
            this.YearChi.Click += new System.EventHandler(this.YearChi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Гороскоп";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataHap
            // 
            this.DataHap.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DataHap.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.DataHap.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.DataHap.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.DataHap.Location = new System.Drawing.Point(105, 277);
            this.DataHap.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.DataHap.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.DataHap.Name = "DataHap";
            this.DataHap.Size = new System.Drawing.Size(210, 29);
            this.DataHap.TabIndex = 6;
            this.DataHap.ValueChanged += new System.EventHandler(this.DataHap_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Укажите дату рождения:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SlavBut
            // 
            this.SlavBut.BackColor = System.Drawing.Color.Transparent;
            this.SlavBut.Cursor = System.Windows.Forms.Cursors.Default;
            this.SlavBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlavBut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlavBut.ForeColor = System.Drawing.Color.White;
            this.SlavBut.Location = new System.Drawing.Point(677, 236);
            this.SlavBut.Name = "SlavBut";
            this.SlavBut.Size = new System.Drawing.Size(221, 86);
            this.SlavBut.TabIndex = 9;
            this.SlavBut.Text = "Славянский гороскоп";
            this.SlavBut.UseVisualStyleBackColor = false;
            this.SlavBut.Click += new System.EventHandler(this.SlavBut_Click);
            // 
            // DruidBut
            // 
            this.DruidBut.BackColor = System.Drawing.Color.Transparent;
            this.DruidBut.Cursor = System.Windows.Forms.Cursors.Default;
            this.DruidBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DruidBut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DruidBut.ForeColor = System.Drawing.Color.White;
            this.DruidBut.Location = new System.Drawing.Point(677, 393);
            this.DruidBut.Name = "DruidBut";
            this.DruidBut.Size = new System.Drawing.Size(221, 86);
            this.DruidBut.TabIndex = 10;
            this.DruidBut.Text = "Гороскоп друидов";
            this.DruidBut.UseVisualStyleBackColor = false;
            this.DruidBut.Click += new System.EventHandler(this.DruidBut_Click);
            // 
            // ZodCom
            // 
            this.ZodCom.BackColor = System.Drawing.Color.Transparent;
            this.ZodCom.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZodCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZodCom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZodCom.ForeColor = System.Drawing.Color.White;
            this.ZodCom.Location = new System.Drawing.Point(431, 83);
            this.ZodCom.Name = "ZodCom";
            this.ZodCom.Size = new System.Drawing.Size(221, 86);
            this.ZodCom.TabIndex = 11;
            this.ZodCom.Text = "Проверить совместимость Знака Зодика";
            this.ZodCom.UseVisualStyleBackColor = false;
            this.ZodCom.Click += new System.EventHandler(this.ZodCom_Click);
            // 
            // DateH
            // 
            this.DateH.BackColor = System.Drawing.Color.Transparent;
            this.DateH.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateH.ForeColor = System.Drawing.Color.White;
            this.DateH.Location = new System.Drawing.Point(431, 393);
            this.DateH.Name = "DateH";
            this.DateH.Size = new System.Drawing.Size(221, 86);
            this.DateH.TabIndex = 12;
            this.DateH.Text = "Показать совместимые даты";
            this.DateH.UseVisualStyleBackColor = false;
            this.DateH.Click += new System.EventHandler(this.DateH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.DateH);
            this.Controls.Add(this.ZodCom);
            this.Controls.Add(this.DruidBut);
            this.Controls.Add(this.SlavBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataHap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearChi);
            this.Controls.Add(this.ZnakZod);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Form1";
            this.Text = "Гороскоп";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZnakZod;
        private System.Windows.Forms.Button YearChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataHap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SlavBut;
        private System.Windows.Forms.Button DruidBut;
        private System.Windows.Forms.Button ZodCom;
        private System.Windows.Forms.Button DateH;
    }
}

