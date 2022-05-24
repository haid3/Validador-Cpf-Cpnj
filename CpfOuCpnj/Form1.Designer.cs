namespace CpfOuCpnj
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedtxt = new System.Windows.Forms.MaskedTextBox();
            this.btn_valida_cpf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.radiobtn_cnpj = new System.Windows.Forms.RadioButton();
            this.radiobtn_cpf = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedtxt
            // 
            this.maskedtxt.Location = new System.Drawing.Point(154, 200);
            this.maskedtxt.Name = "maskedtxt";
            this.maskedtxt.Size = new System.Drawing.Size(125, 20);
            this.maskedtxt.TabIndex = 6;
            this.maskedtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxt_cpf_MaskInputRejected);
            this.maskedtxt.Leave += new System.EventHandler(this.maskedtxt_Leave);
            // 
            // btn_valida_cpf
            // 
            this.btn_valida_cpf.Location = new System.Drawing.Point(322, 194);
            this.btn_valida_cpf.Name = "btn_valida_cpf";
            this.btn_valida_cpf.Size = new System.Drawing.Size(89, 30);
            this.btn_valida_cpf.TabIndex = 8;
            this.btn_valida_cpf.Text = "Validar";
            this.btn_valida_cpf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mensagem);
            this.groupBox1.Controls.Add(this.radiobtn_cnpj);
            this.groupBox1.Controls.Add(this.radiobtn_cpf);
            this.groupBox1.Location = new System.Drawing.Point(134, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.Location = new System.Drawing.Point(78, 21);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(135, 25);
            this.lbl_mensagem.TabIndex = 2;
            this.lbl_mensagem.Text = "Quero validar:";
            // 
            // radiobtn_cnpj
            // 
            this.radiobtn_cnpj.AutoSize = true;
            this.radiobtn_cnpj.Location = new System.Drawing.Point(188, 68);
            this.radiobtn_cnpj.Name = "radiobtn_cnpj";
            this.radiobtn_cnpj.Size = new System.Drawing.Size(52, 17);
            this.radiobtn_cnpj.TabIndex = 1;
            this.radiobtn_cnpj.TabStop = true;
            this.radiobtn_cnpj.Text = "CNPJ";
            this.radiobtn_cnpj.UseVisualStyleBackColor = true;
            this.radiobtn_cnpj.CheckedChanged += new System.EventHandler(this.radiobtn_cnpj_CheckedChanged);
            // 
            // radiobtn_cpf
            // 
            this.radiobtn_cpf.AutoSize = true;
            this.radiobtn_cpf.Location = new System.Drawing.Point(58, 68);
            this.radiobtn_cpf.Name = "radiobtn_cpf";
            this.radiobtn_cpf.Size = new System.Drawing.Size(45, 17);
            this.radiobtn_cpf.TabIndex = 0;
            this.radiobtn_cpf.TabStop = true;
            this.radiobtn_cpf.Text = "CPF";
            this.radiobtn_cpf.UseVisualStyleBackColor = true;
            this.radiobtn_cpf.CheckedChanged += new System.EventHandler(this.radiobtn_cpf_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_valida_cpf);
            this.Controls.Add(this.maskedtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedtxt;
        private System.Windows.Forms.Button btn_valida_cpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.RadioButton radiobtn_cnpj;
        private System.Windows.Forms.RadioButton radiobtn_cpf;
    }
}

