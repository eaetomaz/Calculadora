namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            btnmaismenos = new Button();
            btninverso = new Button();
            btnquadrado = new Button();
            btnraiz = new Button();
            btnporcentagem = new Button();
            btnlimpaultimodig = new Button();
            btnLimpadig = new Button();
            btnMC = new Label();
            btnMR = new Label();
            btnmmais = new Label();
            btnmmenos = new Label();
            btnms = new Label();
            btnmv = new Label();
            lcalculo = new Label();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Location = new Point(106, 569);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 56);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Location = new Point(11, 509);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 56);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Location = new Point(106, 509);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 56);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Location = new Point(201, 509);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(86, 56);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Location = new Point(11, 449);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 56);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Location = new Point(201, 449);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(86, 56);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Location = new Point(11, 389);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(89, 56);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Location = new Point(106, 389);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(89, 56);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Location = new Point(201, 389);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(86, 56);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnigual
            // 
            btnigual.Cursor = Cursors.Hand;
            btnigual.Location = new Point(298, 569);
            btnigual.Margin = new Padding(3, 2, 3, 2);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(86, 56);
            btnigual.TabIndex = 11;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnmais
            // 
            btnmais.Cursor = Cursors.Hand;
            btnmais.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnmais.Location = new Point(298, 509);
            btnmais.Margin = new Padding(3, 2, 3, 2);
            btnmais.Name = "btnmais";
            btnmais.Size = new Size(86, 56);
            btnmais.TabIndex = 13;
            btnmais.Text = "+";
            btnmais.UseVisualStyleBackColor = true;
            btnmais.Click += btnmais_Click;
            // 
            // btnmenos
            // 
            btnmenos.Cursor = Cursors.Hand;
            btnmenos.Location = new Point(298, 449);
            btnmenos.Margin = new Padding(3, 2, 3, 2);
            btnmenos.Name = "btnmenos";
            btnmenos.Size = new Size(86, 56);
            btnmenos.TabIndex = 14;
            btnmenos.Text = "-";
            btnmenos.UseVisualStyleBackColor = true;
            btnmenos.Click += btnmenos_Click;
            // 
            // btnmultiplicacao
            // 
            btnmultiplicacao.Cursor = Cursors.Hand;
            btnmultiplicacao.Location = new Point(298, 389);
            btnmultiplicacao.Margin = new Padding(3, 2, 3, 2);
            btnmultiplicacao.Name = "btnmultiplicacao";
            btnmultiplicacao.Size = new Size(86, 56);
            btnmultiplicacao.TabIndex = 15;
            btnmultiplicacao.Text = "*";
            btnmultiplicacao.UseVisualStyleBackColor = true;
            btnmultiplicacao.Click += btnmultiplicacao_Click;
            // 
            // btndivisao
            // 
            btndivisao.Cursor = Cursors.Hand;
            btndivisao.Location = new Point(298, 329);
            btndivisao.Margin = new Padding(3, 2, 3, 2);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(86, 56);
            btndivisao.TabIndex = 16;
            btndivisao.Text = "/";
            btndivisao.UseVisualStyleBackColor = true;
            btndivisao.Click += btndivisao_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Cursor = Cursors.Hand;
            btnlimpar.Location = new Point(201, 269);
            btnlimpar.Margin = new Padding(3, 2, 3, 2);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(86, 56);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "C";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(51, 30);
            lblOperacao.Margin = new Padding(4, 0, 4, 0);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 17);
            lblOperacao.TabIndex = 18;
            // 
            // btncinco
            // 
            btncinco.Cursor = Cursors.Hand;
            btncinco.Location = new Point(106, 449);
            btncinco.Margin = new Padding(3, 2, 3, 2);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(89, 56);
            btncinco.TabIndex = 20;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            btncinco.Click += btncinco_Click;
            // 
            // textResultado
            // 
            textResultado.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textResultado.Location = new Point(-8, 135);
            textResultado.Margin = new Padding(4, 3, 4, 3);
            textResultado.MaxLength = 8;
            textResultado.Multiline = true;
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(409, 65);
            textResultado.TabIndex = 21;
            textResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnvirgula
            // 
            btnvirgula.BackColor = SystemColors.Control;
            btnvirgula.Cursor = Cursors.Hand;
            btnvirgula.Location = new Point(201, 569);
            btnvirgula.Margin = new Padding(3, 2, 3, 2);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(86, 56);
            btnvirgula.TabIndex = 22;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = false;
            btnvirgula.Click += btnvirgula_Click_1;
            // 
            // btnmaismenos
            // 
            btnmaismenos.Cursor = Cursors.Hand;
            btnmaismenos.Location = new Point(11, 569);
            btnmaismenos.Margin = new Padding(3, 2, 3, 2);
            btnmaismenos.Name = "btnmaismenos";
            btnmaismenos.Size = new Size(89, 56);
            btnmaismenos.TabIndex = 23;
            btnmaismenos.Text = "+/-";
            btnmaismenos.UseVisualStyleBackColor = true;
            btnmaismenos.Click += btnmaismenos_Click;
            // 
            // btninverso
            // 
            btninverso.Cursor = Cursors.Hand;
            btninverso.Location = new Point(11, 329);
            btninverso.Margin = new Padding(3, 2, 3, 2);
            btninverso.Name = "btninverso";
            btninverso.Size = new Size(89, 56);
            btninverso.TabIndex = 24;
            btninverso.Text = "1/x";
            btninverso.UseVisualStyleBackColor = true;
            btninverso.Click += btninverso_Click;
            // 
            // btnquadrado
            // 
            btnquadrado.Cursor = Cursors.Hand;
            btnquadrado.Location = new Point(106, 329);
            btnquadrado.Margin = new Padding(3, 2, 3, 2);
            btnquadrado.Name = "btnquadrado";
            btnquadrado.Size = new Size(89, 56);
            btnquadrado.TabIndex = 25;
            btnquadrado.Text = "x²";
            btnquadrado.UseVisualStyleBackColor = true;
            btnquadrado.Click += btnquadrado_Click;
            // 
            // btnraiz
            // 
            btnraiz.Cursor = Cursors.Hand;
            btnraiz.Location = new Point(201, 329);
            btnraiz.Margin = new Padding(3, 2, 3, 2);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(86, 56);
            btnraiz.TabIndex = 26;
            btnraiz.Text = "√";
            btnraiz.UseVisualStyleBackColor = true;
            btnraiz.Click += btnraiz_Click;
            // 
            // btnporcentagem
            // 
            btnporcentagem.Cursor = Cursors.Hand;
            btnporcentagem.Location = new Point(11, 269);
            btnporcentagem.Margin = new Padding(3, 2, 3, 2);
            btnporcentagem.Name = "btnporcentagem";
            btnporcentagem.Size = new Size(89, 56);
            btnporcentagem.TabIndex = 27;
            btnporcentagem.Text = "%";
            btnporcentagem.UseVisualStyleBackColor = true;
            btnporcentagem.Click += btnporcentagem_Click;
            // 
            // btnlimpaultimodig
            // 
            btnlimpaultimodig.Cursor = Cursors.Hand;
            btnlimpaultimodig.Location = new Point(106, 269);
            btnlimpaultimodig.Margin = new Padding(3, 2, 3, 2);
            btnlimpaultimodig.Name = "btnlimpaultimodig";
            btnlimpaultimodig.Size = new Size(89, 56);
            btnlimpaultimodig.TabIndex = 28;
            btnlimpaultimodig.Text = "CE";
            btnlimpaultimodig.UseVisualStyleBackColor = true;
            btnlimpaultimodig.Click += btnlimpaultimodig_Click;
            // 
            // btnLimpadig
            // 
            btnLimpadig.Cursor = Cursors.Hand;
            btnLimpadig.Image = (Image)resources.GetObject("btnLimpadig.Image");
            btnLimpadig.Location = new Point(298, 269);
            btnLimpadig.Margin = new Padding(3, 2, 3, 2);
            btnLimpadig.Name = "btnLimpadig";
            btnLimpadig.Size = new Size(86, 56);
            btnLimpadig.TabIndex = 29;
            btnLimpadig.UseVisualStyleBackColor = true;
            btnLimpadig.Click += btnLimpadig_Click;
            // 
            // btnMC
            // 
            btnMC.AutoSize = true;
            btnMC.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMC.Location = new Point(21, 235);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(41, 23);
            btnMC.TabIndex = 30;
            btnMC.Text = "MC";
            // 
            // btnMR
            // 
            btnMR.AutoSize = true;
            btnMR.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMR.Location = new Point(79, 235);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(41, 23);
            btnMR.TabIndex = 31;
            btnMR.Text = "MR";
            // 
            // btnmmais
            // 
            btnmmais.AutoSize = true;
            btnmmais.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmmais.Location = new Point(145, 235);
            btnmmais.Name = "btnmmais";
            btnmmais.Size = new Size(39, 23);
            btnmmais.TabIndex = 32;
            btnmmais.Text = "M+";
            // 
            // btnmmenos
            // 
            btnmmenos.AutoSize = true;
            btnmmenos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmmenos.Location = new Point(212, 235);
            btnmmenos.Name = "btnmmenos";
            btnmmenos.Size = new Size(34, 23);
            btnmmenos.TabIndex = 33;
            btnmmenos.Text = "M-";
            // 
            // btnms
            // 
            btnms.AutoSize = true;
            btnms.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnms.Location = new Point(274, 235);
            btnms.Name = "btnms";
            btnms.Size = new Size(40, 23);
            btnms.TabIndex = 34;
            btnms.Text = "MS";
            // 
            // btnmv
            // 
            btnmv.AutoSize = true;
            btnmv.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmv.Location = new Point(344, 235);
            btnmv.Name = "btnmv";
            btnmv.Size = new Size(36, 23);
            btnmv.TabIndex = 35;
            btnmv.Text = "Mv";
            // 
            // lcalculo
            // 
            lcalculo.AutoSize = true;
            lcalculo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lcalculo.Location = new Point(325, 106);
            lcalculo.Name = "lcalculo";
            lcalculo.Size = new Size(0, 23);
            lcalculo.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(396, 636);
            Controls.Add(lcalculo);
            Controls.Add(btnmv);
            Controls.Add(btnms);
            Controls.Add(btnmmenos);
            Controls.Add(btnmmais);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnLimpadig);
            Controls.Add(btnlimpaultimodig);
            Controls.Add(btnporcentagem);
            Controls.Add(btnraiz);
            Controls.Add(btnquadrado);
            Controls.Add(btninverso);
            Controls.Add(btnmaismenos);
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
        private Button btnmaismenos;
        private Button btninverso;
        private Button btnquadrado;
        private Button btnraiz;
        private Button btnporcentagem;
        private Button btnlimpaultimodig;
        private Button btnLimpadig;
        private Label btnMC;
        private Label btnMR;
        private Label btnmmais;
        private Label btnmmenos;
        private Label btnms;
        private Label btnmv;
        private Label lcalculo;
    }
}