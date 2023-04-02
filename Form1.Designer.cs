namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TBsurname = new TextBox();
            TBname = new TextBox();
            TBtext1 = new TextBox();
            TBtext2 = new TextBox();
            TBtext3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TBsurname
            // 
            TBsurname.Anchor = AnchorStyles.None;
            TBsurname.Location = new Point(131, 99);
            TBsurname.MaximumSize = new Size(187, 23);
            TBsurname.MinimumSize = new Size(187, 23);
            TBsurname.Name = "TBsurname";
            TBsurname.Size = new Size(187, 23);
            TBsurname.TabIndex = 1;
            // 
            // TBname
            // 
            TBname.Anchor = AnchorStyles.None;
            TBname.Location = new Point(131, 70);
            TBname.MaximumSize = new Size(187, 23);
            TBname.MinimumSize = new Size(187, 23);
            TBname.Name = "TBname";
            TBname.Size = new Size(187, 23);
            TBname.TabIndex = 0;
            // 
            // TBtext1
            // 
            TBtext1.Anchor = AnchorStyles.None;
            TBtext1.Location = new Point(131, 128);
            TBtext1.MaximumSize = new Size(187, 23);
            TBtext1.MinimumSize = new Size(187, 23);
            TBtext1.Name = "TBtext1";
            TBtext1.Size = new Size(187, 23);
            TBtext1.TabIndex = 2;
            // 
            // TBtext2
            // 
            TBtext2.Anchor = AnchorStyles.None;
            TBtext2.Location = new Point(131, 157);
            TBtext2.MaximumSize = new Size(187, 23);
            TBtext2.MinimumSize = new Size(187, 23);
            TBtext2.Name = "TBtext2";
            TBtext2.Size = new Size(187, 23);
            TBtext2.TabIndex = 3;
            // 
            // TBtext3
            // 
            TBtext3.Anchor = AnchorStyles.None;
            TBtext3.Location = new Point(131, 186);
            TBtext3.MaximumSize = new Size(187, 23);
            TBtext3.MinimumSize = new Size(187, 23);
            TBtext3.Name = "TBtext3";
            TBtext3.Size = new Size(187, 23);
            TBtext3.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 72);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 101);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 6;
            label2.Text = "Surname:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 130);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "text1:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 159);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 8;
            label4.Text = "text2:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 188);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 9;
            label5.Text = "text3:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 20);
            label6.Name = "label6";
            label6.Size = new Size(268, 30);
            label6.TabIndex = 10;
            label6.Text = "Generate Word document.";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(149, 247);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(384, 361);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBtext3);
            Controls.Add(TBtext2);
            Controls.Add(TBtext1);
            Controls.Add(TBname);
            Controls.Add(TBsurname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WinFormsApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBsurname;
        private TextBox TBname;
        private TextBox TBtext1;
        private TextBox TBtext2;
        private TextBox TBtext3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}