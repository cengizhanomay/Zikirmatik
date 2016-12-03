namespace Zikirmatik
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnsayıarttır = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnbaşla = new System.Windows.Forms.Button();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.lblsayı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsayıarttır
            // 
            this.btnsayıarttır.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmtkbutton;
            this.btnsayıarttır.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsayıarttır.Enabled = false;
            this.btnsayıarttır.Location = new System.Drawing.Point(128, 234);
            this.btnsayıarttır.Name = "btnsayıarttır";
            this.btnsayıarttır.Size = new System.Drawing.Size(154, 139);
            this.btnsayıarttır.TabIndex = 1;
            this.btnsayıarttır.UseVisualStyleBackColor = true;
            this.btnsayıarttır.Click += new System.EventHandler(this.btnsayıarttır_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = global::Zikirmatik.Properties.Resources.zkrmtkresetbtn;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreset.Enabled = false;
            this.btnreset.Location = new System.Drawing.Point(262, 197);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(58, 49);
            this.btnreset.TabIndex = 2;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnbaşla
            // 
            this.btnbaşla.Location = new System.Drawing.Point(171, 197);
            this.btnbaşla.Name = "btnbaşla";
            this.btnbaşla.Size = new System.Drawing.Size(75, 23);
            this.btnbaşla.TabIndex = 3;
            this.btnbaşla.Text = "Başla";
            this.btnbaşla.UseVisualStyleBackColor = true;
            this.btnbaşla.Click += new System.EventHandler(this.btnbaşla_Click);
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(90, 197);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(75, 23);
            this.btnçıkış.TabIndex = 4;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // lblsayı
            // 
            this.lblsayı.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblsayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayı.Location = new System.Drawing.Point(87, 65);
            this.lblsayı.Name = "lblsayı";
            this.lblsayı.Size = new System.Drawing.Size(243, 91);
            this.lblsayı.TabIndex = 5;
            this.lblsayı.Text = "00000";
            this.lblsayı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zikirmatik.Properties.Resources.zikirmatik2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblsayı);
            this.Controls.Add(this.btnçıkış);
            this.Controls.Add(this.btnbaşla);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsayıarttır);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zikirmatik 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayıarttır;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnbaşla;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Label lblsayı;
        private System.Windows.Forms.TextBox textBox1;
    }
}