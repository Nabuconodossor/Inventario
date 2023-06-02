using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String persona = null;
            String password = null;

            persona = cbxUser.SelectedItem.ToString();
            password = cbxPass.SelectedItem.ToString();

            if (password ==  && persona != string.Empty)
            {
                BasicP_form form = new BasicP_form(nombre, persona);
                Hide();
                form.Show();
            }
            else if (categoria == "Premium" && persona != string.Empty)
            {
                PremiumP_form form = new PremiumP_form(nombre, persona);
                Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Datos inccorectos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
