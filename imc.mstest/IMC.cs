using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace imc.mstest
{
    public class IMC
    {
        public double peso;
        public double altura;
        public double imc;

        public string? categoria;

        public void Calcular_IMC()
        {
            imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);
        }
        public void Classificar_IMC()
        {
            if (imc < 18.25)
            {
                categoria = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                categoria = "Peso normal";
            }
            else if (imc < 30)
            {
                categoria = "Sobrepeso";
            }
            else if (imc < 35)
            {
                categoria = "Obesidade de grau I";

            }
            else if (imc < 40)
            {
                categoria = "Obesidade de grau II";

            }
            else
            {
                categoria = "Obesidade de grau III";

            }
        }
    }
}