using System;
using System.Globalization;
namespace ListaDeExercicios09
{
    internal class Empregado
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salario { get; private set; }

        public Empregado(int id, string name, double salario) 
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.00);
        }
        public override string ToString()
        {
            return $"{Id}, {Name}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
