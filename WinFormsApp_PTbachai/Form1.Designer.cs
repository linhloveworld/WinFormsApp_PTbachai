namespace WinFormsApp_PTbachai
{
    partial class Form_tinhPTbachai
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
            this.label_so_a = new System.Windows.Forms.Label();
            this.label_so_b = new System.Windows.Forms.Label();
            this.label_so_c = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkqTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_so_a
            // 
            this.label_so_a.AutoSize = true;
            this.label_so_a.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_so_a.Location = new System.Drawing.Point(52, 111);
            this.label_so_a.Name = "label_so_a";
            this.label_so_a.Size = new System.Drawing.Size(84, 46);
            this.label_so_a.TabIndex = 0;
            this.label_so_a.Text = "Số a";
            // 
            // label_so_b
            // 
            this.label_so_b.AutoSize = true;
            this.label_so_b.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_so_b.Location = new System.Drawing.Point(335, 111);
            this.label_so_b.Name = "label_so_b";
            this.label_so_b.Size = new System.Drawing.Size(87, 46);
            this.label_so_b.TabIndex = 1;
            this.label_so_b.Text = "Số b";
            // 
            // label_so_c
            // 
            this.label_so_c.AutoSize = true;
            this.label_so_c.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_so_c.Location = new System.Drawing.Point(638, 111);
            this.label_so_c.Name = "label_so_c";
            this.label_so_c.Size = new System.Drawing.Size(83, 46);
            this.label_so_c.TabIndex = 2;
            this.label_so_c.Text = "Số c";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(52, 191);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(108, 27);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(335, 191);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(108, 27);
            this.txtb.TabIndex = 4;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(638, 191);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(108, 27);
            this.txtc.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(591, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tính PT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkqTinh
            // 
            this.txtkqTinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkqTinh.Location = new System.Drawing.Point(52, 274);
            this.txtkqTinh.Multiline = true;
            this.txtkqTinh.Name = "txtkqTinh";
            this.txtkqTinh.Size = new System.Drawing.Size(320, 100);
            this.txtkqTinh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tính Phương trình bậc hai dạng: ax2 + bx + c =0";
            // 
            // Form_tinhPTbachai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkqTinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label_so_c);
            this.Controls.Add(this.label_so_b);
            this.Controls.Add(this.label_so_a);
            this.Name = "Form_tinhPTbachai";
            this.Text = "Tính Phương trình bậc hai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_so_a;
        private Label label_so_b;
        private Label label_so_c;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private Button button1;
        private TextBox txtkqTinh;
        private Label label1;
    }
}