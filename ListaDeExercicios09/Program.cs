using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ListaDeExercicios09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> empregados = new List<Empregado>();

            Console.Write("Quantos empregados vão ser registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmpregado #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregados.Add(new Empregado(id, name, salario));
            }

            Console.Write("\nDigite o Id do empregado que recebera aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Empregado emp = empregados.Find(x => x.Id == idAumento);
            if (emp != null)
            {
                Console.Write("Digite a porcentagem: ");
                emp.Aumento(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Id inexistente!");
            }

            Console.WriteLine("\nLista de Empregados");
            foreach (Empregado obj in empregados)
            {
                Console.WriteLine(obj);
            }
        }
    }
}