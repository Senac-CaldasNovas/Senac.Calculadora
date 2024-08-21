namespace Senac.Calculadora
{
    public partial class Form1 : Form
    {
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
    }
}
