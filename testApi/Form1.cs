using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var epsgCode = EpsgBox.Text;
            var url = $"http://spatialreference.org/ref/epsg/{epsgCode}/proj4/";

            var client = new HttpClient();
            var resp = await client.GetAsync(url);
            var txt = await resp.Content.ReadAsStringAsync();

            ResultBox.Text = txt;
        }
    }
}
