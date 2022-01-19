using System;
using System.Globalization;
using System.Collections.Generic;
using Treinamento2.Enuns;

namespace Treinamento2
{
    class Program
    {
        //MATRIZES 
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; i++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }*/

            //ENUMERAÇÕES
            /* Pedidos pedido = new Pedidos
             {
                 Id = 1080,
                 Momento = DateTime.Now,
                 Status = PedidoStatus.AguardandoPagamento
             };
             Console.WriteLine(pedido);

             string txt = PedidoStatus.AguardandoPagamento.ToString();

             PedidoStatus os = Enum.Parse<PedidoStatus>("Entregue");

             Console.WriteLine(txt);
             Console.WriteLine(os);*/

            /*Console.WriteLine("Informe o nome do departamento: ");
            string nomeDepart = Console.ReadLine();
            Console.WriteLine("Informe os dados do trabalhador: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Nivel (Junior/MidLevel/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.WriteLine("Salario Base:");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(nomeDepart);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);

            Console.WriteLine("Quantos contratos para esse trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com o contrato #{i}: ");
                Console.WriteLine("Data (DO/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());

                Contratos contrato = new Contratos(data, valorPorHora, horas);
                trabalhador.AdicionarContrato(contrato);
            }
            Console.WriteLine();
            Console.WriteLine("Entre com o mês e ano para calcular o ganho (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Nome: "+ trabalhador.Nome);
            Console.WriteLine("Departamento: "+ trabalhador.Departamento.Nome);
            Console.WriteLine("Ganho total: "+ trabalhador.Income(ano, mes));*/

            /*List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter product data #{i}: ");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.WriteLine("ManufactureDate: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    Console.WriteLine("CustomsFee: ");
                    double taxa = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, taxa));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }*/

            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.WriteLine("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.WriteLine("Wigth: ");
                    double wigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(wigth, heigth, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

            }
        }

    }
}
