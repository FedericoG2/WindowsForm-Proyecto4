using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Se ingresa un importe (tipo float)
//Se ingresa la cantidad de artículos (tipo int o float)
//Se calcula el descuento:
//-Si el importe es menor o igual a 10000 No hay descuento
//-Si el importe es mayor a 10000 y la cantidad de artículos es menor o igual a 5 el descuento es del 10%
//-Si el importe es mayor a 10000 y la cantidad de artículos es mayor a 5 y menor a 10 el descuento es del 15%
//-Si el importe es mayor a 50000 y la cantidad de artículos es mayor o igual a 10 el descuento es del 20%

//Con esas condiciones se obtiene el % de descuento y el valor del descuento
//Finalmente se calcula el Total:
//Total = Importe - Descuento
//Mostrar los 3 valores calculados

namespace EjerSp1
{
    public partial class Form1 : Form
    {
        float importe;
        int cantidadArticulos;
        float descuento;
        string porcentaje;
        float total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Valor de importe que pone el usuario
            
            importe = float.Parse(txtImporte.Text); //Los valores de una caja son de tipo string entonces lo paso a float

            //Valor de articulos que pone el usuario
            cantidadArticulos = int.Parse(txtCantidad.Text);

            if (importe <= 10000)
            {
                descuento = 0; //Cantidad de descuento
                porcentaje = "0%"; // Porcentaje de descuento para la etiqueta
                total = importe;

            }

            if (importe > 50000 && cantidadArticulos >= 10) 
            {
                descuento = importe * 0.20f; //Cantidad de descuento
                porcentaje = "20%"; // Porcentaje de descuento para la etiqueta
                total = importe - descuento;
               
            }

            if (importe > 10000 && cantidadArticulos <= 5)
            {
                descuento = importe * 0.1f; //Cantidad de descuento
                porcentaje = "10%"; // Porcentaje de descuento para la etiqueta
                total = importe - descuento;

            }
            if (importe > 10000 && (cantidadArticulos > 5 && cantidadArticulos < 10)) 
            {
                descuento = importe *  0.15f; //Cantidad de descuento
                porcentaje = "15%"; // Porcentaje de descuento para la etiqueta
                total = importe - descuento;

            }


            // Etiqueta con el valor de porcentaje
            txtPorcentaje.Text = porcentaje;

            //Etiqueta con el valor de descuento 
            txtDescuento.Text = descuento.ToString();

            //Etiqueta con el valor de total 
            txtTotal.Text = total.ToString();


        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
           if(txtImporte.Text == "")
            {
                btnCalcular.Enabled = false;
            } else
            {
                btnCalcular.Enabled= true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
        }
    }
}
