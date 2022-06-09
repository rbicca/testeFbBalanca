namespace testeFirebase
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
            this.components = new System.ComponentModel.Container();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrigDest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNF = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(12, 12);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "Connect\r\n";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Visible = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(44, 47);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(84, 22);
            this.lblData.TabIndex = 1;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Location = new System.Drawing.Point(190, 47);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(84, 22);
            this.lblHora.TabIndex = 1;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operador:";
            // 
            // lblOperador
            // 
            this.lblOperador.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperador.Location = new System.Drawing.Point(355, 47);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(84, 22);
            this.lblOperador.TabIndex = 1;
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Peso:";
            // 
            // lblPeso
            // 
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeso.ForeColor = System.Drawing.Color.Lime;
            this.lblPeso.Location = new System.Drawing.Point(154, 86);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(120, 39);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Placa:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlaca.Location = new System.Drawing.Point(66, 22);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(355, 22);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Operação:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperacao.Location = new System.Drawing.Point(66, 54);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(355, 22);
            this.lblOperacao.TabIndex = 4;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Orig/Dest:";
            // 
            // lblOrigDest
            // 
            this.lblOrigDest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblOrigDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrigDest.Location = new System.Drawing.Point(66, 85);
            this.lblOrigDest.Name = "lblOrigDest";
            this.lblOrigDest.Size = new System.Drawing.Size(355, 22);
            this.lblOrigDest.TabIndex = 4;
            this.lblOrigDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Produto:";
            // 
            // lblProduto
            // 
            this.lblProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduto.Location = new System.Drawing.Point(66, 116);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(355, 22);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.Location = new System.Drawing.Point(8, 156);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(24, 13);
            this.lblNF.TabIndex = 2;
            this.lblNF.Text = "NF:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(66, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 22);
            this.label10.TabIndex = 4;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNF);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Controls.Add(this.lblOrigDest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblOperacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(355, 12);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(75, 23);
            this.cmdSet.TabIndex = 6;
            this.cmdSet.Text = "Set";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.cmdSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdConnect);
            this.Name = "Form1";
            this.Text = "Teste Firebase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrigDest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Timer timer1;
    }
}

