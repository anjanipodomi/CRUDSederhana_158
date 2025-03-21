namespace CRUDSederhana
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
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.NIM = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.TELEPON = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTELEPON = new System.Windows.Forms.TextBox();
            this.txtALAMAT = new System.Windows.Forms.TextBox();
            this.btnUBAH = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Location = new System.Drawing.Point(786, 56);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(92, 32);
            this.btnTAMBAH.TabIndex = 0;
            this.btnTAMBAH.Text = "TAMBAH";
            this.btnTAMBAH.UseVisualStyleBackColor = true;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(36, 56);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 1;
            this.NIM.Text = "NIM";
            this.NIM.Click += new System.EventHandler(this.label1_Click);
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(36, 106);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(55, 20);
            this.NAMA.TabIndex = 2;
            this.NAMA.Text = "NAMA";
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(36, 156);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(58, 20);
            this.EMAIL.TabIndex = 3;
            this.EMAIL.Text = "EMAIL";
            this.EMAIL.Click += new System.EventHandler(this.label3_Click);
            // 
            // TELEPON
            // 
            this.TELEPON.AutoSize = true;
            this.TELEPON.Location = new System.Drawing.Point(36, 210);
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.Size = new System.Drawing.Size(82, 20);
            this.TELEPON.TabIndex = 4;
            this.TELEPON.Text = "TELEPON";
            // 
            // ALAMAT
            // 
            this.ALAMAT.AutoSize = true;
            this.ALAMAT.Location = new System.Drawing.Point(36, 258);
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(73, 20);
            this.ALAMAT.TabIndex = 5;
            this.ALAMAT.Text = "ALAMAT";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(145, 56);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(591, 26);
            this.txtNIM.TabIndex = 6;
            // 
            // txtNAMA
            // 
            this.txtNAMA.Location = new System.Drawing.Point(145, 106);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(591, 26);
            this.txtNAMA.TabIndex = 7;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(145, 153);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(591, 26);
            this.txtEMAIL.TabIndex = 8;
            // 
            // txtTELEPON
            // 
            this.txtTELEPON.Location = new System.Drawing.Point(145, 207);
            this.txtTELEPON.Name = "txtTELEPON";
            this.txtTELEPON.Size = new System.Drawing.Size(591, 26);
            this.txtTELEPON.TabIndex = 9;
            // 
            // txtALAMAT
            // 
            this.txtALAMAT.Location = new System.Drawing.Point(145, 255);
            this.txtALAMAT.Name = "txtALAMAT";
            this.txtALAMAT.Size = new System.Drawing.Size(591, 26);
            this.txtALAMAT.TabIndex = 10;
            // 
            // btnUBAH
            // 
            this.btnUBAH.Location = new System.Drawing.Point(786, 169);
            this.btnUBAH.Name = "btnUBAH";
            this.btnUBAH.Size = new System.Drawing.Size(86, 26);
            this.btnUBAH.TabIndex = 11;
            this.btnUBAH.Text = "UBAH";
            this.btnUBAH.UseVisualStyleBackColor = true;
            this.btnUBAH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Location = new System.Drawing.Point(786, 115);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(86, 26);
            this.btnHAPUS.TabIndex = 12;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(786, 228);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(97, 29);
            this.btnREFRESH.TabIndex = 13;
            this.btnREFRESH.Text = "REFRESH";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(120, 374);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(731, 209);
            this.dgvMahasiswa.TabIndex = 14;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 618);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.btnUBAH);
            this.Controls.Add(this.txtALAMAT);
            this.Controls.Add(this.txtTELEPON);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtNAMA);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.TELEPON);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.btnTAMBAH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label TELEPON;
        private System.Windows.Forms.Label ALAMAT;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTELEPON;
        private System.Windows.Forms.TextBox txtALAMAT;
        private System.Windows.Forms.Button btnUBAH;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnREFRESH;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

