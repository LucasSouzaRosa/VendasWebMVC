using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using VendasWebMVC.Models.Enums;
namespace VendasWebMVC.Data
{
    public class PopularTabelas
    {
        private VendasWebMVCContext _context;

        public PopularTabelas(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Alimentar()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any())
            {
                return; // banco já está alimentado
            }

            Departamento d1 = new Departamento(2, "Perfumaria");
            Departamento d2 = new Departamento(3, "Casa, mesa e banho");
            Departamento d3 = new Departamento(4, "Roupas");
            Departamento d4 = new Departamento(5, "Camping");

            Vendedor v1 = new Vendedor(1, "Lucas Rosa", "lucasrosa@gmail.com", new DateTime(1996, 02, 21), 2700, d4);
            Vendedor v2 = new Vendedor(2, "Flávia Rosa", "fláviarosa@gmail.com", new DateTime(1986, 12, 30), 8700, d2);
            Vendedor v3 = new Vendedor(3, "Mário Rosa", "mariorosa@gmail.com", new DateTime(1993, 12, 04), 9700, d3);
            Vendedor v4 = new Vendedor(4, "Rafaela Rosa", "rafarosa@gmail.com", new DateTime(1995, 11, 25), 4700, d1);


            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, v1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, v3);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Faturado, v4);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, v1);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Pendente, v3);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, v1);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, v2);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, v4);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Cancelado, v2);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, v2);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Cancelado, v2);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Faturado, v3);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Cancelado, v4);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Faturado, v2);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Faturado, v1);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Faturado, v4);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Faturado, v1);
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Faturado, v3);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Faturado, v3);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Faturado, v2);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Faturado, v2);
            RegistroVendas r22 = new RegistroVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Faturado, v4);
            RegistroVendas r23 = new RegistroVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Faturado, v2);
            RegistroVendas r24 = new RegistroVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Faturado, v4);
            RegistroVendas r25 = new RegistroVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Faturado, v3);
            RegistroVendas r26 = new RegistroVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Faturado, v4);
            RegistroVendas r27 = new RegistroVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Faturado, v1);
            RegistroVendas r28 = new RegistroVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Faturado, v3);
            RegistroVendas r29 = new RegistroVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Faturado, v2);
            RegistroVendas r30 = new RegistroVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Faturado, v2);


            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4);
            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19,
                r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
