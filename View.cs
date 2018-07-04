using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteExibicao
{
    public partial class View : Form
    {
        HttpClient client = new HttpClient();
        public View()
        {
            InitializeComponent();
            String source = "root," + client.GetAsync("http://localhost:52370/api/data/dir")
                .Result.Content.ReadAsStringAsync().Result.Replace("\"", "")
                .Replace("[", "").Replace("]", "");
            EditRegistro.DataSource = source.Split(',');
            
        }

        private void BtnListarImg_Click(object sender, EventArgs e)
        {
            EditImagem.DataSource = client.GetAsync("http://localhost:52370/api/data/"
                +EditRegistro.SelectedValue + "/"+EditTipo.Text).Result
                .Content.ReadAsStringAsync().Result.Replace("\"", "")
                .Replace("[", "").Replace("]", "").Split(',');
            BtnExibirImg.Visible = true;
        }

        private void BtnExibirImg_Click(object sender, EventArgs e)
        {
            String[] arquivo = EditImagem.SelectedValue.ToString().Split('.');
            var a = "http://localhost:52370/api/data/baixar"
                + EditRegistro.SelectedValue + "/" + arquivo[0] + "/" + arquivo[1];
                
            PicImagem.ImageLocation = client.GetAsync("http://localhost:52370/api/data/baixar"
                + "/" + EditRegistro.SelectedValue + "/" +arquivo[0] + "/" 
                + arquivo[1]).Result.Content.ReadAsStringAsync().Result
                .Replace("\"", "").Replace("[", "").Replace("]", "");

        }
    }

}
