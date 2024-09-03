

using resultConvertion;

namespace ConvertorTemperaturas
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = new TextBox();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            string selecction = convertionTextBox.Text.ToUpper();
            string temperatureConvertion = temperatureTextBox.Text;

            if (double.TryParse(temperatureConvertion, out double temperature)){
                form2 newForm = new form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }
    }
}
