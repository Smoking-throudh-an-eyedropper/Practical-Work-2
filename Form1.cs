using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private TicketDatabase _ticket;

        public WeatherForm()
        {
            InitializeComponent();

            _ticket = new TicketDatabase();
            _ticket.Initialize();

            TicketDataGrid.DataSource = _ticket.Tickets.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

            TicketDataGrid.DataSource = _ticket.Tickets.Where(u=>u.Movie.TheNameOfTheMovie.Contains(textBox1.Text.ToLower())).ToList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            { 
                case 0:
                    TicketDataGrid.DataSource = _ticket.Tickets.Where(u => u.Movie.TheGenreOfTheFilm == Movie.TheGenresOfTheFilms.Action).ToList();
                   break; 
                case 1:
                    TicketDataGrid.DataSource = _ticket.Tickets.Where(u => u.Movie.TheGenreOfTheFilm == Movie.TheGenresOfTheFilms.Drama).ToList();
                    break;
                case 2:
                    TicketDataGrid.DataSource = _ticket.Tickets.Where(u => u.Movie.TheGenreOfTheFilm == Movie.TheGenresOfTheFilms.Romance).ToList();
                    break;
                    
            }
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
            TicketDataGrid.DataSource = _ticket.Tickets.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            TicketDataGrid.DataSource = _ticket.Tickets.Where(u => u.Price>150 ).ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            TicketDataGrid.DataSource = _ticket.Tickets.OrderBy(u => u.Price).ToList();
        }

    }
}