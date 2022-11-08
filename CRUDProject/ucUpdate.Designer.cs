namespace CRUDProject
{
    partial class ucUpdate
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInvNumber = new System.Windows.Forms.Label();
            this.lbInvEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbInvName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbInvID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInvNumber
            // 
            this.lbInvNumber.AutoSize = true;
            this.lbInvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvNumber.ForeColor = System.Drawing.Color.Red;
            this.lbInvNumber.Location = new System.Drawing.Point(254, 166);
            this.lbInvNumber.Name = "lbInvNumber";
            this.lbInvNumber.Size = new System.Drawing.Size(42, 20);
            this.lbInvNumber.TabIndex = 55;
            this.lbInvNumber.Text = "error";
            this.lbInvNumber.Visible = false;
            // 
            // lbInvEmail
            // 
            this.lbInvEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvEmail.AutoSize = true;
            this.lbInvEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvEmail.Location = new System.Drawing.Point(477, 249);
            this.lbInvEmail.Name = "lbInvEmail";
            this.lbInvEmail.Size = new System.Drawing.Size(42, 20);
            this.lbInvEmail.TabIndex = 54;
            this.lbInvEmail.Text = "error";
            this.lbInvEmail.Visible = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(118, 246);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(353, 26);
            this.tbEmail.TabIndex = 51;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lbInvName
            // 
            this.lbInvName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvName.AutoSize = true;
            this.lbInvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvName.ForeColor = System.Drawing.Color.Red;
            this.lbInvName.Location = new System.Drawing.Point(477, 82);
            this.lbInvName.Name = "lbInvName";
            this.lbInvName.Size = new System.Drawing.Size(42, 20);
            this.lbInvName.TabIndex = 56;
            this.lbInvName.Text = "error";
            this.lbInvName.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(118, 79);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(353, 26);
            this.tbName.TabIndex = 48;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUpdate.Enabled = false;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(51, 319);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(153, 45);
            this.btUpdate.TabIndex = 57;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email";
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(318, 319);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(153, 45);
            this.btBack.TabIndex = 58;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Number";
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(49, 8);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 59;
            this.lbID.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Name";
            // 
            // mtbID
            // 
            this.mtbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbID.Location = new System.Drawing.Point(122, 5);
            this.mtbID.Mask = "00000";
            this.mtbID.Name = "mtbID";
            this.mtbID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbID.Size = new System.Drawing.Size(59, 26);
            this.mtbID.TabIndex = 60;
            this.mtbID.TextChanged += new System.EventHandler(this.mtbID_TextChanged);
            // 
            // mtbNumber
            // 
            this.mtbNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbNumber.Enabled = false;
            this.mtbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumber.Location = new System.Drawing.Point(120, 163);
            this.mtbNumber.Mask = "(00) 00000-0000";
            this.mtbNumber.Name = "mtbNumber";
            this.mtbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbNumber.Size = new System.Drawing.Size(128, 26);
            this.mtbNumber.TabIndex = 49;
            this.mtbNumber.TextChanged += new System.EventHandler(this.mtbNumber_TextChanged);
            // 
            // lbInvID
            // 
            this.lbInvID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvID.AutoSize = true;
            this.lbInvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvID.ForeColor = System.Drawing.Color.Red;
            this.lbInvID.Location = new System.Drawing.Point(187, 8);
            this.lbInvID.Name = "lbInvID";
            this.lbInvID.Size = new System.Drawing.Size(42, 20);
            this.lbInvID.TabIndex = 61;
            this.lbInvID.Text = "error";
            this.lbInvID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lbInvID);
            this.panel1.Controls.Add(this.mtbNumber);
            this.panel1.Controls.Add(this.mtbID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lbInvName);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lbInvEmail);
            this.panel1.Controls.Add(this.lbInvNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 456);
            this.panel1.TabIndex = 62;
            // 
            // ucUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "ucUpdate";
            this.Size = new System.Drawing.Size(583, 456);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInvNumber;
        private System.Windows.Forms.Label lbInvEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbInvName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.MaskedTextBox mtbNumber;
        private System.Windows.Forms.Label lbInvID;
        private System.Windows.Forms.Panel panel1;
    }
}
