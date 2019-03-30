using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model.Requests;
using Flurl.Http;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        APIService _apiService = new APIService("korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var list = await _apiService.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            
            dgvKorisnici.DataSource = list;
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnikId = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());

            frmKorisniciDetails frm = new frmKorisniciDetails(korisnikId);
            frm.Show();
        }
    }
}
