using ProjetoWebMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoWebMVC.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; } // Valor da venda    
        public StatusVendedor Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {
        }

        public RegistroVenda(int id, DateTime date, double amount, StatusVendedor status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
