using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                await _service.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
