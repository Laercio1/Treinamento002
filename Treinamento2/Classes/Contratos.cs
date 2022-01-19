using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2
{
    class Contratos
    {
        public DateTime Data {get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public Contratos()
        { 
        }

        public Contratos(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}
