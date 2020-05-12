namespace NDP_ODEVDENEME3
{
    partial class NDPODEV3
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
            this.txtigirdi = new System.Windows.Forms.TextBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.btnHESAPLA = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtigirdi
            // 
            this.txtigirdi.BackColor = System.Drawing.Color.White;
            this.txtigirdi.Location = new System.Drawing.Point(250, 92);
            this.txtigirdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtigirdi.Multiline = true;
            this.txtigirdi.Name = "txtigirdi";
            this.txtigirdi.Size = new System.Drawing.Size(356, 26);
            this.txtigirdi.TabIndex = 0;
            this.txtigirdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtigirdi_KeyDown);
            this.txtigirdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtigirdi_KeyPress_1);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(249, 148);
            this.txtsonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(356, 27);
            this.txtsonuc.TabIndex = 1;
            this.txtsonuc.TextChanged += new System.EventHandler(this.txtsonuc_TextChanged);
            // 
            // btnHESAPLA
            // 
            this.btnHESAPLA.BackColor = System.Drawing.Color.Yellow;
            this.btnHESAPLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHESAPLA.Location = new System.Drawing.Point(80, 250);
            this.btnHESAPLA.Margin = new System.Windows.Forms.Padding(15, 40, 8, 6);
            this.btnHESAPLA.Name = "btnHESAPLA";
            this.btnHESAPLA.Size = new System.Drawing.Size(213, 75);
            this.btnHESAPLA.TabIndex = 2;
            this.btnHESAPLA.Text = "HESAPLA";
            this.btnHESAPLA.UseVisualStyleBackColor = false;
            this.btnHESAPLA.Click += new System.EventHandler(this.btnHESAPLA_Click_1);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Yellow;
            this.btncikis.Location = new System.Drawing.Point(358, 250);
            this.btncikis.Margin = new System.Windows.Forms.Padding(4);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(213, 75);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "CIKIS YAP";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISLEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "SONUC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Yellow;
            this.btnTemizle.Location = new System.Drawing.Point(227, 352);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(213, 75);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // NDPODEV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(617, 554);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnHESAPLA);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.txtigirdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NDPODEV3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtigirdi;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Button btnHESAPLA;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
    }
}

