namespace ex42.cs
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
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.cbxMedidas = new System.Windows.Forms.ComboBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(130, 127);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 0;
            this.txtDe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDe_MouseClick);
            this.txtDe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDe_KeyPress);
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(376, 127);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 20);
            this.txtPara.TabIndex = 1;
            this.txtPara.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPara_KeyUp);
            // 
            // cbxMedidas
            // 
            this.cbxMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedidas.FormattingEnabled = true;
            this.cbxMedidas.Items.AddRange(new object[] {
            "De Arroba Para Quilo",
            "De Libra Para Quilo",
            "De Onça Para Grama",
            "De Acre Para Hectare",
            "De Hectare Para Metro2",
            "De AlqueireMG Para Hectare",
            "De AlqueireSP Para Hectare",
            "De AlqueireNorte Para Hectare",
            "De Braça Para Metro",
            "De Jarda Para Metro",
            "De Pé Para Centímetro",
            "De Polegada Para Centímetro",
            "De Milha Para Quilometro"});
            this.cbxMedidas.Location = new System.Drawing.Point(240, 65);
            this.cbxMedidas.Name = "cbxMedidas";
            this.cbxMedidas.Size = new System.Drawing.Size(138, 21);
            this.cbxMedidas.TabIndex = 2;
            this.cbxMedidas.SelectionChangeCommitted += new System.EventHandler(this.cbxMedidas_SelectionChangeCommitted);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(93, 133);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(326, 134);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 4;
            this.lblPara.Text = "Para:";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(110, 68);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(124, 13);
            this.lblMedida.TabIndex = 5;
            this.lblMedida.Text = "Medida á ser convertida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clique ENTER para converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.cbxMedidas);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.ComboBox cbxMedidas;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label label1;
    }
}

