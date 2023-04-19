using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private ИнформацияDatabase _Информация;

        public WeatherForm()
        {
            InitializeComponent();

            _Информация = new ИнформацияDatabase();
            _Информация.Initialize();

            WeatherDataGrid.DataSource = _Информация.Информация.ToList();
        }


        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.дисциплина == дисциплина.МДК01).ToList();
                    break;
                case 1:
                    WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.дисциплина == дисциплина.Философия).ToList();
                    break;
                case 2:
                    WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.дисциплина == дисциплина.Английский).ToList();
                    break;
                case 3:
                    WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.дисциплина == дисциплина.Физвоспитание).ToList();
                    break;
                case 4:
                    WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.дисциплина == дисциплина.МДК02).ToList();
                    break;
            }

        }

        private void textBox1_TextChanged_1(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.преподавательName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
            WeatherDataGrid.DataSource = _Информация.Информация.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _Информация.Информация.Where(u => u.стаж > 0).ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _Информация.Информация.OrderBy(u => u.стаж).ToList();
        }
    }
}