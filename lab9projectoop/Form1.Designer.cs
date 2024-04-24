namespace lab9projectoop
{
    partial class Form1
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
            this.btnDayMinus = new System.Windows.Forms.Button();
            this.btnDayPlus = new System.Windows.Forms.Button();
            this.btnMouthMinus = new System.Windows.Forms.Button();
            this.btnMouthPlus = new System.Windows.Forms.Button();
            this.btnYearMinus = new System.Windows.Forms.Button();
            this.btnYearPlus = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Label();
            this.Mouth = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.WData = new System.Windows.Forms.Label();
            this.LData = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDayMinus
            // 
            this.btnDayMinus.Location = new System.Drawing.Point(49, 154);
            this.btnDayMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDayMinus.Name = "btnDayMinus";
            this.btnDayMinus.Size = new System.Drawing.Size(100, 28);
            this.btnDayMinus.TabIndex = 0;
            this.btnDayMinus.Text = "-";
            this.btnDayMinus.UseVisualStyleBackColor = true;
            this.btnDayMinus.Click += new System.EventHandler(this.btnDayMinus_Click);
            // 
            // btnDayPlus
            // 
            this.btnDayPlus.Location = new System.Drawing.Point(157, 154);
            this.btnDayPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDayPlus.Name = "btnDayPlus";
            this.btnDayPlus.Size = new System.Drawing.Size(100, 28);
            this.btnDayPlus.TabIndex = 1;
            this.btnDayPlus.Text = "+";
            this.btnDayPlus.UseVisualStyleBackColor = true;
            this.btnDayPlus.Click += new System.EventHandler(this.btnDayPlus_Click);
            // 
            // btnMouthMinus
            // 
            this.btnMouthMinus.Location = new System.Drawing.Point(49, 229);
            this.btnMouthMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMouthMinus.Name = "btnMouthMinus";
            this.btnMouthMinus.Size = new System.Drawing.Size(100, 28);
            this.btnMouthMinus.TabIndex = 2;
            this.btnMouthMinus.Text = "-";
            this.btnMouthMinus.UseVisualStyleBackColor = true;
            this.btnMouthMinus.Click += new System.EventHandler(this.btnMouthMinus_Click);
            // 
            // btnMouthPlus
            // 
            this.btnMouthPlus.Location = new System.Drawing.Point(157, 229);
            this.btnMouthPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMouthPlus.Name = "btnMouthPlus";
            this.btnMouthPlus.Size = new System.Drawing.Size(100, 28);
            this.btnMouthPlus.TabIndex = 3;
            this.btnMouthPlus.Text = "+";
            this.btnMouthPlus.UseVisualStyleBackColor = true;
            this.btnMouthPlus.Click += new System.EventHandler(this.btnMouthPlus_Click);
            // 
            // btnYearMinus
            // 
            this.btnYearMinus.Location = new System.Drawing.Point(49, 300);
            this.btnYearMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnYearMinus.Name = "btnYearMinus";
            this.btnYearMinus.Size = new System.Drawing.Size(100, 28);
            this.btnYearMinus.TabIndex = 4;
            this.btnYearMinus.Text = "-";
            this.btnYearMinus.UseVisualStyleBackColor = true;
            this.btnYearMinus.Click += new System.EventHandler(this.btnYearMinus_Click);
            // 
            // btnYearPlus
            // 
            this.btnYearPlus.Location = new System.Drawing.Point(157, 300);
            this.btnYearPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnYearPlus.Name = "btnYearPlus";
            this.btnYearPlus.Size = new System.Drawing.Size(100, 28);
            this.btnYearPlus.TabIndex = 5;
            this.btnYearPlus.Text = "+";
            this.btnYearPlus.UseVisualStyleBackColor = true;
            this.btnYearPlus.Click += new System.EventHandler(this.btnYearPlus_Click);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(45, 134);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(35, 16);
            this.Day.TabIndex = 6;
            this.Day.Text = "Day:";
            // 
            // Mouth
            // 
            this.Mouth.AutoSize = true;
            this.Mouth.Location = new System.Drawing.Point(45, 209);
            this.Mouth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mouth.Name = "Mouth";
            this.Mouth.Size = new System.Drawing.Size(46, 16);
            this.Mouth.TabIndex = 7;
            this.Mouth.Text = "Month:";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(45, 281);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(39, 16);
            this.Year.TabIndex = 8;
            this.Year.Text = "Year:";
            // 
            // WData
            // 
            this.WData.AutoSize = true;
            this.WData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WData.Location = new System.Drawing.Point(43, 81);
            this.WData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WData.Name = "WData";
            this.WData.Size = new System.Drawing.Size(89, 36);
            this.WData.TabIndex = 9;
            this.WData.Text = "Date:";
            // 
            // LData
            // 
            this.LData.AutoSize = true;
            this.LData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LData.Location = new System.Drawing.Point(43, 381);
            this.LData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LData.Name = "LData";
            this.LData.Size = new System.Drawing.Size(107, 36);
            this.LData.TabIndex = 10;
            this.LData.Text = "LDate:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(49, 457);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(208, 22);
            this.textBoxData.TabIndex = 11;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 554);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.LData);
            this.Controls.Add(this.WData);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Mouth);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.btnYearPlus);
            this.Controls.Add(this.btnYearMinus);
            this.Controls.Add(this.btnMouthPlus);
            this.Controls.Add(this.btnMouthMinus);
            this.Controls.Add(this.btnDayPlus);
            this.Controls.Add(this.btnDayMinus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDayMinus;
        private System.Windows.Forms.Button btnDayPlus;
        private System.Windows.Forms.Button btnMouthMinus;
        private System.Windows.Forms.Button btnMouthPlus;
        private System.Windows.Forms.Button btnYearMinus;
        private System.Windows.Forms.Button btnYearPlus;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Mouth;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label WData;
        private System.Windows.Forms.Label LData;
        private System.Windows.Forms.TextBox textBoxData;
    }
}
