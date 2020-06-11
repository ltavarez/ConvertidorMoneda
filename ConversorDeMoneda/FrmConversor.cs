using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using ConversorDeMoneda.CustomControlItem;

namespace ConversorDeMoneda
{
    public partial class FrmConversor : Form
    {

        private bool isLoad { get; set; } = true;
        public FrmConversor()
        {
            InitializeComponent();
        }

        #region Eventos

        private void FrmConversor_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            isLoad = false;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            ConvertirMonedas();
        }

        private void cbxMonedaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                ConvertirMonedas();
            }
           
        }

        private void cbxMonedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                ConvertirMonedas();
            }
        }

        #endregion

        #region LogicaEventos

        private void ConvertirMonedas()
        {
            try
            {
                ComboBoxItem seleccionadoOrigen = cbxMonedaOrigen.SelectedItem as ComboBoxItem;
                ComboBoxItem seleccionadoDestino = cbxMonedaDestino.SelectedItem as ComboBoxItem;

                if (seleccionadoOrigen.Value == null)
                {
                    MessageBox.Show("Debe selecionar una moneda de origen", "Advertencia");
                }
                else if (seleccionadoDestino.Value == null)
                {
                    MessageBox.Show("Debe selecionar una moneda de destino", "Advertencia");
                }
                else if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
                {
                    MessageBox.Show("Debe colocar una cantidad", "Advertencia");
                }
                else
                {
                    Conversor conversor = new Conversor();

                    double conversion = conversor.Convertir(Convert.ToInt32(seleccionadoOrigen.Value),
                        Convert.ToInt32(seleccionadoDestino.Value), Convert.ToDouble(txtCantidad.Text));

                    txtResultado.Text = conversion.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Debe colocar una cantidad numerica", "Advertencia");
            }
        }

        private void LoadComboBox()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = null
            };


            ComboBoxItem pesoOpcion = new ComboBoxItem
            {
                Text = "Pesos dominicanos (DOP)",
                Value = (int)Monedas.PESOS
            };

            ComboBoxItem dolarOpcion = new ComboBoxItem
            {
                Text = "Dolar(USD)",
                Value = (int)Monedas.DOLAR
            };

            ComboBoxItem euroOpcion = new ComboBoxItem
            {
                Text = "Euro(EUR)",
                Value = (int)Monedas.EURO
            };

            cbxMonedaOrigen.Items.Add(opcionPorDefecto);
            cbxMonedaOrigen.Items.Add(pesoOpcion);
            cbxMonedaOrigen.Items.Add(dolarOpcion);
            cbxMonedaOrigen.Items.Add(euroOpcion);
            cbxMonedaOrigen.SelectedItem = opcionPorDefecto;

            cbxMonedaDestino.Items.Add(opcionPorDefecto);
            cbxMonedaDestino.Items.Add(pesoOpcion);
            cbxMonedaDestino.Items.Add(dolarOpcion);
            cbxMonedaDestino.Items.Add(euroOpcion);
            cbxMonedaDestino.SelectedItem = opcionPorDefecto;
        }


        #endregion

        
    }
}
