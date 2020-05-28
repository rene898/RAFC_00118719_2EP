using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
    private void Form1_Load(object sender, EventArgs e)
    {
        poblarControles();
    }

    private void poblarControles()
    {
        comboBox1.DataSource = null;
        comboBox1.ValueMember = "contraseña";
        comboBox1.DisplayMember = "usuario";
        comboBox1.DataSource = AppUserDAO.getList();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedValue.Equals(textBox1.Text))
        {
            AppUser u = (AppUser) comboBox1.SelectedItem;

            if (u.userType)
            {
                AppUserDAO.iniciarSesion(u.fullname);
                    
                MessageBox.Show("¡Bienvenido!", 
                    "Hugo Company", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                PrincipalPage ventana = new PrincipalPage();
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Su cuenta se encuentra inactiva, favor hable con el administrador", 
                    "Hugo Company", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
            MessageBox.Show("¡Contraseña incorrecta!",
                "Hugo Company", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.Enter) button1_Click(sender, e);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        CambiarContraseña uVentana = new CambiarContraseña();
        uVentana.ShowDialog();
        poblarControles();
    }
    
    }
}