namespace Messenger
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
            this.rch_GelenYazi = new System.Windows.Forms.RichTextBox();
            this.rch_GidenYazi = new System.Windows.Forms.RichTextBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.lst_KisiListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rch_GelenYazi
            // 
            this.rch_GelenYazi.Location = new System.Drawing.Point(9, 10);
            this.rch_GelenYazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rch_GelenYazi.Name = "rch_GelenYazi";
            this.rch_GelenYazi.Size = new System.Drawing.Size(466, 261);
            this.rch_GelenYazi.TabIndex = 0;
            this.rch_GelenYazi.Text = "";
            // 
            // rch_GidenYazi
            // 
            this.rch_GidenYazi.Location = new System.Drawing.Point(9, 285);
            this.rch_GidenYazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rch_GidenYazi.Name = "rch_GidenYazi";
            this.rch_GidenYazi.Size = new System.Drawing.Size(466, 101);
            this.rch_GidenYazi.TabIndex = 1;
            this.rch_GidenYazi.Text = "";
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackgroundImage = global::Messenger.Properties.Resources.mail_send;
            this.btn_Gonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gonder.Location = new System.Drawing.Point(489, 340);
            this.btn_Gonder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(81, 46);
            this.btn_Gonder.TabIndex = 2;
            this.btn_Gonder.Text = "GÖNDER";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            // 
            // lst_KisiListesi
            // 
            this.lst_KisiListesi.FormattingEnabled = true;
            this.lst_KisiListesi.Location = new System.Drawing.Point(489, 10);
            this.lst_KisiListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_KisiListesi.Name = "lst_KisiListesi";
            this.lst_KisiListesi.Size = new System.Drawing.Size(99, 277);
            this.lst_KisiListesi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 403);
            this.Controls.Add(this.lst_KisiListesi);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.rch_GidenYazi);
            this.Controls.Add(this.rch_GelenYazi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rch_GelenYazi;
        private System.Windows.Forms.RichTextBox rch_GidenYazi;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.ListBox lst_KisiListesi;
    }
}

