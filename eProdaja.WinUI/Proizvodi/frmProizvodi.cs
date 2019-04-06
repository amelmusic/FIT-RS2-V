using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService _vrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService _jediniceMjere = new APIService("JediniceMjere");
        private readonly APIService _proizvodi = new APIService("Proizvod");

        public frmProizvodi()
        {
            InitializeComponent();
        }

        private void cmbJedinicaMjere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            var vrsteProizvoda = await _vrsteProizvoda.Get<List<Model.VrsteProizvoda>>(null);
            vrsteProizvoda.Insert(0, new Model.VrsteProizvoda());

            cmbVrsteProizvoda.DataSource = vrsteProizvoda;
            cmbVrsteProizvoda.DisplayMember = "Naziv";
            cmbVrsteProizvoda.ValueMember = "VrstaId";


            var jediniceMjere = await _jediniceMjere.Get<List<Model.JediniceMjere>>(null);
            jediniceMjere.Insert(0, new Model.JediniceMjere());

            cmbJedinicaMjere.DataSource = jediniceMjere;
            cmbJedinicaMjere.DisplayMember = "Naziv";
            cmbJedinicaMjere.ValueMember = "JedinicaMjereId";
        }

        private async Task LoadProizvodi()
        {
            ProizvodiSearchRequest search = new ProizvodiSearchRequest();

            var vrstaProizvodaId = cmbVrsteProizvoda.SelectedValue;

            if(int.TryParse(vrstaProizvodaId?.ToString(), out int id))
            {
                search.VrstaId = id;
                var list = await _proizvodi.Get<List<Model.Proizvod>>(search);

                dgvProizvodi.DataSource = list;
            }
        }

        private async void cmbVrsteProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadProizvodi();
        }

        ProizvodiInsertRequest request = new ProizvodiInsertRequest();

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtCijena.Text, out decimal cijena))
            {
                request.Cijena = cijena;
            }
            if (int.TryParse(cmbJedinicaMjere.SelectedValue?.ToString(), out int jedMjere))
            {
                request.JedinicaMjereId = jedMjere;
            }

            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Status = true;

            if (int.TryParse(cmbVrsteProizvoda.SelectedValue?.ToString(), out int vrsta))
            {
                request.VrstaId = vrsta;
            }

            await _proizvodi.Insert<Model.Proizvod>(request);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtSlikaInput.Text = openFileDialog1.FileName;

            request.Slika = File.ReadAllBytes(txtSlikaInput.Text);

            Image image = Image.FromFile(txtSlikaInput.Text);
            pictureBox.Image = image;
        }
    }
}
