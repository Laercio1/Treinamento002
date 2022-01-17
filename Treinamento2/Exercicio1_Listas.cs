using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Treinamento2
{
    class Exercicio1_Listas
    {
        static void Main(string[] args)
        {
            // Fazendo um lista de informações de funcionarios
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("Informe quantos funcionários serão registrados");
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o ID do Funcionário:");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do Funcionário:");
                string Nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do salário atual do funcionário:");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(Id, Nome, Salario));
                Console.WriteLine("");
            }

            Console.WriteLine("Digite o ID do funcionário que terá aumento:");
            int procurarId = int.Parse(Console.ReadLine());
            Funcionario emp = list.Find(x => x.Id == procurarId);
            if (emp != null)
            {
                Console.WriteLine("Digite a porcentagem:");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncremetarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("O ID informado não existe!");
            }
            Console.WriteLine("");
            Console.WriteLine("Atualização da lista:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
