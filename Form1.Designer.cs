﻿namespace Calculadora
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
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnigual = new Button();
            btnmais = new Button();
            btnmenos = new Button();
            btnmultiplicacao = new Button();
            btndivisao = new Button();
            btnlimpar = new Button();
            lblOperacao = new Label();
            btncinco = new Button();
            textResultado = new TextBox();
            btnvirgula = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Location = new Point(82, 240);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 41);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Location = new Point(9, 195);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 41);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Location = new Point(82, 195);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 41);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Location = new Point(153, 195);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 41);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Location = new Point(9, 150);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 41);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Location = new Point(153, 150);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 41);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Location = new Point(9, 105);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 41);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Location = new Point(82, 105);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 41);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Location = new Point(153, 105);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 41);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnigual
            // 
            btnigual.Cursor = Cursors.Hand;
            btnigual.Location = new Point(153, 240);
            btnigual.Margin = new Padding(3, 2, 3, 2);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(65, 41);
            btnigual.TabIndex = 11;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnmais
            // 
            btnmais.Cursor = Cursors.Hand;
            btnmais.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnmais.Location = new Point(224, 240);
            btnmais.Margin = new Padding(3, 2, 3, 2);
            btnmais.Name = "btnmais";
            btnmais.Size = new Size(65, 41);
            btnmais.TabIndex = 13;
            btnmais.Text = "+";
            btnmais.UseVisualStyleBackColor = true;
            btnmais.Click += btnmais_Click;
            // 
            // btnmenos
            // 
            btnmenos.Cursor = Cursors.Hand;
            btnmenos.Location = new Point(224, 195);
            btnmenos.Margin = new Padding(3, 2, 3, 2);
            btnmenos.Name = "btnmenos";
            btnmenos.Size = new Size(65, 41);
            btnmenos.TabIndex = 14;
            btnmenos.Text = "-";
            btnmenos.UseVisualStyleBackColor = true;
            btnmenos.Click += btnmenos_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.Cursor = Cursors.Hand;
            btnmultiplicacao.Location = new Point(224, 150);
            btnmultiplicacao.Margin = new Padding(3, 2, 3, 2);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(65, 41);
            btnmultiplicacao.TabIndex = 15;
            btnmultiplicacao.Text = "*";
            btnmultiplicacao.UseVisualStyleBackColor = true;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // btndivisao
            // 
            btndivisao.Cursor = Cursors.Hand;
            btndivisao.Location = new Point(224, 105);
            btndivisao.Margin = new Padding(3, 2, 3, 2);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(65, 41);
            btndivisao.TabIndex = 16;
            btndivisao.Text = "/";
            btndivisao.UseVisualStyleBackColor = true;
            btndivisao.Click += btndivisao_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Cursor = Cursors.Hand;
            btnlimpar.Location = new Point(224, 61);
            btnlimpar.Margin = new Padding(3, 2, 3, 2);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(65, 39);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "C";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(43, 61);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 17);
            lblOperacao.TabIndex = 18;
            // 
            // btncinco
            // 
            btncinco.Cursor = Cursors.Hand;
            btncinco.Location = new Point(82, 150);
            btncinco.Margin = new Padding(3, 2, 3, 2);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(65, 41);
            btncinco.TabIndex = 20;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            btncinco.Click += btncinco_Click;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(9, 20);
            textResultado.Margin = new Padding(3, 2, 3, 2);
            textResultado.MaxLength = 8;
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(281, 25);
            textResultado.TabIndex = 21;
            textResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnvirgula
            // 
            btnvirgula.BackColor = SystemColors.Control;
            btnvirgula.Cursor = Cursors.Hand;
            btnvirgula.Location = new Point(9, 240);
            btnvirgula.Margin = new Padding(3, 2, 3, 2);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(65, 41);
            btnvirgula.TabIndex = 22;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = false;
            btnvirgula.Click += btnvirgula_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(303, 296);
            Controls.Add(btnvirgula);
            Controls.Add(textResultado);
            Controls.Add(btncinco);
            Controls.Add(lblOperacao);
            Controls.Add(btnlimpar);
            Controls.Add(btndivisao);
            Controls.Add(btnmultiplicacao);
            Controls.Add(btnmenos);
            Controls.Add(btnmais);
            Controls.Add(btnigual);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnigual;
        private Button btnvirgula;
        private Button btnmais;
        private Button btnmenos;
        private Button btnmultiplicacao;
        private Button btndivisao;
        private Button btnlimpar;
        private Label lblOperacao;
        private Button btncinco;
        public TextBox textResultado;
    }
}