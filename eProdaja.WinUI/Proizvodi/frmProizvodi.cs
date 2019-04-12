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

        private async void FrmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadVrsteProizvoda();
            await LoadJediniceMjere();
        }

        private async Task LoadVrsteProizvoda()
        {
            var result = await _vrsteProizvoda.Get<List<Model.VrsteProizvoda>>(null);
            result.Insert(0, new Model.VrsteProizvoda());
            cmbVrstaProizvoda.DisplayMember = "Naziv";
            cmbVrstaProizvoda.ValueMember = "VrstaId";
            cmbVrstaProizvoda.DataSource = result;
        }

        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.Get<List<Model.JediniceMjere>>(null);
            result.Insert(0, new Model.JediniceMjere());
            cmbJedinicaMjere.DisplayMember = "Naziv";
            cmbJedinicaMjere.ValueMember = "JedinicaMjereId";
            cmbJedinicaMjere.DataSource = result;
        }

        private async void CmbVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaProizvoda.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                await LoadProizvodi(id);
            }
        }

        private async Task LoadProizvodi(int vrstaId)
        {
            var result = await _proizvodi.Get<List<Model.Proizvod>>(new ProizvodSearchRequest()
            {
                 VrstaId = vrstaId
            });

            proizvodiGrid.DataSource = result;
        }
        ProizvodUpsertRequest request = new ProizvodUpsertRequest();

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            

            var idObj = cmbVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }

            var jedMjereIdObj = cmbJedinicaMjere.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int jedMjereId))
            {
                request.JedinicaMjereId = jedMjereId;
            }

            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;

            await _proizvodi.Insert<Model.Proizvod>(request);
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
           var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlikaInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
        }
    }
}
