using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Conversor
    {

        public double Convertir(int monedaOrigen, int monedaDestino, double cantidadConvertir)
        {
            double cantidadConvertida = 0;
            switch (monedaOrigen)
            {
                case (int)Monedas.PESOS:
                    switch (monedaDestino)
                    {
                        case (int)Monedas.DOLAR:
                            cantidadConvertida = cantidadConvertir * 0.017;
                            break;
                        case (int)Monedas.EURO:
                            cantidadConvertida = cantidadConvertir * 0.015;
                            break;
                        case (int)Monedas.PESOS:
                            cantidadConvertida = cantidadConvertir;
                            break;
                    }
                    break;

                case (int)Monedas.DOLAR:
                    switch (monedaDestino)
                    {
                        case (int)Monedas.PESOS:
                            cantidadConvertida = cantidadConvertir * 58.13;
                            break;
                        case (int)Monedas.EURO:
                            cantidadConvertida = cantidadConvertir * 0.88;
                            break;
                        case (int)Monedas.DOLAR:
                            cantidadConvertida = cantidadConvertir;
                            break;
                    }
                    break;
                case (int)Monedas.EURO:
                    switch (monedaDestino)
                    {
                        case (int)Monedas.PESOS:
                            cantidadConvertida = cantidadConvertir * 66.09;
                            break;
                        case (int)Monedas.DOLAR:
                            cantidadConvertida = cantidadConvertir * 1.14;
                            break;
                        case (int)Monedas.EURO:
                            cantidadConvertida = cantidadConvertir;
                            break;
                    }
                    break;
            }

            return cantidadConvertida;
        }
    }
}
