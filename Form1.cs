using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Threading;
using System.Linq.Expressions;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        List<string> historicoCalculos = new List<string>();

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
                // Verificar se h� um valor a ser utilizado
                if (!string.IsNullOrEmpty(textResultado.Text))
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

                    historicoCalculos.Add(lcalculo.Text + textResultado.Text);
                    textResultado.Text = Convert.ToString(Resultado);
                    lcalculo.Text = Convert.ToString(Resultado);

                }
                else
                {
                    // Tratar a situa��o onde n�o h� valor inserido
                    MessageBox.Show("Insira um valor antes de realizar a opera��o", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                // Tratar uma poss�vel exce��o de formato (por exemplo, se o usu�rio inserir um valor inv�lido)
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratar outras exce��es, se necess�rio
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
                    lcalculo.Text = Valor + " + ";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a opera��o de soma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    lcalculo.Text = Valor + " - ";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a opera��o de subtra��o", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    lcalculo.Text = Valor + " * ";
                }
                else
                {

                    MessageBox.Show("Insira um valor antes de selecionar a opera��o de multiplica��o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                // Verificar se h� um valor antes de atribuir a opera��o
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    OperacaoSelecionada = Operacao.Divisao;
                    Valor = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = "";
                    lcalculo.Text = Valor + " / ";

                }
                else
                {
                    // Tratar a situa��o onde n�o h� valor inserido
                    MessageBox.Show("Insira um valor antes de selecionar a opera��o de divis�o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                // Tratar uma poss�vel exce��o de formato (por exemplo, se o usu�rio inserir um valor inv�lido)
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratar outras exce��es, se necess�rio
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lcalculo.Text = "";
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

        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(textResultado.Text))
                {

                    double numeroAtual = Convert.ToDouble(textResultado.Text);

                    numeroAtual = -numeroAtual;

                    textResultado.Text = numeroAtual.ToString();
                }
                else
                {
                    MessageBox.Show("Insira um n�mero antes de pressionar +/-", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btninverso_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    double numeroAtual = Convert.ToDouble(textResultado.Text);

                    double inverso = 1 / numeroAtual;

                    textResultado.Text = inverso.ToString();
                }
                else
                {
                    MessageBox.Show("Insira um n�mero antes de pressionar o bot�o 1/x", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("N�o � poss�vel dividir por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnquadrado_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se h� um n�mero no visor
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    double numeroAtual = Convert.ToDouble(textResultado.Text);
                    double quadrado = Math.Pow(numeroAtual, 2);

                    textResultado.Text = quadrado.ToString();
                }
                else
                {
                    MessageBox.Show("Insira um n�mero antes de pressionar o bot�o x�", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se h� um n�mero no visor
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    double numeroAtual = Convert.ToDouble(textResultado.Text);
                    double raiz = Math.Sqrt(numeroAtual);

                    textResultado.Text = raiz.ToString();
                }
                else
                {
                    MessageBox.Show("Insira um n�mero antes de definir essa opera��o", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnporcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se h� um n�mero no visor
                if (!string.IsNullOrEmpty(textResultado.Text))
                {
                    double numeroAtual = Convert.ToDouble(textResultado.Text);
                    double porcentagem = (numeroAtual * 10) / 100;

                    textResultado.Text = porcentagem.ToString();
                }
                else
                {
                    MessageBox.Show("Insira um n�mero antes de definir essa opera��o", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpaultimodig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textResultado.Text))
            {
                textResultado.Text = "";
            }
        }

        private void btnLimpadig_Click(object sender, EventArgs e)
        {
            // Substitua "button1" pelo nome real do seu bot�o
            btnLimpadig.Image = Properties.Resources.imagedig;

            if (!string.IsNullOrEmpty(textResultado.Text))
            {
                string numeroAtual = textResultado.Text;
                numeroAtual = numeroAtual.Substring(0, numeroAtual.Length - 1);

                textResultado.Text = numeroAtual;
            }
            else
            {
                MessageBox.Show("N�o h� nada para apagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {
        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
        }

        private void btnmmais_Click(object sender, EventArgs e)
        {
        }

        private void btnmmenos_Click(object sender, EventArgs e)
        {
        }

        private void btnms_Click(object sender, EventArgs e)
        {
        }

        private void btnmv_Click(object sender, EventArgs e)
        {
        }

        private void lcalculo_Click(object sender, EventArgs e)
        {
        }

    }
}


