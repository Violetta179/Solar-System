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

    public partial class Form2 : Form
    {
        PlanetContext db;

        public Form2()
        {
            InitializeComponent();
            db = new PlanetContext();
            db.Planetses.Load();
            dataGridView1.DataSource = db.Planetses.Local.ToBindingList();

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

        private void button1ADD_Click(object sender, EventArgs e)
        {
            Form1 plForm = new Form1();
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Planet planet = new Planet();
            planet.Name = plForm.comboBox1.SelectedItem.ToString();

            db.Planetses.Add(planet);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }

        private void button2EDIT_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Planet planet = db.Planetses.Find(id);

            Form1 plForm = new Form1();
            plForm.comboBox1.SelectedItem = planet.Name;
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            planet.Name = plForm.comboBox1.SelectedItem.ToString();

            dataGridView1.Refresh(); 
            MessageBox.Show("Объект обновлен");
        }

        private void button3DELETE_Click(object sender, EventArgs e)
        {
            Planet planet = db.Planetses.FirstOrDefault();

            if (planet != null)
            {
                db.Planetses.Attach(planet);
                db.Planetses.Remove(planet);
                db.SaveChanges();
            }
            MessageBox.Show("Объект удален");
            }
        }
    }

