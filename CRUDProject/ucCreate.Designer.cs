namespace CRUDProject
{
    partial class ucCreate
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
            this.btBack = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbInvName = new System.Windows.Forms.Label();
            this.mtbNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbInvNumber = new System.Windows.Forms.Label();
            this.lbInvEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(318, 250);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(153, 45);
            this.btBack.TabIndex = 45;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btCreate
            // 
            this.btCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(53, 250);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(153, 45);
            this.btCreate.TabIndex = 44;
            this.btCreate.Text = "CREATE";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbInvName
            // 
            this.lbInvName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvName.AutoSize = true;
            this.lbInvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvName.ForeColor = System.Drawing.Color.Red;
            this.lbInvName.Location = new System.Drawing.Point(477, 13);
            this.lbInvName.Name = "lbInvName";
            this.lbInvName.Size = new System.Drawing.Size(42, 20);
            this.lbInvName.TabIndex = 43;
            this.lbInvName.Text = "error";
            this.lbInvName.Visible = false;
            // 
            // mtbNumber
            // 
            this.mtbNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumber.Location = new System.Drawing.Point(120, 94);
            this.mtbNumber.Mask = "(00) 00000-0000";
            this.mtbNumber.Name = "mtbNumber";
            this.mtbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbNumber.Size = new System.Drawing.Size(128, 26);
            this.mtbNumber.TabIndex = 36;
            this.mtbNumber.TextChanged += new System.EventHandler(this.mtbNumber_TextChanged);
            // 
            // lbInvNumber
            // 
            this.lbInvNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvNumber.AutoSize = true;
            this.lbInvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvNumber.ForeColor = System.Drawing.Color.Red;
            this.lbInvNumber.Location = new System.Drawing.Point(254, 100);
            this.lbInvNumber.Name = "lbInvNumber";
            this.lbInvNumber.Size = new System.Drawing.Size(42, 20);
            this.lbInvNumber.TabIndex = 42;
            this.lbInvNumber.Text = "error";
            this.lbInvNumber.Visible = false;
            // 
            // lbInvEmail
            // 
            this.lbInvEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInvEmail.AutoSize = true;
            this.lbInvEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvEmail.ForeColor = System.Drawing.Color.Red;
            this.lbInvEmail.Location = new System.Drawing.Point(477, 180);
            this.lbInvEmail.Name = "lbInvEmail";
            this.lbInvEmail.Size = new System.Drawing.Size(42, 20);
            this.lbInvEmail.TabIndex = 41;
            this.lbInvEmail.Text = "error";
            this.lbInvEmail.Visible = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(118, 177);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(353, 26);
            this.tbEmail.TabIndex = 38;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(118, 10);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(353, 26);
            this.tbName.TabIndex = 35;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 365);
            this.panel1.TabIndex = 46;
            // 
            // ucCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.lbInvName);
            this.Controls.Add(this.mtbNumber);
            this.Controls.Add(this.lbInvNumber);
            this.Controls.Add(this.lbInvEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ucCreate";
            this.Size = new System.Drawing.Size(582, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lbInvName;
        private System.Windows.Forms.MaskedTextBox mtbNumber;
        private System.Windows.Forms.Label lbInvNumber;
        private System.Windows.Forms.Label lbInvEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
