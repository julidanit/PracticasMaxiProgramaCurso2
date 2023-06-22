using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_practica_WF
{
    public partial class form1_Formulario : Form
    {
        public form1_Formulario()
        {
            InitializeComponent();
        }

        private void form1_Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void form1_Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("See youu");
        }

        private void btn_Boton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            this.BackColor = Color.Blue;

            if (tbx_Texto.Text == "")
                tbx_Texto.BackColor = Color.Red;
            else
                tbx_Texto.BackColor = System.Drawing.SystemColors.Control;
        }

        private void form1_Formulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del medio", "Atención");
        }

        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void tbx_Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbx_Nuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tbx_Nuevo.Text.Length + " Caracteres");
        }
    }
}
