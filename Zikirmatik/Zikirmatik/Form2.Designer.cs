namespace Zikirmatik
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbaşla = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsayıarttır = new System.Windows.Forms.Button();
            this.lblsayılar = new System.Windows.Forms.Label();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // btnbaşla
            // 
            this.btnbaşla.Location = new System.Drawing.Point(257, 164);
            this.btnbaşla.Name = "btnbaşla";
            this.btnbaşla.Size = new System.Drawing.Size(75, 23);
            this.btnbaşla.TabIndex = 8;
            this.btnbaşla.Text = "Başla";
            this.btnbaşla.UseVisualStyleBackColor = true;
            this.btnbaşla.Click += new System.EventHandler(this.btnbaşla_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Black;
            this.btnreset.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmt1rstbtn;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreset.Enabled = false;
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(69, 183);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(56, 50);
            this.btnreset.TabIndex = 7;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsayıarttır
            // 
            this.btnsayıarttır.BackColor = System.Drawing.Color.Black;
            this.btnsayıarttır.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmt1btn;
            this.btnsayıarttır.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsayıarttır.Enabled = false;
            this.btnsayıarttır.FlatAppearance.BorderSize = 0;
            this.btnsayıarttır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsayıarttır.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsayıarttır.Location = new System.Drawing.Point(126, 228);
            this.btnsayıarttır.Name = "btnsayıarttır";
            this.btnsayıarttır.Size = new System.Drawing.Size(168, 155);
            this.btnsayıarttır.TabIndex = 6;
            this.btnsayıarttır.UseVisualStyleBackColor = false;
            this.btnsayıarttır.Click += new System.EventHandler(this.btnsayıarttır_Click);
            // 
            // lblsayılar
            // 
            this.lblsayılar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblsayılar.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayılar.Location = new System.Drawing.Point(84, 54);
            this.lblsayılar.Name = "lblsayılar";
            this.lblsayılar.Size = new System.Drawing.Size(248, 90);
            this.lblsayılar.TabIndex = 5;
            this.lblsayılar.Text = "00000";
            this.lblsayılar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(257, 197);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(75, 23);
            this.btncıkıs.TabIndex = 10;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zikirmatik.Properties.Resources.zikirmatik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 389);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbaşla);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsayıarttır);
            this.Controls.Add(this.lblsayılar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zikirmatik 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbaşla;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsayıarttır;
        private System.Windows.Forms.Label lblsayılar;
        private System.Windows.Forms.Button btncıkıs;
    }
}