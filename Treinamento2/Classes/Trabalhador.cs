using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contratos> Contratoss { get; private set; } = new List<Contratos>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(Contratos contrato)
        {
            Contratoss.Add(contrato);
        }
        public void RemoverContrato(Contratos contrato)
        {
            Contratoss.Remove(contrato);
        }
        public double Income(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (Contratos contrato in Contratoss)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {

                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
