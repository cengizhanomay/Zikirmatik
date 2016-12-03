namespace Zikirmatik
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnsayıarttır = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnbaşla = new System.Windows.Forms.Button();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblsayı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsayıarttır
            // 
            this.btnsayıarttır.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmtk3butn;
            this.btnsayıarttır.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsayıarttır.Enabled = false;
            this.btnsayıarttır.Location = new System.Drawing.Point(183, 254);
            this.btnsayıarttır.Name = "btnsayıarttır";
            this.btnsayıarttır.Size = new System.Drawing.Size(91, 104);
            this.btnsayıarttır.TabIndex = 0;
            this.btnsayıarttır.UseVisualStyleBackColor = true;
            this.btnsayıarttır.Click += new System.EventHandler(this.btnsayıarttır_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmtk3reset;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreset.Enabled = false;
            this.btnreset.Location = new System.Drawing.Point(32, 131);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(68, 80);
            this.btnreset.TabIndex = 1;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnbaşla
            // 
            this.btnbaşla.Location = new System.Drawing.Point(138, 48);
            this.btnbaşla.Name = "btnbaşla";
            this.btnbaşla.Size = new System.Drawing.Size(75, 23);
            this.btnbaşla.TabIndex = 2;
            this.btnbaşla.Text = "Başla";
            this.btnbaşla.UseVisualStyleBackColor = true;
            this.btnbaşla.Click += new System.EventHandler(this.btnbaşla_Click);
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(226, 48);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(75, 23);
            this.btnçıkış.TabIndex = 3;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // lblsayı
            // 
            this.lblsayı.BackColor = System.Drawing.Color.Black;
            this.lblsayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayı.ForeColor = System.Drawing.Color.White;
            this.lblsayı.Location = new System.Drawing.Point(150, 140);
            this.lblsayı.Name = "lblsayı";
            this.lblsayı.Size = new System.Drawing.Size(165, 50);
            this.lblsayı.TabIndex = 5;
            this.lblsayı.Text = "00000";
            this.lblsayı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zikirmatik.Properties.Resources.zikirmatik31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 389);
            this.Controls.Add(this.lblsayı);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnçıkış);
            this.Controls.Add(this.btnbaşla);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsayıarttır);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zikirmatik 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayıarttır;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnbaşla;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblsayı;
    }
}