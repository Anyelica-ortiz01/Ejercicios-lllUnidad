using SistemaUniversitario.Data;
using SistemaUniversitario.Modelos;
using Microsoft.EntityFrameworkCore;
namespace SistemaUniversitario
{
    public partial class Form1 : Form
    {
        UniversidadContext db = new UniversidadContext();
        public Form1()
        {
            InitializeComponent();
            CargarCarrera();
        }
        private void CargarCarrera()
        {
            cbCarreras.DataSource = db.Carreras.ToList();
            cbCarreras.DisplayMember = "NombreCarrera";
            cbCarreras.ValueMember = "Id";

            cbFiltro.DataSource = db.Carreras.ToList();
            cbFiltro.DisplayMember = "NombreCarrera";
            cbFiltro.ValueMember = "Id";
        }

        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera()
            {
                NombreCarrera = txtCarrera.Text
            };
            db.Carreras.Add(carrera);
            db.SaveChanges();

            MessageBox.Show("Carrera Guardada.");
            CargarCarrera();
        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante()
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                CarreraId = Convert.ToInt32(cbCarreras.SelectedValue)
            };
            db.Estudiantes.Add(estudiante);
            db.SaveChanges();

            MessageBox.Show("Estudiante Guardado.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var lista = db.Estudiantes.Include(e => e.Carrera).Select(e => new
            {
                e.Id,
                e.Nombre,
                e.Edad,
                Carrera = e.Carrera.NombreCarrera
            }).ToList();

            dgvDatos.DataSource = lista;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int CarreraId = Convert.ToInt32(cbFiltro.SelectedValue);

            var lista = db.Estudiantes.Include(e => e.Carrera).Where(e => e.CarreraId == CarreraId).Select(e => new
            {
                e.Nombre,
                e.Edad,
                Carrera = e.Carrera.NombreCarrera
            })
                .ToList();

            dgvDatos.DataSource= lista;
        }
    }
}
