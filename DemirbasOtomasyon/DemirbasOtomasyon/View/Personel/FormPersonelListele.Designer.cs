﻿namespace DemirbasOtomasyon.View
{
    partial class FormPersonelListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwPersonelListele = new System.Windows.Forms.DataGridView();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbUrunAramaIslemleri = new System.Windows.Forms.GroupBox();
            this.btnUrunBul = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbUrunAramaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonelListele
            // 
            this.dgwPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPersonelListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListele.Location = new System.Drawing.Point(32, 221);
            this.dgwPersonelListele.Name = "dgwPersonelListele";
            this.dgwPersonelListele.RowTemplate.Height = 24;
            this.dgwPersonelListele.Size = new System.Drawing.Size(1082, 402);
            this.dgwPersonelListele.TabIndex = 23;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(443, 23);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(217, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "PERSONELLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 24;
            // 
            // grbUrunAramaIslemleri
            // 
            this.grbUrunAramaIslemleri.Controls.Add(this.btnUrunBul);
            this.grbUrunAramaIslemleri.Controls.Add(this.txtUrunAd);
            this.grbUrunAramaIslemleri.Controls.Add(this.label3);
            this.grbUrunAramaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunAramaIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunAramaIslemleri.Location = new System.Drawing.Point(32, 105);
            this.grbUrunAramaIslemleri.Name = "grbUrunAramaIslemleri";
            this.grbUrunAramaIslemleri.Size = new System.Drawing.Size(1082, 110);
            this.grbUrunAramaIslemleri.TabIndex = 25;
            this.grbUrunAramaIslemleri.TabStop = false;
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Appearance.BackColor = System.Drawing.Color.White;
            this.btnUrunBul.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnUrunBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnUrunBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnUrunBul.Appearance.Options.UseBackColor = true;
            this.btnUrunBul.Appearance.Options.UseBorderColor = true;
            this.btnUrunBul.Appearance.Options.UseFont = true;
            this.btnUrunBul.Appearance.Options.UseForeColor = true;
            this.btnUrunBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUrunBul.Location = new System.Drawing.Point(382, 39);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(161, 41);
            this.btnUrunBul.TabIndex = 12;
            this.btnUrunBul.Text = "ARA";
            this.btnUrunBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(118, 47);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(200, 28);
            this.txtUrunAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel ID:";
            // 
            // FormPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.grbUrunAramaIslemleri);
            this.Controls.Add(this.dgwPersonelListele);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPersonelListele";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbUrunAramaIslemleri.ResumeLayout(false);
            this.grbUrunAramaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonelListele;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbUrunAramaIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnUrunBul;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label3;
    }
}