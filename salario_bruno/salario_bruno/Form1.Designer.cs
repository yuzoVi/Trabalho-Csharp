namespace salario_bruno
{
    partial class frmSalario
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
            this.mskNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.MskSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskIRRF = new System.Windows.Forms.MaskedTextBox();
            this.mskSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskDINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskDIRRF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIDINSS = new System.Windows.Forms.Label();
            this.lblDIRRF = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.gbxSituacao = new System.Windows.Forms.GroupBox();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.gbxSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskNomeFunc
            // 
            this.mskNomeFunc.Location = new System.Drawing.Point(122, 53);
            this.mskNomeFunc.Name = "mskNomeFunc";
            this.mskNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.mskNomeFunc.TabIndex = 0;
            // 
            // MskSalBruto
            // 
            this.MskSalBruto.Location = new System.Drawing.Point(122, 88);
            this.MskSalBruto.Mask = "99999.99";
            this.MskSalBruto.Name = "MskSalBruto";
            this.MskSalBruto.Size = new System.Drawing.Size(100, 20);
            this.MskSalBruto.TabIndex = 1;
            this.MskSalBruto.Text = "0000000";
            // 
            // mskNumFilhos
            // 
            this.mskNumFilhos.Location = new System.Drawing.Point(122, 132);
            this.mskNumFilhos.Mask = "99";
            this.mskNumFilhos.Name = "mskNumFilhos";
            this.mskNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskNumFilhos.TabIndex = 2;
            this.mskNumFilhos.Text = "00";
            // 
            // mskINSS
            // 
            this.mskINSS.Enabled = false;
            this.mskINSS.Location = new System.Drawing.Point(122, 302);
            this.mskINSS.Name = "mskINSS";
            this.mskINSS.Size = new System.Drawing.Size(100, 20);
            this.mskINSS.TabIndex = 3;
            // 
            // mskIRRF
            // 
            this.mskIRRF.Enabled = false;
            this.mskIRRF.Location = new System.Drawing.Point(122, 353);
            this.mskIRRF.Name = "mskIRRF";
            this.mskIRRF.Size = new System.Drawing.Size(100, 20);
            this.mskIRRF.TabIndex = 4;
            // 
            // mskSalLiquido
            // 
            this.mskSalLiquido.Enabled = false;
            this.mskSalLiquido.Location = new System.Drawing.Point(122, 400);
            this.mskSalLiquido.Name = "mskSalLiquido";
            this.mskSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.mskSalLiquido.TabIndex = 5;
            // 
            // mskDINSS
            // 
            this.mskDINSS.Enabled = false;
            this.mskDINSS.Location = new System.Drawing.Point(359, 302);
            this.mskDINSS.Name = "mskDINSS";
            this.mskDINSS.Size = new System.Drawing.Size(100, 20);
            this.mskDINSS.TabIndex = 6;
            // 
            // mskDIRRF
            // 
            this.mskDIRRF.Enabled = false;
            this.mskDIRRF.Location = new System.Drawing.Point(359, 353);
            this.mskDIRRF.Name = "mskDIRRF";
            this.mskDIRRF.Size = new System.Drawing.Size(100, 20);
            this.mskDIRRF.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome Funcionário: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(17, 132);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(77, 13);
            this.lblFilhos.TabIndex = 10;
            this.lblFilhos.Text = "Número Filhos:";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(38, 305);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(78, 13);
            this.lblINSS.TabIndex = 11;
            this.lblINSS.Text = "Alíquota INSS:";
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Location = new System.Drawing.Point(38, 356);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(78, 13);
            this.lblIRRF.TabIndex = 12;
            this.lblIRRF.Text = "Alíquota IRRF:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(32, 400);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(84, 13);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salário Líquido: ";
            // 
            // lblIDINSS
            // 
            this.lblIDINSS.AutoSize = true;
            this.lblIDINSS.Location = new System.Drawing.Point(269, 305);
            this.lblIDINSS.Name = "lblIDINSS";
            this.lblIDINSS.Size = new System.Drawing.Size(84, 13);
            this.lblIDINSS.TabIndex = 14;
            this.lblIDINSS.Text = "Desconto INSS:";
            // 
            // lblDIRRF
            // 
            this.lblDIRRF.AutoSize = true;
            this.lblDIRRF.Location = new System.Drawing.Point(269, 356);
            this.lblDIRRF.Name = "lblDIRRF";
            this.lblDIRRF.Size = new System.Drawing.Size(84, 13);
            this.lblDIRRF.TabIndex = 15;
            this.lblDIRRF.Text = "Desconto IRRF:";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(259, 53);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(113, 76);
            this.gbxSexo.TabIndex = 16;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // gbxSituacao
            // 
            this.gbxSituacao.Controls.Add(this.ckbxCasado);
            this.gbxSituacao.Location = new System.Drawing.Point(259, 135);
            this.gbxSituacao.Name = "gbxSituacao";
            this.gbxSituacao.Size = new System.Drawing.Size(91, 51);
            this.gbxSituacao.TabIndex = 17;
            this.gbxSituacao.TabStop = false;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(7, 20);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 20);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 40);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(122, 175);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(100, 40);
            this.btnVerifica.TabIndex = 18;
            this.btnVerifica.Text = "Verificar Descontos";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(38, 230);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 19;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(32, 230);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(10, 13);
            this.lblDados.TabIndex = 20;
            this.lblDados.Text = "-";
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.gbxSituacao);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblDIRRF);
            this.Controls.Add(this.lblIDINSS);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mskDIRRF);
            this.Controls.Add(this.mskDINSS);
            this.Controls.Add(this.mskSalLiquido);
            this.Controls.Add(this.mskIRRF);
            this.Controls.Add(this.mskINSS);
            this.Controls.Add(this.mskNumFilhos);
            this.Controls.Add(this.MskSalBruto);
            this.Controls.Add(this.mskNomeFunc);
            this.Name = "frmSalario";
            this.Text = "Cálculo do Salário do funcionário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxSituacao.ResumeLayout(false);
            this.gbxSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNomeFunc;
        private System.Windows.Forms.MaskedTextBox MskSalBruto;
        private System.Windows.Forms.MaskedTextBox mskNumFilhos;
        private System.Windows.Forms.MaskedTextBox mskINSS;
        private System.Windows.Forms.MaskedTextBox mskIRRF;
        private System.Windows.Forms.MaskedTextBox mskSalLiquido;
        private System.Windows.Forms.MaskedTextBox mskDINSS;
        private System.Windows.Forms.MaskedTextBox mskDIRRF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRRF;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIDINSS;
        private System.Windows.Forms.Label lblDIRRF;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox gbxSituacao;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDados;
    }
}

