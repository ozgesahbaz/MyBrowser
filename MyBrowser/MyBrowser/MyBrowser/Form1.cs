using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        // ödev :
        // her adrese gitme işleminde gidilen adresi combobox a ekleyelim.
        // aynı adresi tekrar tekrar eklemeyelim.
        // combobox dan seçilen bir adrese navigate edelim.


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateBrowser();
        }

        private void NavigateBrowser()
        {
            string url = txtUrl.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Geçerli bir url yazmadınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (url.StartsWith("https://") == false)
            {
                url = "https://" + url;
                txtUrl.Text = url;
            }

            wbBrowser.Navigate(url);
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateBrowser();
            }
        }
    }
}
