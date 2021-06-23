
namespace meuPrimeiroForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDivisao = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDivisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivisao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDivisao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDivisao.Font = new System.Drawing.Font("Old English Text MT", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDivisao.Location = new System.Drawing.Point(295, 194);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(249, 79);
            this.btnDivisao.TabIndex = 0;
            this.btnDivisao.TabStop = false;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(67, 80);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(202, 23);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.UseWaitCursor = true;
            this.txtNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSoma
            // 
            this.btnSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSoma.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSoma.Font = new System.Drawing.Font("Old English Text MT", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSoma.Location = new System.Drawing.Point(39, 109);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(249, 79);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.TabStop = false;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtracao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubtracao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSubtracao.Font = new System.Drawing.Font("Old English Text MT", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubtracao.Location = new System.Drawing.Point(295, 109);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(249, 79);
            this.btnSubtracao.TabIndex = 3;
            this.btnSubtracao.TabStop = false;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMultiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMultiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Old English Text MT", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicacao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMultiplicacao.Location = new System.Drawing.Point(39, 194);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(249, 79);
            this.btnMultiplicacao.TabIndex = 4;
            this.btnMultiplicacao.TabStop = false;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao1);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(320, 80);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(202, 23);
            this.txtNumero2.TabIndex = 5;
            this.txtNumero2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnDivisao);
            this.Name = "Form1";
            this.Text = "Josué";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

