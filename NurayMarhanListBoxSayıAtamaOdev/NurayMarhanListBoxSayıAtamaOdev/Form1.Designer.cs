
namespace NurayMarhanListBoxSayıAtamaOdev
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
            this.cbmBirdenOnaKadar = new System.Windows.Forms.ComboBox();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.lbSag = new System.Windows.Forms.ListBox();
            this.lbRastgeleSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbmBirdenOnaKadar
            // 
            this.cbmBirdenOnaKadar.FormattingEnabled = true;
            this.cbmBirdenOnaKadar.Location = new System.Drawing.Point(181, 47);
            this.cbmBirdenOnaKadar.Name = "cbmBirdenOnaKadar";
            this.cbmBirdenOnaKadar.Size = new System.Drawing.Size(198, 24);
            this.cbmBirdenOnaKadar.TabIndex = 10;
            this.cbmBirdenOnaKadar.SelectedIndexChanged += new System.EventHandler(this.cbmBirdenOnaKadar_SelectedIndexChanged);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(229, 216);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(103, 44);
            this.btnSol.TabIndex = 9;
            this.btnSol.Text = "<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(229, 133);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(103, 44);
            this.btnSag.TabIndex = 8;
            this.btnSag.Text = ">>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // lbSag
            // 
            this.lbSag.FormattingEnabled = true;
            this.lbSag.ItemHeight = 16;
            this.lbSag.Location = new System.Drawing.Point(344, 105);
            this.lbSag.Name = "lbSag";
            this.lbSag.Size = new System.Drawing.Size(174, 244);
            this.lbSag.TabIndex = 7;
            // 
            // lbRastgeleSayilar
            // 
            this.lbRastgeleSayilar.FormattingEnabled = true;
            this.lbRastgeleSayilar.ItemHeight = 16;
            this.lbRastgeleSayilar.Location = new System.Drawing.Point(42, 105);
            this.lbRastgeleSayilar.Name = "lbRastgeleSayilar";
            this.lbRastgeleSayilar.Size = new System.Drawing.Size(174, 244);
            this.lbRastgeleSayilar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 392);
            this.Controls.Add(this.cbmBirdenOnaKadar);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.lbSag);
            this.Controls.Add(this.lbRastgeleSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmBirdenOnaKadar;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.ListBox lbSag;
        private System.Windows.Forms.ListBox lbRastgeleSayilar;
    }
}

