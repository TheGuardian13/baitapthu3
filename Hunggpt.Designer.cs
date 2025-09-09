namespace baitapthu3
{
    partial class Hunggpt
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGiai = new System.Windows.Forms.Button();
            this.Ketqua = new System.Windows.Forms.Label();
            this.Nhapc = new System.Windows.Forms.Label();
            this.Nhapb = new System.Windows.Forms.Label();
            this.Nhapa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Location = new System.Drawing.Point(77, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 46);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKQ.Location = new System.Drawing.Point(220, 363);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKQ.Size = new System.Drawing.Size(268, 76);
            this.txtKQ.TabIndex = 24;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtC.Location = new System.Drawing.Point(220, 305);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 30);
            this.txtC.TabIndex = 23;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtB.Location = new System.Drawing.Point(220, 232);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 22;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtA.Location = new System.Drawing.Point(220, 161);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(730, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 46);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGiai
            // 
            this.btnGiai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiai.Location = new System.Drawing.Point(329, 466);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(257, 46);
            this.btnGiai.TabIndex = 19;
            this.btnGiai.Text = "Giải Phương Trình";
            this.btnGiai.UseVisualStyleBackColor = false;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // Ketqua
            // 
            this.Ketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Ketqua.Location = new System.Drawing.Point(68, 381);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(120, 30);
            this.Ketqua.TabIndex = 18;
            this.Ketqua.Text = "Kết quả";
            // 
            // Nhapc
            // 
            this.Nhapc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Nhapc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nhapc.Location = new System.Drawing.Point(68, 305);
            this.Nhapc.Name = "Nhapc";
            this.Nhapc.Size = new System.Drawing.Size(100, 30);
            this.Nhapc.TabIndex = 17;
            this.Nhapc.Text = "Nhập c =";
            // 
            // Nhapb
            // 
            this.Nhapb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Nhapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nhapb.Location = new System.Drawing.Point(68, 232);
            this.Nhapb.Name = "Nhapb";
            this.Nhapb.Size = new System.Drawing.Size(100, 30);
            this.Nhapb.TabIndex = 16;
            this.Nhapb.Text = "Nhập b =";
            // 
            // Nhapa
            // 
            this.Nhapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Nhapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nhapa.Location = new System.Drawing.Point(68, 161);
            this.Nhapa.Name = "Nhapa";
            this.Nhapa.Size = new System.Drawing.Size(100, 30);
            this.Nhapa.TabIndex = 15;
            this.Nhapa.Text = "Nhập a =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(253, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phương trình: ax2+bx+c=0 (a khác 0)";
            // 
            // tieuDe
            // 
            this.tieuDe.AutoSize = true;
            this.tieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tieuDe.Location = new System.Drawing.Point(193, 24);
            this.tieuDe.Name = "tieuDe";
            this.tieuDe.Size = new System.Drawing.Size(550, 29);
            this.tieuDe.TabIndex = 13;
            this.tieuDe.Text = "CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // Hunggpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 582);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.Nhapc);
            this.Controls.Add(this.Nhapb);
            this.Controls.Add(this.Nhapa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tieuDe);
            this.Name = "Hunggpt";
            this.Text = "Hunggpt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Label Ketqua;
        private System.Windows.Forms.Label Nhapc;
        private System.Windows.Forms.Label Nhapb;
        private System.Windows.Forms.Label Nhapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tieuDe;
    }
}