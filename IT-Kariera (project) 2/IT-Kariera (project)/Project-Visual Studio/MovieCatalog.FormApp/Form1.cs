using MovieCatalog.Services;
using MovieCatalog.Data.Models;
using System.Runtime;
using System.Xml.Linq;
namespace MovieCatalog.FormApp

{
    public partial class Form1 : Form
    {
        public MovieService service = new MovieService();

        private void RefreshDirectors()
        {
            dgvDirector.DataSource = service.GetAllDirectors()
                .Select(d => new { d.Id, d.Name, d.Country })
                .ToList();
        }
        private void ClearInput()
        {
            txtName.Clear();
            txtCountry.Clear();
            txtTitle.Clear();
            txtYear.Clear();
        }
        public Form1()
        {
            InitializeComponent();
            RefreshDirectors();
        }
        private void AddDirector()
        {
            string name = txtName.Text;
            string country = txtCountry.Text;

            service.CreateDirector(name, country);
            RefreshDirectors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDirector_Click (object sender, EventArgs e)
        {
            AddDirector();
            MessageBox.Show("Director added!");
        }
        private void dgvDirector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int directorId = (int)dgvDirector.Rows[e.RowIndex].Cells["Id"].Value;

                var director = service.GetAllDirectors()
                    .FirstOrDefault(d => d.Id == directorId);

                if (director != null)
                {
                    dgvMovie.DataSource = service.GetAllMovies()
                        .Where(m => m.DirectorId == directorId)
                        .Select(m => new { m.Id, m.Title, m.Year })
                        .ToList();
                }
            }
        }    

         private void btnUpdateDirector_Click(object sender, EventArgs e)
         {
            if (dgvDirector.SelectedRows.Count > 0)
            {
                int id = (int)dgvDirector.SelectedRows[0].Cells["Id"].Value;

                service.UpdateDirector(id, txtName.Text, txtCountry.Text);

                MessageBox.Show("Director updated!");
                RefreshDirectors();
                ClearInput();
            }
         }
        private void btnDelDirector_Click(Object sender, EventArgs e)
        {
            if (dgvDirector.SelectedRows.Count > 0)
            {
                int id = (int)dgvDirector.SelectedRows[0].Cells["Id"].Value;

                service.DeleteDirector(id);
                RefreshDirectors();
                dgvMovie.DataSource = null;

                MessageBox.Show("Director deleted!");
            }
          
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (dgvDirector.SelectedRows.Count > 0)
            {
                int directorId = (int)dgvDirector.SelectedRows[0].Cells["Id"].Value;
                service.AddMovie(directorId, txtTitle.Text, int.Parse(txtYear.Text));
                RefreshDirectors();
                MessageBox.Show("Movie added!");
                dgvDirector_CellClick(null, new DataGridViewCellEventArgs(0, dgvDirector.CurrentRow.Index));
            }
            txtTitle.Text = "";
            txtYear.Text = "";
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovie.SelectedRows.Count > 0)
            {
                int movieId = (int)dgvMovie.SelectedRows[0].Cells["Id"].Value;

                service.UpdateMovie(movieId, txtTitle.Text, int.Parse(txtYear.Text));

                MessageBox.Show("Movie updated!");

                dgvDirector_CellClick(null,new DataGridViewCellEventArgs(0, dgvDirector.CurrentRow.Index));

                ClearInput();
            }
            else
            {
                MessageBox.Show("Please select a movie first!");
            }
        }
        private void btnDelMovie_Click(object sender,EventArgs e)
        {
            if (dgvMovie.SelectedRows.Count>0)
            {
                int movieId = (int)dgvMovie.SelectedRows[0].Cells["Id"].Value;
                service.DeleteMovie(movieId);
                MessageBox.Show("Movie deleted!");
                dgvDirector_CellClick(null, new DataGridViewCellEventArgs(0, dgvDirector.CurrentRow.Index));
            }
            else
            {
                MessageBox.Show("Please select a movie first!");
            }
        }


    }
}
