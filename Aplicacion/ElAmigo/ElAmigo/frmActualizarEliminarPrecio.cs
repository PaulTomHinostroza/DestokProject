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
    public partial class frmActualizarEliminarPrecio : Form
    {
        
        private clsProducto _ProductoSeleccionado;

        public clsProducto ProductoSeleccionado
        {
            get { return _ProductoSeleccionado; }
            set { _ProductoSeleccionado = value; }
        }

        private clsPrecio _PrecioSeleccionado;

        public clsPrecio PrecioSeleccionado
        {
            get { return _PrecioSeleccionado; }
            set { _PrecioSeleccionado = value; }
        }

        private List<clsProducto> _ProductosEncontrados = new List<clsProducto>();

        public List<clsProducto> ProductosEncontrados
        {
            get { return _ProductosEncontrados; }
            set { _ProductosEncontrados = value; }
        }

        private List<clsPrecio> _PreciosEncontrados = new List<clsPrecio>();

        public List<clsPrecio> PreciosEncontrados
        {
            get { return _PreciosEncontrados; }
            set { _PreciosEncontrados = value; }
        }

        public frmActualizarEliminarPrecio()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (rbnDescripcion.Checked == true)
            {
                if (txtTexto.Text.Length >= 3)
                {
                    ProductosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsProducto ELEMENTO in clsProducto.ListarProductoPorDescripcion(txtTexto.Text))
                    {
                        ProductosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdProducto.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DescripcionProd);

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

        private void lstvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvDatos.SelectedItems.Count > 0)
            {
                ProductoSeleccionado = ProductosEncontrados[lstvDatos.SelectedItems[0].Index];

                PreciosEncontrados.Clear();
                lstvPrecio.Items.Clear();
                int contador = 1;
                foreach (clsPrecio ELEMENTO in clsPrecio.ListarPreciosProducto(ProductoSeleccionado.IdProducto))
                {
                    PreciosEncontrados.Add(ELEMENTO);
                    lstvPrecio.Items.Add(ELEMENTO.DescripcionMed);
                    lstvPrecio.Items[contador - 1].SubItems.Add(ELEMENTO.Precio.ToString());
                    lstvPrecio.Items[contador - 1].SubItems.Add(ELEMENTO.IdMedidaInt.ToString());

                    if (contador % 2 == 0)
                    {
                        lstvPrecio.Items[contador - 1].BackColor = Color.DarkCyan;
                    }
                    contador = contador + 1;
                }
            }

            lblIdProducto.Text = ProductoSeleccionado.IdProducto.ToString();
            txtProducto.Text = ProductoSeleccionado.DescripcionProd.ToString();
            nudPrecio.Value = 0;
            txtMedida.Clear();

        }

        private void lstvPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvPrecio.SelectedItems.Count > 0)
            {
                PrecioSeleccionado = PreciosEncontrados[lstvPrecio.SelectedItems[0].Index];
            }

            lblIdMedida.Text = PrecioSeleccionado.IdMedidaInt.ToString();
            txtMedida.Text = PrecioSeleccionado.DescripcionMed.ToString();
            nudPrecio.Value = PrecioSeleccionado.Precio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Crear un objeto de la clase clsPrecio que tenga
            //  los nuevos datos
            clsPrecio nuevoPrecio;
            nuevoPrecio = new clsPrecio(Convert.ToInt32(lblIdProducto.Text), Convert.ToInt32(lblIdMedida.Text), Convert.ToDecimal(nudPrecio.Value));
            PrecioSeleccionado.Actualizar(nuevoPrecio);
            MessageBox.Show("Datos actualizados satisfactoriamente.");

            //Bloquear todo
            btnGuardar.Visible = false;
            btnActualizarPrecio.Visible = true;
            txtTexto.Clear();
            nudPrecio.Enabled = false;
            //limpiar
            lstvPrecio.Items.Clear();
            txtProducto.Clear();
            txtMedida.Clear();
            nudPrecio.Value = 0;
        }

        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            if (txtProducto.TextLength == 0)
            {
                MessageBox.Show("Selecciona un dato.");
            }
            else
            {
                nudPrecio.Enabled = true;
                btnActualizarPrecio.Visible = false;
                btnGuardar.Visible = true;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtProducto.Clear();
            txtMedida.Clear();
            nudPrecio.Value = 0;

        }

        private void rbnDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            BotonBuscar();
        }

        private void rbnId_CheckedChanged(object sender, EventArgs e)
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
                    ProductosEncontrados.Clear();
                    lstvDatos.Items.Clear();
                    int contador = 1;
                    foreach (clsProducto ELEMENTO in clsProducto.ListarProductoPorId(Convert.ToInt32(txtTexto.Text)))
                    {
                        ProductosEncontrados.Add(ELEMENTO);
                        lstvDatos.Items.Add(ELEMENTO.IdProducto.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DescripcionProd);

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
