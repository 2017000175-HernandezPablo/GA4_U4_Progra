namespace ejer1GA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jbtnAceptar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(textBox1.Text);
            int mes = int.Parse(textBox2.Text);
            int año = int.Parse(textBox3.Text);

            string nombeMes = "";
            switch (mes)
            {
                case 1:
                    nombeMes = "Enero";
                    break;
                case 2:
                    nombeMes = "Febrero";
                    break;
                case 3:
                    nombeMes = "Marzo";
                    break;
                case 4:
                    nombeMes = "Abril";
                    break;
                case 5:
                    nombeMes = "Mayo";
                    break;
                case 6:
                    nombeMes = "Junio";
                    break;
                case 7:
                    nombeMes = "Julio";
                    break;
                case 8:
                    nombeMes = "Agosto";
                    break;
                case 9:
                    nombeMes = "Septiembre";
                    break;
                case 10:
                    nombeMes = "Octubre";
                    break;
                case 11:
                    nombeMes = "Noviembre";
                    break;
                case 12:
                    nombeMes = "Diciembre";
                    break;
                default:
                    MessageBox.Show("Mes no valido");
                    return;
            }
            textBox4.Text = dia + "de" + nombeMes + "de" + año;
        }

        private void jbtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void jbtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
