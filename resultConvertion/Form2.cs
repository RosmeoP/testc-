namespace resultConvertion
{
    

    public partial class form2 : Form

    {
        public static form2 instance;
        public form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
