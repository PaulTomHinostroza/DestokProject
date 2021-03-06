﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElAmigo
{
    public partial class frmListarEmpleado : Form
    {
        private List<clsEmpleado> _EmpleadosEncontrados = new List<clsEmpleado>();

        public List<clsEmpleado> EmpleadosEncontrados
        {
            get { return _EmpleadosEncontrados; }
            set { _EmpleadosEncontrados = value; }
        }

        public frmListarEmpleado()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (rbnNombres.Checked == true)
            {
                if (txtTexto.Text.Length >= 3)
                {
                    EmpleadosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoPorNombres(txtTexto.Text))
                    {

                        EmpleadosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                        }

                        contador = contador + 1;
                    }

                }
                else
                {
                    lstvDatos.Items.Clear();
                }
            }

            if (rbnApellidos.Checked == true)
            {
                if (txtTexto.Text.Length >= 3)
                {
                    EmpleadosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoPorApellidos(txtTexto.Text))
                    {

                        EmpleadosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                        }

                        contador = contador + 1;
                    }

                }
                else
                {
                    lstvDatos.Items.Clear();
                }
            } 

            if (rbnDNI.Checked == true)
            {
                if (txtTexto.Text.Length >= 3)
                {
                    EmpleadosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoPorDNI(txtTexto.Text))
                    {

                        EmpleadosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                        }

                        contador = contador + 1;
                    }

                }
                else
                {
                    lstvDatos.Items.Clear();
                }
            }

            if (rbnCargo.Checked == true)
            {
                if (txtTexto.Text.Length >= 3)
                {
                    EmpleadosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoPorCargo(txtTexto.Text))
                    {

                        EmpleadosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                        }

                        contador = contador + 1;
                    }

                }
                else
                {
                    lstvDatos.Items.Clear();
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            EmpleadosEncontrados.Clear();
            lstvDatos.Items.Clear();
            int contador = 1;
            foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoTodos())
            {

                EmpleadosEncontrados.Add(ELEMENTO);
                lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                if (contador % 2 == 0)
                {
                    lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                }

                contador = contador + 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListarEmpleado_Load(object sender, EventArgs e)
        {
            btnMostrarTodos.PerformClick();
        }

        private void rbnNombres_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void rbnApellidos_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void rbnId_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void rbnDNI_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void rbnCargo_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void BotonBuscar()
        {
            if (rbnId.Checked == true)
            {
                btnBuscar.Visible = true;
            }
            else
            {
                btnBuscar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbnId.Checked == true)
                {
                    EmpleadosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsEmpleado ELEMENTO in clsEmpleado.ListarEmpleadoPorId(Convert.ToInt32(txtTexto.Text)))
                    {

                        EmpleadosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdEmpleado.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombresEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.ApellidosEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNIEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.TelefonoEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.EmailEmp);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.NombreCargo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacEmp.ToString("dd/MM/yyyy"));
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaInscripcionEmp.ToString("dd/MM/yyyy"));
                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                        }

                        contador = contador + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un código correcto.");
            }
            
        }

    }
}
