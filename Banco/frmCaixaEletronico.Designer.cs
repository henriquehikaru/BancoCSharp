namespace Banco
{
    partial class frmCaixaEletronico
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.btnSacar = new System.Windows.Forms.Button();
            this.numValorDeposito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoLimite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(364, 59);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(188, 34);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "0,00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Saque:";
            // 
            // numValorSaque
            // 
            this.numValorSaque.DecimalPlaces = 2;
            this.numValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorSaque.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numValorSaque.Location = new System.Drawing.Point(196, 187);
            this.numValorSaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorSaque.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(180, 30);
            this.numValorSaque.TabIndex = 3;
            this.numValorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(196, 254);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(168, 69);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.DecimalPlaces = 2;
            this.numValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValorDeposito.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numValorDeposito.Location = new System.Drawing.Point(560, 187);
            this.numValorDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numValorDeposito.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numValorDeposito.Name = "numValorDeposito";
            this.numValorDeposito.Size = new System.Drawing.Size(180, 30);
            this.numValorDeposito.TabIndex = 5;
            this.numValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Depósito:";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(560, 254);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(168, 69);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "&Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Limite de Crédito:";
            // 
            // numLimiteCredito
            // 
            this.numLimiteCredito.DecimalPlaces = 2;
            this.numLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimiteCredito.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLimiteCredito.Location = new System.Drawing.Point(38, 63);
            this.numLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLimiteCredito.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numLimiteCredito.Name = "numLimiteCredito";
            this.numLimiteCredito.Size = new System.Drawing.Size(180, 30);
            this.numLimiteCredito.TabIndex = 9;
            this.numLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLimiteCredito.Validating += new System.ComponentModel.CancelEventHandler(this.numLimiteCredito_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo com Limite:";
            // 
            // lblSaldoLimite
            // 
            this.lblSaldoLimite.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSaldoLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldoLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoLimite.Location = new System.Drawing.Point(618, 59);
            this.lblSaldoLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoLimite.Name = "lblSaldoLimite";
            this.lblSaldoLimite.Size = new System.Drawing.Size(188, 34);
            this.lblSaldoLimite.TabIndex = 10;
            this.lblSaldoLimite.Text = "0,00";
            this.lblSaldoLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSaldoLimite);
            this.Controls.Add(this.numLimiteCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numValorDeposito);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.numValorSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCaixaEletronico";
            this.Text = "Caixa Eletrônico";
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.NumericUpDown numValorDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLimiteCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldoLimite;
    }
}

