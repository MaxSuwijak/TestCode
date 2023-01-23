namespace systemBank
{
    partial class createCustomer
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
            this.lAcc = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.btnGenAcc = new System.Windows.Forms.Button();
            this.brnResetAcc = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.lMidName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.lErrAcc = new System.Windows.Forms.Label();
            this.lErrName = new System.Windows.Forms.Label();
            this.lErrLastName = new System.Windows.Forms.Label();
            this.lCoun = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lErrCountry = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.Label();
            this.lErrTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cbtel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lErrBalance = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lAcc
            // 
            this.lAcc.AutoSize = true;
            this.lAcc.Location = new System.Drawing.Point(60, 15);
            this.lAcc.Name = "lAcc";
            this.lAcc.Size = new System.Drawing.Size(90, 24);
            this.lAcc.TabIndex = 0;
            this.lAcc.Text = "Account :";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(156, 12);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(380, 29);
            this.txtAcc.TabIndex = 1;
            this.txtAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_KeyDown);
            this.txtAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcc_KeyPress);
            // 
            // btnGenAcc
            // 
            this.btnGenAcc.Location = new System.Drawing.Point(156, 47);
            this.btnGenAcc.Name = "btnGenAcc";
            this.btnGenAcc.Size = new System.Drawing.Size(187, 40);
            this.btnGenAcc.TabIndex = 4;
            this.btnGenAcc.Text = "Generate Account";
            this.btnGenAcc.UseVisualStyleBackColor = true;
            this.btnGenAcc.Click += new System.EventHandler(this.btnGenAcc_Click);
            // 
            // brnResetAcc
            // 
            this.brnResetAcc.Location = new System.Drawing.Point(349, 47);
            this.brnResetAcc.Name = "brnResetAcc";
            this.brnResetAcc.Size = new System.Drawing.Size(187, 40);
            this.brnResetAcc.TabIndex = 5;
            this.brnResetAcc.Text = "Reset";
            this.brnResetAcc.UseVisualStyleBackColor = true;
            this.brnResetAcc.Click += new System.EventHandler(this.brnResetAcc_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(79, 107);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(71, 24);
            this.lName.TabIndex = 6;
            this.lName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 29);
            this.txtName.TabIndex = 7;
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(156, 137);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(380, 29);
            this.txtMidName.TabIndex = 9;
            // 
            // lMidName
            // 
            this.lMidName.AutoSize = true;
            this.lMidName.Location = new System.Drawing.Point(17, 140);
            this.lMidName.Name = "lMidName";
            this.lMidName.Size = new System.Drawing.Size(133, 24);
            this.lMidName.TabIndex = 8;
            this.lMidName.Text = "Middle Name :";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(156, 172);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(380, 29);
            this.txtLastname.TabIndex = 11;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(41, 175);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(109, 24);
            this.lLastName.TabIndex = 10;
            this.lLastName.Text = "Last Name :";
            // 
            // lErrAcc
            // 
            this.lErrAcc.AutoSize = true;
            this.lErrAcc.ForeColor = System.Drawing.Color.Red;
            this.lErrAcc.Location = new System.Drawing.Point(542, 15);
            this.lErrAcc.Name = "lErrAcc";
            this.lErrAcc.Size = new System.Drawing.Size(17, 24);
            this.lErrAcc.TabIndex = 12;
            this.lErrAcc.Text = "*";
            this.lErrAcc.Visible = false;
            // 
            // lErrName
            // 
            this.lErrName.AutoSize = true;
            this.lErrName.ForeColor = System.Drawing.Color.Red;
            this.lErrName.Location = new System.Drawing.Point(542, 107);
            this.lErrName.Name = "lErrName";
            this.lErrName.Size = new System.Drawing.Size(17, 24);
            this.lErrName.TabIndex = 13;
            this.lErrName.Text = "*";
            this.lErrName.Visible = false;
            // 
            // lErrLastName
            // 
            this.lErrLastName.AutoSize = true;
            this.lErrLastName.ForeColor = System.Drawing.Color.Red;
            this.lErrLastName.Location = new System.Drawing.Point(542, 175);
            this.lErrLastName.Name = "lErrLastName";
            this.lErrLastName.Size = new System.Drawing.Size(17, 24);
            this.lErrLastName.TabIndex = 14;
            this.lErrLastName.Text = "*";
            this.lErrLastName.Visible = false;
            // 
            // lCoun
            // 
            this.lCoun.AutoSize = true;
            this.lCoun.Location = new System.Drawing.Point(60, 214);
            this.lCoun.Name = "lCoun";
            this.lCoun.Size = new System.Drawing.Size(90, 24);
            this.lCoun.TabIndex = 15;
            this.lCoun.Text = "Country  :";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(156, 211);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(380, 32);
            this.cbCountry.TabIndex = 16;
            this.cbCountry.SelectionChangeCommitted += new System.EventHandler(this.cbCountry_SelectionChangeCommitted);
            // 
            // lErrCountry
            // 
            this.lErrCountry.AutoSize = true;
            this.lErrCountry.ForeColor = System.Drawing.Color.Red;
            this.lErrCountry.Location = new System.Drawing.Point(542, 214);
            this.lErrCountry.Name = "lErrCountry";
            this.lErrCountry.Size = new System.Drawing.Size(17, 24);
            this.lErrCountry.TabIndex = 17;
            this.lErrCountry.Text = "*";
            this.lErrCountry.Visible = false;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(98, 252);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(52, 24);
            this.cb.TabIndex = 18;
            this.cb.Text = "Tel  :";
            // 
            // lErrTel
            // 
            this.lErrTel.AutoSize = true;
            this.lErrTel.ForeColor = System.Drawing.Color.Red;
            this.lErrTel.Location = new System.Drawing.Point(542, 255);
            this.lErrTel.Name = "lErrTel";
            this.lErrTel.Size = new System.Drawing.Size(17, 24);
            this.lErrTel.TabIndex = 20;
            this.lErrTel.Text = "*";
            this.lErrTel.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(275, 252);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(261, 29);
            this.txtTel.TabIndex = 21;
            // 
            // cbtel
            // 
            this.cbtel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtel.FormattingEnabled = true;
            this.cbtel.Location = new System.Drawing.Point(154, 249);
            this.cbtel.Name = "cbtel";
            this.cbtel.Size = new System.Drawing.Size(115, 32);
            this.cbtel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Balance  :";
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(154, 287);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(382, 29);
            this.txtbalance.TabIndex = 25;
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbalance_KeyPress);
            // 
            // lErrBalance
            // 
            this.lErrBalance.AutoSize = true;
            this.lErrBalance.ForeColor = System.Drawing.Color.Red;
            this.lErrBalance.Location = new System.Drawing.Point(542, 290);
            this.lErrBalance.Name = "lErrBalance";
            this.lErrBalance.Size = new System.Drawing.Size(17, 24);
            this.lErrBalance.TabIndex = 26;
            this.lErrBalance.Text = "*";
            this.lErrBalance.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 40);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 40);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // createCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lErrBalance);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lErrTel);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lErrCountry);
            this.Controls.Add(this.lCoun);
            this.Controls.Add(this.lErrLastName);
            this.Controls.Add(this.lErrName);
            this.Controls.Add(this.lErrAcc);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.txtMidName);
            this.Controls.Add(this.lMidName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.brnResetAcc);
            this.Controls.Add(this.btnGenAcc);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.lAcc);
            this.Controls.Add(this.cbCountry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "createCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "create account for Customers";
            this.Load += new System.EventHandler(this.createCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAcc;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Button btnGenAcc;
        private System.Windows.Forms.Button brnResetAcc;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.Label lMidName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lErrAcc;
        private System.Windows.Forms.Label lErrName;
        private System.Windows.Forms.Label lErrLastName;
        private System.Windows.Forms.Label lCoun;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lErrCountry;
        private System.Windows.Forms.Label cb;
        private System.Windows.Forms.Label lErrTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cbtel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lErrBalance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}