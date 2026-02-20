using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace ProjetoWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Venda { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime birthDate, double baseSalary, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departamento = departamento;
        }

        public void AddRegistroVenda(RegistroVenda rv)
        {
            Venda.Add(rv);
        }

        public void RemoveRegistroVenda(RegistroVenda rv)
        {
            Venda.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Venda.Where(rv => rv.Date >= inicio && rv.Date <= final).Sum(rv => rv.Amount);
        }
    }
}
