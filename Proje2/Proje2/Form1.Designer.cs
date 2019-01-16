namespace Proje2
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
            this.rtbKuyruk = new System.Windows.Forms.RichTextBox();
            this.rtbstack = new System.Windows.Forms.RichTextBox();
            this.btnkuyruk = new System.Windows.Forms.Button();
            this.btnstack = new System.Windows.Forms.Button();
            this.rtblist = new System.Windows.Forms.RichTextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.btncikart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbcikan = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbKuyruk
            // 
            this.rtbKuyruk.Location = new System.Drawing.Point(12, 90);
            this.rtbKuyruk.Name = "rtbKuyruk";
            this.rtbKuyruk.Size = new System.Drawing.Size(194, 237);
            this.rtbKuyruk.TabIndex = 0;
            this.rtbKuyruk.Text = "";
            // 
            // rtbstack
            // 
            this.rtbstack.Location = new System.Drawing.Point(236, 90);
            this.rtbstack.Name = "rtbstack";
            this.rtbstack.Size = new System.Drawing.Size(193, 237);
            this.rtbstack.TabIndex = 1;
            this.rtbstack.Text = "";
            // 
            // btnkuyruk
            // 
            this.btnkuyruk.Location = new System.Drawing.Point(45, 51);
            this.btnkuyruk.Name = "btnkuyruk";
            this.btnkuyruk.Size = new System.Drawing.Size(90, 33);
            this.btnkuyruk.TabIndex = 2;
            this.btnkuyruk.Text = "Kuyruğu Listele";
            this.btnkuyruk.UseVisualStyleBackColor = true;
            this.btnkuyruk.Click += new System.EventHandler(this.btnkuyruk_Click);
            // 
            // btnstack
            // 
            this.btnstack.Location = new System.Drawing.Point(275, 51);
            this.btnstack.Name = "btnstack";
            this.btnstack.Size = new System.Drawing.Size(91, 33);
            this.btnstack.TabIndex = 3;
            this.btnstack.Text = "Yığıtı Listele";
            this.btnstack.UseVisualStyleBackColor = true;
            this.btnstack.Click += new System.EventHandler(this.btnstack_Click);
            // 
            // rtblist
            // 
            this.rtblist.Location = new System.Drawing.Point(494, 90);
            this.rtblist.Name = "rtblist";
            this.rtblist.Size = new System.Drawing.Size(183, 237);
            this.rtblist.TabIndex = 4;
            this.rtblist.Text = "";
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(510, 42);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(149, 42);
            this.btnlist.TabIndex = 5;
            this.btnlist.Text = "Dairesel Bağlı Liste ile Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btncikart
            // 
            this.btncikart.Location = new System.Drawing.Point(764, 22);
            this.btncikart.Name = "btncikart";
            this.btncikart.Size = new System.Drawing.Size(100, 35);
            this.btncikart.TabIndex = 6;
            this.btncikart.Text = "Otoparktan araç çıkart";
            this.btncikart.UseVisualStyleBackColor = true;
            this.btncikart.Click += new System.EventHandler(this.btncikart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Çıkan Araçların Listesi";
            // 
            // rtbcikan
            // 
            this.rtbcikan.Location = new System.Drawing.Point(736, 90);
            this.rtbcikan.Name = "rtbcikan";
            this.rtbcikan.Size = new System.Drawing.Size(179, 237);
            this.rtbcikan.TabIndex = 8;
            this.rtbcikan.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 391);
            this.Controls.Add(this.rtbcikan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncikart);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.rtblist);
            this.Controls.Add(this.btnstack);
            this.Controls.Add(this.btnkuyruk);
            this.Controls.Add(this.rtbstack);
            this.Controls.Add(this.rtbKuyruk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbKuyruk;
        private System.Windows.Forms.RichTextBox rtbstack;
        private System.Windows.Forms.Button btnkuyruk;
        private System.Windows.Forms.Button btnstack;
        private System.Windows.Forms.RichTextBox rtblist;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btncikart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbcikan;
    }
}

