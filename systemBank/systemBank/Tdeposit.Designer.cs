namespace systemBank
{
    partial class Tdeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tdeposit));
            this.lAcc = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMidName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.brnReset = new System.Windows.Forms.Button();
            this.txtAcc = new systemBank.AutoCompleteTextbox();
            this.SuspendLayout();
            // 
            // lAcc
            // 
            this.lAcc.AutoSize = true;
            this.lAcc.Location = new System.Drawing.Point(59, 15);
            this.lAcc.Name = "lAcc";
            this.lAcc.Size = new System.Drawing.Size(90, 24);
            this.lAcc.TabIndex = 0;
            this.lAcc.Text = "Account :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(505, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(153, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 24);
            this.lName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "MiddleName :";
            // 
            // lMidName
            // 
            this.lMidName.AutoSize = true;
            this.lMidName.Location = new System.Drawing.Point(153, 113);
            this.lMidName.Name = "lMidName";
            this.lMidName.Size = new System.Drawing.Size(0, 24);
            this.lMidName.TabIndex = 6;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(153, 155);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(0, 24);
            this.lLastName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name :";
            // 
            // lBalance
            // 
            this.lBalance.AutoSize = true;
            this.lBalance.Location = new System.Drawing.Point(151, 203);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(0, 24);
            this.lBalance.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deposit :";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Enabled = false;
            this.txtDeposit.Location = new System.Drawing.Point(148, 247);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(342, 29);
            this.txtDeposit.TabIndex = 26;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 40);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(27, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 40);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // brnReset
            // 
            this.brnReset.Location = new System.Drawing.Point(220, 291);
            this.brnReset.Name = "brnReset";
            this.brnReset.Size = new System.Drawing.Size(200, 40);
            this.brnReset.TabIndex = 31;
            this.brnReset.Text = "Reset";
            this.brnReset.UseVisualStyleBackColor = true;
            this.brnReset.Click += new System.EventHandler(this.brnReset_Click);
            // 
            // txtAcc
            // 
            this.txtAcc.AutoCompleteList = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAcc.AutoCompleteList")));
            this.txtAcc.CaseSensitive = false;
            this.txtAcc.Location = new System.Drawing.Point(155, 12);
            this.txtAcc.MinTypedCharacters = 2;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.SelectedIndex = -1;
            this.txtAcc.Size = new System.Drawing.Size(335, 29);
            this.txtAcc.TabIndex = 1;
            // 
            // Tdeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 343);
            this.Controls.Add(this.brnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lMidName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.lAcc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Tdeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tdeposit";
            this.Load += new System.EventHandler(this.Tdeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAcc;
        private AutoCompleteTextbox txtAcc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lMidName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button brnReset;
    }
}