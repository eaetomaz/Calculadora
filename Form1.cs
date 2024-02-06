using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Threading;
using System.Linq.Expressions;
using System.Drawing.Drawing2D;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        public double Resultado { get; set; }
        public double Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Multiplicacao,
            Subtracao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += (sender, e) => TrataAtalhos(e);

        }

        public class Button : System.Windows.Forms.Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                Color bc = Color.White;
                Color bg = Color.White;
                Color fc = Color.Black;
                StringFormat formatter = new StringFormat();

                base.OnPaint(e);
                formatter.LineAlignment = StringAlignment.Center;
                formatter.Alignment = StringAlignment.Center;
                RectangleF rectangle = new RectangleF(0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);

                e.Graphics.FillRectangle(new SolidBrush(bg), e.ClipRectangle);
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, bc, ButtonBorderStyle.Solid);
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(fc), rectangle, formatter);
            }
        }

        private void TrataAtalhos(KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btncinco.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.Add:
                    btnmais.PerformClick();
                    break;
                case Keys.Subtract:
                    btnmenos.PerformClick();
                    break;
                case Keys.Multiply:
                    btnmultiplicacao.PerformClick();
                    break;
                case Keys.Divide:
                    btndivisao.PerformClick();
                    break;
                case Keys.Back:
                case Keys.Delete:
                    btnlimpar.PerformClick();
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                    btnvirgula.PerformClick();
                    break;
                case Keys.Oemplus:
                case Keys.Enter:
                    btnigual.PerformClick();
                    break;
            }
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se há um valor a ser utilizado
                if (!string.IsNullOrEmpty(textResultado.Text) && Convert.ToDouble(textResultado.Text) > 0)
                {
                    switch (OperacaoSelecionada)
                    {
                        case Operacao.Adicao:
                            Resultado = Valor + Convert.ToDouble(textResultado.Text);
                            break;
                        case Operacao.Multiplicacao:
                            Resultado = Valor * Convert.ToDouble(textResultado.Text);
                            break;
                        case Operacao.Subtracao:
                            Resultado = Valor - Convert.ToDouble(textResultado.Text);
                            break;
                        case Operacao.Divisao:
                            Resultado = Valor / Convert.ToDouble(textResultado.Text);
                            break;
                    }
                    
                    textResultado.Text = Convert.ToString(Resultado);
                    lblOperacao.Text = "=";
                    
                }
                else
                {
                    // Tratar a situação onde não há valor inserido
                    MessageBox.Show("Insira um valor antes de realizar a operação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                // Tratar uma possível exceção de formato (por exemplo, se o usuário inserir um valor inválido)
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratar outras exceções, se necessário
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    OperacaoSelecionada = Operacao.Adicao;
                    Valor = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = "";
                    lblOperacao.Text = "+";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a operação de soma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    OperacaoSelecionada = Operacao.Subtracao;
                    Valor = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = "";
                    lblOperacao.Text = "-";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a operação de subtração", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    OperacaoSelecionada = Operacao.Multiplicacao;
                    Valor = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = "";
                    lblOperacao.Text = "*";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a operação de multiplicação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se há um valor antes de atribuir a operação
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                        OperacaoSelecionada = Operacao.Divisao;
                        Valor = Convert.ToDouble(textResultado.Text);
                        textResultado.Text = "";
                        lblOperacao.Text = "/";

                }
                else
                {
                    // Tratar a situação onde não há valor inserido
                    MessageBox.Show("Insira um valor antes de selecionar a operação de divisão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                // Tratar uma possível exceção de formato (por exemplo, se o usuário inserir um valor inválido)
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratar outras exceções, se necessário
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
        }


        private void btncinco_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
            lblOperacao.Text = "";
        }

        private void btnvirgula_Click_1(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
                textResultado.Text += ",";

        }
    }
}
