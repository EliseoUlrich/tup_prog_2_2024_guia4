using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Cooperativa
{
    public partial class Ejercicio1 : Form
    {
        Cooperativa cooperativa;
        Cliente clienteSeleccion;
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnIniciarCooperativa_Click(object sender, EventArgs e)
        {
            string nombre = tBCooperativa.Text;
            cooperativa = new Cooperativa(nombre);
            btnIniciarCooperativa.Enabled = false;
            tBCooperativa.Enabled = false;
            gBAltaDeClientes.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnCargaDeClientes_Click(object sender, EventArgs e)
        {
            DatosDelCliente fCliente = new DatosDelCliente();

            if (fCliente.ShowDialog() == DialogResult.OK)
            {
                int servicio = Convert.ToInt32(fCliente.tBNroDeServicio.Text);

                string nombre = fCliente.tBNombre.Text;
                int dni = Convert.ToInt32(fCliente.tBDNI.Text);
                string direccion = fCliente.tBDireccion.Text;

                Medidor medidor = new Medidor(servicio);
                Cliente nuevo = cooperativa.AgregarCliente(dni, nombre, direccion, medidor);

                MessageBox.Show($"Servicio nro: {nuevo.Medidor.NumeroServicio}. Cliente nuevo!");

                gBConsumos.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double medicionActual = Convert.ToDouble(tBCargaDeConsumos.Text);

            clienteSeleccion.Medidor.RegistrarConsumo(medicionActual);
            lblConsumos.Text = $"Último periodo: {clienteSeleccion.Medidor.PeriodoActual}";
            tBCargaDeConsumos.Clear();
        }

        private void btnSeleccionarNro_Click(object sender, EventArgs e)
        {
            lblServicioSeleccionado.Text = "";
            gBConsumos.Enabled = false;
            gBCargaDeConsumos.Enabled = false;

            if (string.IsNullOrEmpty(tBNroDeServicio.Text.Trim()) == false)
            {
                int nroServicio = Convert.ToInt32(tBNroDeServicio.Text.Trim());
                clienteSeleccion = cooperativa.BuscarCliente(nroServicio);
                if (clienteSeleccion != null)
                {
                    lblServicioSeleccionado.Text = clienteSeleccion.ToString();
                    gBConsumos.Enabled = true;
                    gBCargaDeConsumos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerConsumo_Click(object sender, EventArgs e)
        {
            Resultados fResultados = new Resultados();
            fResultados.lBResultados.Items.Clear();

            fResultados.lBResultados.Items.Add($"Número de Servicio {clienteSeleccion.Medidor.NumeroServicio,-10}");

            for (int n = 0; n < clienteSeleccion.Medidor.CantidadConsumos; n++)
            {
                string consumo = clienteSeleccion.Medidor.LeerConsumo(n).ToString("0.00");
                int periodo = (n + clienteSeleccion.Medidor.PeriodoActual) % 6;

                fResultados.lBResultados.Items.Add($"{periodo,-10} {consumo,10}");
            }
            fResultados.ShowDialog();
            fResultados.Dispose();
        }
    }
}
