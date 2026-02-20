using ProjetoWebMVC.Models.Enums;
using System;

namespace ProjetoWebMVC.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
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
