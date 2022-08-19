namespace LoginForm
{
    partial class Main
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
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.submit_label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(37, 66);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(100, 26);
            this.textFirst.TabIndex = 0;
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(37, 154);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(100, 26);
            this.textLast.TabIndex = 1;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(45, 31);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(86, 20);
            this.labelFirst.TabIndex = 2;
            this.labelFirst.Text = "First Name";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(37, 128);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(86, 20);
            this.labelLast.TabIndex = 3;
            this.labelLast.Text = "Last Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Undergraduate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 294);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Masters";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Courses";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 364);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Computer Science";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 394);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(187, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Software Engineering";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(382, 261);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(222, 73);
            this.Submit_btn.TabIndex = 10;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // submit_label
            // 
            this.submit_label.AutoSize = true;
            this.submit_label.Location = new System.Drawing.Point(460, 364);
            this.submit_label.Name = "submit_label";
            this.submit_label.Size = new System.Drawing.Size(0, 20);
            this.submit_label.TabIndex = 11;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(382, 360);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(222, 69);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.submit_label);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label submit_label;
        private System.Windows.Forms.Button cancel_btn;
    }
}