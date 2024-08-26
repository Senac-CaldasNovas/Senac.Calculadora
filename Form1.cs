namespace Senac.Calculadora
{
    public partial class Form1 : Form
    {
        decimal numero1, numero2;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void InsereNumero(int numero)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Clear();
            }

            textBoxResultado.Text = textBoxResultado.Text + numero;
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            InsereNumero(1);
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            InsereNumero(2);
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            InsereNumero(3);
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            InsereNumero(4);
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            InsereNumero(5);
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            InsereNumero(6);
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            InsereNumero(7);
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            InsereNumero(8);
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            InsereNumero(9);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            InsereNumero(0);
        }

        public decimal Soma(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 + valor2;
            return resultado;
        }

        public decimal Subtrai(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 - valor2;
            return resultado;
        }

        public decimal Multiplica(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 * valor2;
            return resultado;
        }

        public decimal Divide(decimal valor1, decimal valor2)
        {
            if (valor2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero");
                return 0;
            }

            decimal resultado = valor1 / valor2;
            return resultado;
        }

        public decimal EfetuaQuadrado(decimal valor)
        {
            decimal resultado = valor * valor;
            return resultado;
        }

        public void GeraResultado()
        {
            decimal resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = Soma(numero1, numero2);
                    break;
                case "-":
                    resultado = Subtrai(numero1, numero2);
                    break;
                case "*":
                    resultado = Multiplica(numero1, numero2);
                    break;
                case "/":
                    resultado = Divide(numero1, numero2);
                    break;
                case "2":
                    resultado = EfetuaQuadrado(numero1);
                    break;
                case "%":
                    resultado = numero1 * (numero2 / 100);
                    break;
            }

            textBoxResultado.Text = resultado.ToString();

            labelHistorico.Text += " " + numero2 + " = " + resultado;

            if(operacao == "%")
            {
                labelHistorico.Text = numero2 + "% de " + numero1 + " = " + resultado;
            }
        }

        public void GeraOperacao(string op)
        {
            if (operacao != "")
            {
                numero2 = Convert.ToDecimal(textBoxResultado.Text);
                GeraResultado();
            }

            operacao = op;
            numero1 = Convert.ToDecimal(textBoxResultado.Text);

            textBoxResultado.Text = "0";

            labelHistorico.Text = numero1 + " " + operacao;
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            GeraOperacao("+");
        }

        private void buttonSubtrai_Click(object sender, EventArgs e)
        {
            GeraOperacao("-");
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            GeraOperacao("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            GeraOperacao("/");
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDecimal(textBoxResultado.Text);
            GeraResultado();
            operacao = "";
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            textBoxResultado.Text = "0";
            operacao = "";
            labelHistorico.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelHistorico.Text = "";
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {

            if (!textBoxResultado.Text.Contains(","))
            {
                textBoxResultado.Text = textBoxResultado.Text + ",";
            }
        }

        private void buttonQuadrado_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDecimal(textBoxResultado.Text);
            operacao = "2";
            GeraResultado();

            labelHistorico.Text = "Quadrado de " + numero1 + " = " + textBoxResultado.Text;
        }

        private void buttonPercentual_Click(object sender, EventArgs e)
        {
            GeraOperacao("%");
        }
    }
}
