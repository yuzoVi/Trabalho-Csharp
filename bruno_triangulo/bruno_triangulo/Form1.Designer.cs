namespace bruno_triangulo
{
    partial class frmTriangulo
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(141, 80);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(40, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "lado A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(141, 130);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Lado B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(141, 185);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(44, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Lado C:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(188, 77);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 20);
            this.txtLadoA.TabIndex = 3;
            this.txtLadoA.Text = "0";
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(188, 127);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 20);
            this.txtLadoB.TabIndex = 4;
            this.txtLadoB.Text = "0";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(188, 182);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 20);
            this.txtLadoC.TabIndex = 5;
            this.txtLadoC.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(144, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 62);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 305);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "frmTriangulo";
            this.Text = "Que tipo de triangulo é?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnCalcular;
    }
}

