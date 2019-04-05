namespace bruno_peso
{
    partial class frmPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.mkbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.mkbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(119, 75);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(120, 112);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso:";
            // 
            // mkbxAltura
            // 
            this.mkbxAltura.Location = new System.Drawing.Point(160, 72);
            this.mkbxAltura.Mask = "9.99";
            this.mkbxAltura.Name = "mkbxAltura";
            this.mkbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mkbxAltura.TabIndex = 3;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(16, 33);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 4;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(16, 56);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 5;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(310, 72);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 120);
            this.gbxSexo.TabIndex = 6;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // mkbxPeso
            // 
            this.mkbxPeso.Location = new System.Drawing.Point(161, 109);
            this.mkbxPeso.Mask = "099.99";
            this.mkbxPeso.Name = "mkbxPeso";
            this.mkbxPeso.Size = new System.Drawing.Size(100, 20);
            this.mkbxPeso.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(123, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 37);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 274);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mkbxPeso);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mkbxAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "frmPesoIdeal";
            this.Text = "Calculadora de Peso Ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.MaskedTextBox mkbxAltura;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.MaskedTextBox mkbxPeso;
        private System.Windows.Forms.Button btnCalcular;
    }
}

