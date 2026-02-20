using NuGet.Protocol.Plugins;
using ProjetoWebMVC.Models;
using ProjetoWebMVC.Models.Enums;
using System;
using System.Linq;

namespace ProjetoWebMVC.Data
{
    public class SeedingService
    {
        private ProjetoWebMVCContext _context;
        public SeedingService(ProjetoWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVenda.Any())
            {
                return; // O banco de dados já foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Books");

            Vendedor v1 = new Vendedor(1, "Bob Brow", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor v2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor v3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor v4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor v5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor v6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RegistroVenda r1 = new RegistroVenda(1, new DateTime(2026, 01, 25), 11000.0, StatusVendedor.Faturado, v1);
            RegistroVenda r2 = new RegistroVenda(2, new DateTime(2026, 01, 4), 7000.0, StatusVendedor.Faturado, v5);
            RegistroVenda r3 = new RegistroVenda(3, new DateTime(2026, 01, 13), 4000.0, StatusVendedor.Cancelado, v4);
            RegistroVenda r4 = new RegistroVenda(4, new DateTime(2026, 01, 1), 8000.0, StatusVendedor.Faturado, v1);
            RegistroVenda r5 = new RegistroVenda(5, new DateTime(2026, 01, 21), 3000.0, StatusVendedor.Faturado, v3);
            RegistroVenda r6 = new RegistroVenda(6, new DateTime(2026, 01, 15), 2000.0, StatusVendedor.Faturado, v1);
            RegistroVenda r7 = new RegistroVenda(7, new DateTime(2026, 01, 28), 13000.0, StatusVendedor.Faturado, v2);
            RegistroVenda r8 = new RegistroVenda(8, new DateTime(2026, 01, 11), 4000.0, StatusVendedor.Faturado, v4);
            RegistroVenda r9 = new RegistroVenda(9, new DateTime(2026, 01, 14), 11000.0, StatusVendedor.Pendente, v6);
            RegistroVenda r10 = new RegistroVenda(10, new DateTime(2026, 01, 7), 9000.0, StatusVendedor.Faturado, v6);
            RegistroVenda r11 = new RegistroVenda(11, new DateTime(2026, 01, 13), 6000.0, StatusVendedor.Faturado, v2);
            RegistroVenda r12 = new RegistroVenda(12, new DateTime(2026, 01, 25), 7000.0, StatusVendedor.Pendente, v3);
            RegistroVenda r13 = new RegistroVenda(13, new DateTime(2026, 01, 29), 10000.0, StatusVendedor.Faturado, v4);
            RegistroVenda r14 = new RegistroVenda(14, new DateTime(2026, 01, 4), 3000.0, StatusVendedor.Faturado, v5);
            RegistroVenda r15 = new RegistroVenda(15, new DateTime(2026, 01, 12), 4000.0, StatusVendedor.Faturado, v1);
            RegistroVenda r16 = new RegistroVenda(16, new DateTime(2026, 02, 5), 2000.0, StatusVendedor.Faturado, v4);
            RegistroVenda r17 = new RegistroVenda(17, new DateTime(2026, 02, 1), 12000.0, StatusVendedor.Faturado, v1);
            RegistroVenda r18 = new RegistroVenda(18, new DateTime(2026, 02, 24), 6000.0, StatusVendedor.Faturado, v3);
            RegistroVenda r19 = new RegistroVenda(19, new DateTime(2026, 02, 22), 8000.0, StatusVendedor.Faturado, v5);
            RegistroVenda r20 = new RegistroVenda(20, new DateTime(2026, 02, 15), 8000.0, StatusVendedor.Faturado, v6);
            RegistroVenda r21 = new RegistroVenda(21, new DateTime(2026, 02, 17), 9000.0, StatusVendedor.Faturado, v2);
            RegistroVenda r22 = new RegistroVenda(22, new DateTime(2026, 02, 24), 4000.0, StatusVendedor.Faturado, v4);
            RegistroVenda r23 = new RegistroVenda(23, new DateTime(2026, 02, 19), 11000.0, StatusVendedor.Cancelado, v2);
            RegistroVenda r24 = new RegistroVenda(24, new DateTime(2026, 02, 12), 8000.0, StatusVendedor.Faturado, v5);
            RegistroVenda r25 = new RegistroVenda(25, new DateTime(2026, 02, 21), 7000.0, StatusVendedor.Faturado, v3);
            RegistroVenda r26 = new RegistroVenda(26, new DateTime(2026, 02, 6), 5000.0, StatusVendedor.Faturado, v4);
            RegistroVenda r27 = new RegistroVenda(27, new DateTime(2026, 02, 13), 9000.0, StatusVendedor.Pendente, v1);
            RegistroVenda r28 = new RegistroVenda(28, new DateTime(2026, 02, 7), 4000.0, StatusVendedor.Faturado, v3);
            RegistroVenda r29 = new RegistroVenda(29, new DateTime(2026, 02, 23), 12000.0, StatusVendedor.Faturado, v5);
            RegistroVenda r30 = new RegistroVenda(30, new DateTime(2026, 02, 12), 5000.0, StatusVendedor.Faturado, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4); 

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6); 

            _context.RegistroVenda.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
