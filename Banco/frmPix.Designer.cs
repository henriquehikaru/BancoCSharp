namespace Banco
{
    partial class frmPix
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
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPagador = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtContaPagador = new System.Windows.Forms.TextBox();
            this.txtContaRemetente = new System.Windows.Forms.TextBox();
            this.numValorTransferencia = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(133, 268);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(84, 46);
            this.btnTransferir.TabIndex = 0;
            this.btnTransferir.Text = "&Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(269, 268);
            this.btnExtrato.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(84, 46);
            this.btnExtrato.TabIndex = 1;
            this.btnExtrato.Text = "&Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remetente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mensagem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Método:";
            // 
            // txtPagador
            // 
            this.txtPagador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagador.Location = new System.Drawing.Point(71, 10);
            this.txtPagador.Margin = new System.Windows.Forms.Padding(2);
            this.txtPagador.Name = "txtPagador";
            this.txtPagador.Size = new System.Drawing.Size(274, 20);
            this.txtPagador.TabIndex = 10;
            // 
            // txtRemetente
            // 
            this.txtRemetente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemetente.Location = new System.Drawing.Point(71, 58);
            this.txtRemetente.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(274, 20);
            this.txtRemetente.TabIndex = 11;
            // 
            // txtContaPagador
            // 
            this.txtContaPagador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContaPagador.Location = new System.Drawing.Point(411, 10);
            this.txtContaPagador.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaPagador.Name = "txtContaPagador";
            this.txtContaPagador.Size = new System.Drawing.Size(76, 20);
            this.txtContaPagador.TabIndex = 12;
            // 
            // txtContaRemetente
            // 
            this.txtContaRemetente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContaRemetente.Location = new System.Drawing.Point(411, 59);
            this.txtContaRemetente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaRemetente.Name = "txtContaRemetente";
            this.txtContaRemetente.Size = new System.Drawing.Size(76, 20);
            this.txtContaRemetente.TabIndex = 13;
            // 
            // numValorTransferencia
            // 
            this.numValorTransferencia.DecimalPlaces = 2;
            this.numValorTransferencia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numValorTransferencia.Location = new System.Drawing.Point(71, 109);
            this.numValorTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.numValorTransferencia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValorTransferencia.Name = "numValorTransferencia";
            this.numValorTransferencia.Size = new System.Drawing.Size(90, 20);
            this.numValorTransferencia.TabIndex = 14;
            this.numValorTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxMetodoPagamento
            // 
            this.comboBoxMetodoPagamento.FormattingEnabled = true;
            this.comboBoxMetodoPagamento.Items.AddRange(new object[] {
            "Pix Copia e Cola",
            "Pix QR Code",
            "Pix CPF/CNPJ"});
            this.comboBoxMetodoPagamento.Location = new System.Drawing.Point(253, 108);
            this.comboBoxMetodoPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMetodoPagamento.Name = "comboBoxMetodoPagamento";
            this.comboBoxMetodoPagamento.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMetodoPagamento.TabIndex = 15;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensagem.Location = new System.Drawing.Point(11, 171);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(2);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(480, 68);
            this.txtMensagem.TabIndex = 16;
            // 
            // frmPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 353);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.comboBoxMetodoPagamento);
            this.Controls.Add(this.numValorTransferencia);
            this.Controls.Add(this.txtContaRemetente);
            this.Controls.Add(this.txtContaPagador);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.txtPagador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnTransferir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPix";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmPix";
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPagador;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtContaPagador;
        private System.Windows.Forms.TextBox txtContaRemetente;
        private System.Windows.Forms.NumericUpDown numValorTransferencia;
        private System.Windows.Forms.ComboBox comboBoxMetodoPagamento;
        private System.Windows.Forms.TextBox txtMensagem;
    }
}