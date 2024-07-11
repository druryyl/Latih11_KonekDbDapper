namespace Latih11_KonekDbDapper
{
    public partial class Form1 : Form
    {
        private readonly NilaiDal _nilaiDal;

        public Form1()
        {
            InitializeComponent();
            _nilaiDal = new NilaiDal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var datasource = _nilaiDal.ListData();
            dataGridView1.DataSource = datasource;
        }
    }
}
