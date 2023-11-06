namespace ChangeLayoutGUI
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
            this.EngToUkr = new System.Windows.Forms.RadioButton();
            this.UkrToEng = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_converter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EngToUkr
            // 
            this.EngToUkr.AutoSize = true;
            this.EngToUkr.Location = new System.Drawing.Point(388, 319);
            this.EngToUkr.Name = "EngToUkr";
            this.EngToUkr.Size = new System.Drawing.Size(166, 17);
            this.EngToUkr.TabIndex = 0;
            this.EngToUkr.TabStop = true;
            this.EngToUkr.Text = "З англійської на українську";
            this.EngToUkr.UseVisualStyleBackColor = true;
            // 
            // UkrToEng
            // 
            this.UkrToEng.AutoSize = true;
            this.UkrToEng.Location = new System.Drawing.Point(388, 342);
            this.UkrToEng.Name = "UkrToEng";
            this.UkrToEng.Size = new System.Drawing.Size(166, 17);
            this.UkrToEng.TabIndex = 1;
            this.UkrToEng.TabStop = true;
            this.UkrToEng.Text = "З української на англійську";
            this.UkrToEng.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(407, 365);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(125, 54);
            this.Start.TabIndex = 2;
            this.Start.Text = "Конвертувати";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 215);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(552, 88);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 215);
            this.textBox2.TabIndex = 4;
            // 
            // lbl_converter
            // 
            this.lbl_converter.AutoSize = true;
            this.lbl_converter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_converter.Location = new System.Drawing.Point(414, 34);
            this.lbl_converter.Name = "lbl_converter";
            this.lbl_converter.Size = new System.Drawing.Size(118, 13);
            this.lbl_converter.TabIndex = 5;
            this.lbl_converter.Text = "Конвертер розкладки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 514);
            this.Controls.Add(this.lbl_converter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.UkrToEng);
            this.Controls.Add(this.EngToUkr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EngToUkr;
        private System.Windows.Forms.RadioButton UkrToEng;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_converter;
    }
}

