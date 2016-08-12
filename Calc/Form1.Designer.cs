namespace Calc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hostorico = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.TextBox();
            this.numero0 = new System.Windows.Forms.Button();
            this.numero00 = new System.Windows.Forms.Button();
            this.numeroPonto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.numero7 = new System.Windows.Forms.Button();
            this.numero8 = new System.Windows.Forms.Button();
            this.numero9 = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.zerar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostorico
            // 
            this.hostorico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hostorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.hostorico.Location = new System.Drawing.Point(12, 12);
            this.hostorico.Name = "hostorico";
            this.hostorico.Size = new System.Drawing.Size(347, 46);
            this.hostorico.TabIndex = 0;
            this.hostorico.TextChanged += new System.EventHandler(this.hostorico_TextChanged);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.tela.Location = new System.Drawing.Point(278, 62);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(71, 27);
            this.tela.TabIndex = 1;
            this.tela.TextChanged += new System.EventHandler(this.tela_TextChanged);
            // 
            // numero0
            // 
            this.numero0.Location = new System.Drawing.Point(20, 202);
            this.numero0.Name = "numero0";
            this.numero0.Size = new System.Drawing.Size(80, 29);
            this.numero0.TabIndex = 2;
            this.numero0.Text = "0";
            this.numero0.UseVisualStyleBackColor = true;
            this.numero0.Click += new System.EventHandler(this.numero0_Click);
            // 
            // numero00
            // 
            this.numero00.Location = new System.Drawing.Point(106, 202);
            this.numero00.Name = "numero00";
            this.numero00.Size = new System.Drawing.Size(80, 29);
            this.numero00.TabIndex = 3;
            this.numero00.Text = "00";
            this.numero00.UseVisualStyleBackColor = true;
            this.numero00.Click += new System.EventHandler(this.numero00_Click);
            // 
            // numeroPonto
            // 
            this.numeroPonto.Location = new System.Drawing.Point(192, 202);
            this.numeroPonto.Name = "numeroPonto";
            this.numeroPonto.Size = new System.Drawing.Size(80, 29);
            this.numeroPonto.TabIndex = 4;
            this.numeroPonto.Text = ".";
            this.numeroPonto.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 134);
            this.button4.TabIndex = 5;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(20, 167);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(80, 29);
            this.numero1.TabIndex = 6;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = true;
            this.numero1.Click += new System.EventHandler(this.numero1_Click);
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(106, 167);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(80, 29);
            this.numero2.TabIndex = 7;
            this.numero2.Text = "2";
            this.numero2.UseVisualStyleBackColor = true;
            this.numero2.Click += new System.EventHandler(this.numero2_Click);
            // 
            // numero3
            // 
            this.numero3.Location = new System.Drawing.Point(192, 167);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(80, 29);
            this.numero3.TabIndex = 8;
            this.numero3.Text = "3";
            this.numero3.UseVisualStyleBackColor = true;
            this.numero3.Click += new System.EventHandler(this.numero3_Click);
            // 
            // numero4
            // 
            this.numero4.Location = new System.Drawing.Point(20, 132);
            this.numero4.Name = "numero4";
            this.numero4.Size = new System.Drawing.Size(80, 29);
            this.numero4.TabIndex = 9;
            this.numero4.Text = "4";
            this.numero4.UseVisualStyleBackColor = true;
            this.numero4.Click += new System.EventHandler(this.numero4_Click);
            // 
            // numero5
            // 
            this.numero5.Location = new System.Drawing.Point(106, 132);
            this.numero5.Name = "numero5";
            this.numero5.Size = new System.Drawing.Size(80, 29);
            this.numero5.TabIndex = 10;
            this.numero5.Text = "5";
            this.numero5.UseVisualStyleBackColor = true;
            this.numero5.Click += new System.EventHandler(this.numero5_Click);
            // 
            // numero6
            // 
            this.numero6.Location = new System.Drawing.Point(192, 132);
            this.numero6.Name = "numero6";
            this.numero6.Size = new System.Drawing.Size(80, 29);
            this.numero6.TabIndex = 11;
            this.numero6.Text = "6";
            this.numero6.UseVisualStyleBackColor = true;
            this.numero6.Click += new System.EventHandler(this.numero6_Click);
            // 
            // numero7
            // 
            this.numero7.Location = new System.Drawing.Point(20, 97);
            this.numero7.Name = "numero7";
            this.numero7.Size = new System.Drawing.Size(80, 29);
            this.numero7.TabIndex = 12;
            this.numero7.Text = "7";
            this.numero7.UseVisualStyleBackColor = true;
            this.numero7.Click += new System.EventHandler(this.numero7_Click);
            // 
            // numero8
            // 
            this.numero8.Location = new System.Drawing.Point(106, 97);
            this.numero8.Name = "numero8";
            this.numero8.Size = new System.Drawing.Size(80, 29);
            this.numero8.TabIndex = 13;
            this.numero8.Text = "8";
            this.numero8.UseVisualStyleBackColor = true;
            this.numero8.Click += new System.EventHandler(this.numero8_Click);
            // 
            // numero9
            // 
            this.numero9.Location = new System.Drawing.Point(192, 97);
            this.numero9.Name = "numero9";
            this.numero9.Size = new System.Drawing.Size(80, 29);
            this.numero9.TabIndex = 14;
            this.numero9.Text = "9";
            this.numero9.UseVisualStyleBackColor = true;
            this.numero9.Click += new System.EventHandler(this.numero9_Click);
            // 
            // adicao
            // 
            this.adicao.Location = new System.Drawing.Point(20, 62);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(39, 29);
            this.adicao.TabIndex = 15;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(61, 62);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(39, 29);
            this.subtracao.TabIndex = 16;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(106, 62);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(39, 29);
            this.multiplicacao.TabIndex = 17;
            this.multiplicacao.Text = "X";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(147, 62);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(39, 29);
            this.divisao.TabIndex = 18;
            this.divisao.Text = "÷";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // zerar
            // 
            this.zerar.Location = new System.Drawing.Point(192, 62);
            this.zerar.Name = "zerar";
            this.zerar.Size = new System.Drawing.Size(39, 29);
            this.zerar.TabIndex = 19;
            this.zerar.Text = "CE";
            this.zerar.UseVisualStyleBackColor = true;
            this.zerar.Click += new System.EventHandler(this.zerar_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(233, 62);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(39, 29);
            this.apagar.TabIndex = 20;
            this.apagar.Text = "<<";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(371, 243);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.zerar);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.numero9);
            this.Controls.Add(this.numero8);
            this.Controls.Add(this.numero7);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numeroPonto);
            this.Controls.Add(this.numero00);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.hostorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora BSI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostorico;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.Button numero0;
        private System.Windows.Forms.Button numero00;
        private System.Windows.Forms.Button numeroPonto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button numero1;
        private System.Windows.Forms.Button numero2;
        private System.Windows.Forms.Button numero3;
        private System.Windows.Forms.Button numero4;
        private System.Windows.Forms.Button numero5;
        private System.Windows.Forms.Button numero6;
        private System.Windows.Forms.Button numero7;
        private System.Windows.Forms.Button numero8;
        private System.Windows.Forms.Button numero9;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button zerar;
        private System.Windows.Forms.Button apagar;
    }
}

