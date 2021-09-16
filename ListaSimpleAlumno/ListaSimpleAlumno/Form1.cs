using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimpleAlumno
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int numero = int.Parse(txtNumero.Text);
                string matricula = txtMatricula.Text;
                string nombre = txtNombre.Text;
                string apellidoP = txtApellidoP.Text;
                string apellidoM = txtApellidoM.Text;
                string carrera = txtCarrera.Text;
                int calificacion = int.Parse(txtCalificacion.Text);
                int promedio = calificacion * 5;
                int a = 0 ,b = 0 ,c = 0,d = 0 ,l = 0,f = 0, g =0 , h = 0 , j = 0, x = 0;
                lstCalificacion.Items.Clear();
                for (int i = 0; i < promedio; i++)
                {
                    if (i < 5)
                    {
                        a++;
                        lstCalificacion.Items.Add("semestre 1 " + "unidad" + " - " + a + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 5 && i < 10)
                    {
                        b++;
                        lstCalificacion.Items.Add("semestre 2 " + "unidad" + " - " + b + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 10 && i < 15)
                    {
                    c++;
                    lstCalificacion.Items.Add("semestre 3 " + "unidad" + " - " + c + " - " + "promedio" + " - " + r.Next(6, 10));
                }
                    if (i >= 15 && i < 20)
                    {
                        d++;
                        lstCalificacion.Items.Add("semestre 4 " + "unidad" + " - " + d + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 20 && i < 25)
                    {
                        f++;
                        lstCalificacion.Items.Add("semestre 5 " + "unidad" + " - " + f + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 25 && i < 30)
                    {
                        l++;
                        lstCalificacion.Items.Add("semestre 6 " + "unidad" + " - " + l + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 30 && i < 35)
                    {
                        g++;
                        lstCalificacion.Items.Add("semestre 7 " + "unidad" + " - " + g + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 35 && i < 40)
                    {
                        h++;
                        lstCalificacion.Items.Add("semestre 8 " + "unidad" + " - " + h + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 40 && i < 45)
                    {
                        j++;
                        lstCalificacion.Items.Add("semestre 9 " + "unidad" + " - " + j + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                    if (i >= 45 && i < 50)
                    {
                        x++;
                        lstCalificacion.Items.Add("semestre 10 " + "unidad" + " - " + x + " - " + "promedio" + " - " + r.Next(6, 10));
                    }
                }
                Nodo n = new Nodo(numero, matricula, nombre, apellidoP, apellidoM, carrera, calificacion);
                miLista.Agregar(n);
                txtNumero.Clear();
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtCalificacion.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Eliminar(numero);
                txtNumero.Clear();
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                Nodo b = new Nodo();
                if (miLista.Buscar(numero, ref b))
                {
                    txtMatricula.Text = b.Matricula;
                    txtNombre.Text = b.Nombre;
                    txtApellidoP.Text = b.ApellidoP;
                    txtApellidoM.Text = b.ApellidoM;
                    txtCarrera.Text = b.Carrera;
                }
                else
                {
                    txtNumero.Clear();
                    txtMatricula.Clear();
                    txtNombre.Clear();
                    txtApellidoP.Clear();
                    txtApellidoM.Clear();
                    txtCarrera.Clear();
                    MessageBox.Show("NO Existe ");
                }
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                miLista.Modificar(numero, txtMatricula.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCarrera.Text);
                txtNumero.Clear();
                txtMatricula.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtCarrera.Clear();
                txtNumero.Focus();
                miLista.Mostrar(lstLista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
