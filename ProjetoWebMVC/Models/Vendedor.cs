using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;

namespace ProjetoWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Sálario base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Venda { get; set; } = new List<RegistroVenda>();
        public int DepartamentoId { get; set; }

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
