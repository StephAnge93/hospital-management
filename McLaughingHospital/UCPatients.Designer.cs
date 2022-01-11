namespace McLaughingHospital
{
    partial class UCPatients
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPatients));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurn = new System.Windows.Forms.TextBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatNo = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.picb = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPat = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.sfdExpPat = new System.Windows.Forms.SaveFileDialog();
            this.epAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPatNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(41, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(28, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(287, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(255, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(94)))), ((int)(((byte)(167)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(480, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmail.Location = new System.Drawing.Point(85, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 24);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // cboCounty
            // 
            this.cboCounty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCounty.Font = new System.Drawing.Font("Calibri", 11F);
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(360, 106);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(202, 26);
            this.cboCounty.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAddress.Location = new System.Drawing.Point(85, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 24);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAge.Location = new System.Drawing.Point(319, 49);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(70, 24);
            this.txtAge.TabIndex = 2;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            this.txtAge.Validated += new System.EventHandler(this.txtAge_Validated);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(85, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 24);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // txtSurn
            // 
            this.txtSurn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurn.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSurn.Location = new System.Drawing.Point(316, 79);
            this.txtSurn.Name = "txtSurn";
            this.txtSurn.Size = new System.Drawing.Size(246, 24);
            this.txtSurn.TabIndex = 4;
            this.txtSurn.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurn_Validating);
            this.txtSurn.Validated += new System.EventHandler(this.txtSurn_Validated);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.label9);
            this.grp.Controls.Add(this.label8);
            this.grp.Controls.Add(this.label7);
            this.grp.Controls.Add(this.label6);
            this.grp.Controls.Add(this.label5);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.btnSave);
            this.grp.Controls.Add(this.txtEmail);
            this.grp.Controls.Add(this.cboCounty);
            this.grp.Controls.Add(this.txtAddress);
            this.grp.Controls.Add(this.txtAge);
            this.grp.Controls.Add(this.txtPatNo);
            this.grp.Controls.Add(this.txtPhone);
            this.grp.Controls.Add(this.txtFirstName);
            this.grp.Controls.Add(this.txtSurn);
            this.grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(94)))), ((int)(((byte)(167)))));
            this.grp.Location = new System.Drawing.Point(11, 65);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(586, 219);
            this.grp.TabIndex = 29;
            this.grp.TabStop = false;
            this.grp.Text = "Add a New Patient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label9.Location = new System.Drawing.Point(347, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(313, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "County";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Patient Number";
            // 
            // txtPatNo
            // 
            this.txtPatNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatNo.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPatNo.Location = new System.Drawing.Point(110, 49);
            this.txtPatNo.Name = "txtPatNo";
            this.txtPatNo.Size = new System.Drawing.Size(158, 24);
            this.txtPatNo.TabIndex = 1;
            this.txtPatNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatNo_Validating);
            this.txtPatNo.Validated += new System.EventHandler(this.txtPatNo_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPhone.Location = new System.Drawing.Point(394, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 24);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // picb
            // 
            this.picb.Image = ((System.Drawing.Image)(resources.GetObject("picb.Image")));
            this.picb.Location = new System.Drawing.Point(170, 4);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(62, 51);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb.TabIndex = 12;
            this.picb.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(237, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Patient Management";
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(94)))), ((int)(((byte)(167)))));
            this.pnltop.Controls.Add(this.picb);
            this.pnltop.Controls.Add(this.lblTitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(610, 59);
            this.pnltop.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(94)))), ((int)(((byte)(167)))));
            this.label13.Location = new System.Drawing.Point(21, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "View Patients";
            // 
            // dgvPat
            // 
            this.dgvPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dgvPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPat.Location = new System.Drawing.Point(13, 316);
            this.dgvPat.Name = "dgvPat";
            this.dgvPat.Size = new System.Drawing.Size(584, 220);
            this.dgvPat.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(392, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.btnExp);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(13, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 50);
            this.panel1.TabIndex = 36;
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(173)))), ((int)(((byte)(65)))));
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExp.Location = new System.Drawing.Point(480, 5);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(82, 29);
            this.btnExp.TabIndex = 12;
            this.btnExp.Text = "Export List";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(149)))), ((int)(((byte)(207)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(304, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 29);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // epAge
            // 
            this.epAge.ContainerControl = this;
            // 
            // epPatNo
            // 
            this.epPatNo.ContainerControl = this;
            // 
            // epFn
            // 
            this.epFn.ContainerControl = this;
            // 
            // epSn
            // 
            this.epSn.ContainerControl = this;
            // 
            // epAddress
            // 
            this.epAddress.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // UCPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.dgvPat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltop);
            this.Name = "UCPatients";
            this.Size = new System.Drawing.Size(610, 602);
            this.Load += new System.EventHandler(this.UCPatients_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPat)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurn;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox picb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.SaveFileDialog sfdExpPat;
        private System.Windows.Forms.ErrorProvider epAge;
        private System.Windows.Forms.ErrorProvider epPatNo;
        private System.Windows.Forms.ErrorProvider epFn;
        private System.Windows.Forms.ErrorProvider epSn;
        private System.Windows.Forms.ErrorProvider epAddress;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epPhone;
    }
}
