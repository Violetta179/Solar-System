using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private double _r;
        private double _M;
        private double _v1;
        private double _v2;
        private double _h;

        private const double _g = 6.67e-11;

        public Form1()
        {
            InitializeComponent();
        }

        public class Planet
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double _R { get; set; }
            public double _m { get; set; }
        }

        class PlanetContext : DbContext
        {
            public PlanetContext()
                : base("DbConnection")
            { }

            public DbSet<Planet> Planetses { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDataBase();
        }

        private void UpDatePlanet_Click(object sender, EventArgs e)
        {
            ShowDataBase();
        }

        private List<Planet> GetPlanetData()
        {
            using (var db = new PlanetContext())
            {
               
                Planet planet1 = new Planet() { Name = "Mercury", _R = 2440000, _m = 3.33 * Math.Pow(10, 23) };
                Planet planet2 = new Planet() { Name = "Venera", _R = 6052000, _m = 4.86 * Math.Pow(10, 24) };
                Planet planet3 = new Planet() { Name = "Earth", _R = 6378000, _m = 5.972 * Math.Pow(10, 24) };
                Planet planet4 = new Planet() { Name = "Mars", _R = 3397000, _m = 6.417 * Math.Pow(10, 23) };
                Planet planet5 = new Planet() { Name = "Jupiter", _R = 71490000, _m = 1.89 * Math.Pow(10, 27) };
                Planet planet6 = new Planet() { Name = "Saturn", _R = 60270000, _m = 5.68 * Math.Pow(10, 26) };
                Planet planet7 = new Planet() { Name = "Uranus", _R = 25560000, _m = 8.681 * Math.Pow(10, 26) };
                Planet planet8 = new Planet() { Name = "Neptune", _R = 24760000, _m = 1.024 * Math.Pow(10, 26) };

                db.Planetses.Add(planet1);
                db.Planetses.Add(planet2);
                db.Planetses.Add(planet3);
                db.Planetses.Add(planet4);
                db.Planetses.Add(planet5);
                db.Planetses.Add(planet6);
                db.Planetses.Add(planet7);
                db.Planetses.Add(planet8);
                db.SaveChanges();
                var planets = db.Planetses.ToList();
                return planets;
            }
        }    

        private void ShowDataBase()
        {
            comboBox1.DataSource = GetPlanetData();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)// получить данные
        {
            var planets = GetPlanetData();
            var id = int.Parse(comboBox1.SelectedValue.ToString());
            _h = double.Parse(textBox3.Text);
            _M = planets.FirstOrDefault(f => f.Id == id)._m;
            _r = planets.FirstOrDefault(f => f.Id == id)._R;
        }

        private void button1_Click(object sender, EventArgs e)// расчет скоростей
        {
            _v1 = Math.Sqrt(_g *_M /(_r+_h));
            textBox1.Text = Convert.ToString(_v1);
            _v2 = Math.Sqrt(2 *_g * _M / (_r + _h));
            textBox2.Text = Convert.ToString(_v2);
            Double.TryParse(textBox1.Text, out _v1);
            Double.TryParse(textBox2.Text, out _v2);
        }

        //подключение ко второй форме
        private void button3_Click(object sender, EventArgs e)
        {
            var fm2 = new Form2();
            fm2.Show();
        }
    }
}