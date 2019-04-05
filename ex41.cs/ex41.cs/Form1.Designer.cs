namespace ex41.cs
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cbxIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.rbtSolteiro = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbntDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtnViuvo = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnOutros = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.ckBxMasculino = new System.Windows.Forms.CheckBox();
            this.ckbxFeminino = new System.Windows.Forms.CheckBox();
            this.cbxDistancia = new System.Windows.Forms.ComboBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbxTempo = new System.Windows.Forms.ComboBox();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(169, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(169, 84);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(114, 91);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // cbxIdade
            // 
            this.cbxIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdade.FormattingEnabled = true;
            this.cbxIdade.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.cbxIdade.Location = new System.Drawing.Point(169, 120);
            this.cbxIdade.Name = "cbxIdade";
            this.cbxIdade.Size = new System.Drawing.Size(100, 21);
            this.cbxIdade.Sorted = true;
            this.cbxIdade.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(117, 127);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade: ";
            // 
            // rbtSolteiro
            // 
            this.rbtSolteiro.AutoSize = true;
            this.rbtSolteiro.Checked = true;
            this.rbtSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbtSolteiro.Name = "rbtSolteiro";
            this.rbtSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rbtSolteiro.TabIndex = 6;
            this.rbtSolteiro.TabStop = true;
            this.rbtSolteiro.Text = "Solteiro";
            this.rbtSolteiro.UseVisualStyleBackColor = true;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnOutros);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnViuvo);
            this.gbxEstadoCivil.Controls.Add(this.rbntDivorciado);
            this.gbxEstadoCivil.Controls.Add(this.rbtSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(311, 47);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(200, 139);
            this.gbxEstadoCivil.TabIndex = 7;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbntDivorciado
            // 
            this.rbntDivorciado.AutoSize = true;
            this.rbntDivorciado.Location = new System.Drawing.Point(6, 90);
            this.rbntDivorciado.Name = "rbntDivorciado";
            this.rbntDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rbntDivorciado.TabIndex = 7;
            this.rbntDivorciado.Text = "Divorciado";
            this.rbntDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtnViuvo
            // 
            this.rbtnViuvo.AutoSize = true;
            this.rbtnViuvo.Location = new System.Drawing.Point(6, 67);
            this.rbtnViuvo.Name = "rbtnViuvo";
            this.rbtnViuvo.Size = new System.Drawing.Size(52, 17);
            this.rbtnViuvo.TabIndex = 8;
            this.rbtnViuvo.Text = "Viuvo";
            this.rbtnViuvo.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(5, 44);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtnCasado.TabIndex = 9;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnOutros
            // 
            this.rbtnOutros.AutoSize = true;
            this.rbtnOutros.Location = new System.Drawing.Point(6, 113);
            this.rbtnOutros.Name = "rbtnOutros";
            this.rbtnOutros.Size = new System.Drawing.Size(56, 17);
            this.rbtnOutros.TabIndex = 10;
            this.rbtnOutros.Text = "Outros";
            this.rbtnOutros.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.ckbxFeminino);
            this.gbxSexo.Controls.Add(this.ckBxMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(311, 229);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 8;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // ckBxMasculino
            // 
            this.ckBxMasculino.AutoSize = true;
            this.ckBxMasculino.Checked = true;
            this.ckBxMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBxMasculino.Location = new System.Drawing.Point(7, 20);
            this.ckBxMasculino.Name = "ckBxMasculino";
            this.ckBxMasculino.Size = new System.Drawing.Size(74, 17);
            this.ckBxMasculino.TabIndex = 0;
            this.ckBxMasculino.Text = "Masculino";
            this.ckBxMasculino.UseVisualStyleBackColor = true;
            this.ckBxMasculino.CheckedChanged += new System.EventHandler(this.ckBxMasculino_CheckedChanged);
            // 
            // ckbxFeminino
            // 
            this.ckbxFeminino.AutoSize = true;
            this.ckbxFeminino.Location = new System.Drawing.Point(7, 43);
            this.ckbxFeminino.Name = "ckbxFeminino";
            this.ckbxFeminino.Size = new System.Drawing.Size(68, 17);
            this.ckbxFeminino.TabIndex = 1;
            this.ckbxFeminino.Text = "Feminino";
            this.ckbxFeminino.UseVisualStyleBackColor = true;
            this.ckbxFeminino.CheckedChanged += new System.EventHandler(this.ckbxFeminino_CheckedChanged);
            // 
            // cbxDistancia
            // 
            this.cbxDistancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistancia.FormattingEnabled = true;
            this.cbxDistancia.Items.AddRange(new object[] {
            "0 -  20KM",
            "100KM +",
            "21- 50KM",
            "51- 100KM"});
            this.cbxDistancia.Location = new System.Drawing.Point(169, 160);
            this.cbxDistancia.Name = "cbxDistancia";
            this.cbxDistancia.Size = new System.Drawing.Size(100, 21);
            this.cbxDistancia.Sorted = true;
            this.cbxDistancia.TabIndex = 9;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(24, 164);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(133, 13);
            this.lblDistancia.TabIndex = 10;
            this.lblDistancia.Text = "Distância entre a empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(169, 197);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 11;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(73, 203);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(83, 13);
            this.lblEmpresa.TabIndex = 12;
            this.lblEmpresa.Text = "Ultima Empresa:";
            // 
            // cbxTempo
            // 
            this.cbxTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempo.FormattingEnabled = true;
            this.cbxTempo.Items.AddRange(new object[] {
            "1-2 anos",
            "2-3 anos",
            "3-5 anos",
            "5+  anos",
            "até 1 ano"});
            this.cbxTempo.Location = new System.Drawing.Point(169, 229);
            this.cbxTempo.Name = "cbxTempo";
            this.cbxTempo.Size = new System.Drawing.Size(100, 21);
            this.cbxTempo.Sorted = true;
            this.cbxTempo.TabIndex = 13;
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(48, 237);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(115, 13);
            this.lblExperiencia.TabIndex = 14;
            this.lblExperiencia.Text = "Tempo de experiência:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(62, 273);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(95, 13);
            this.lblSalario.TabIndex = 16;
            this.lblSalario.Text = "Salário pretendido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "Enviar formulário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(169, 270);
            this.mskbxSalario.Mask = "0000.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalario.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.cbxTempo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.cbxDistancia);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cbxIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Formulário";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cbxIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.RadioButton rbtSolteiro;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnOutros;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnViuvo;
        private System.Windows.Forms.RadioButton rbntDivorciado;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.CheckBox ckbxFeminino;
        private System.Windows.Forms.CheckBox ckBxMasculino;
        private System.Windows.Forms.ComboBox cbxDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbxTempo;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
    }
}

