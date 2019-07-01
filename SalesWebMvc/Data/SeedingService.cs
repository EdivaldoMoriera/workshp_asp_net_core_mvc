using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        //responsavel por popular a base de dados.
        public void Seed()
        {
            if (_context.Department.Any() ||//se ja existir dados na tabela nao faz nada return para corta a aplicacao
                _context.Seller.Any() ||
                _context.SaleRecord.Any())
            {
                return;// o banco de dados já foi popuçado
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashios");
            Department d4 = new Department(4, "Books");
            Seller s1 = new Seller(1, "Bob Brow", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.00, d1);
            Seller s2 = new Seller(2, "Pedro Camara", "pedro@gmail.com", new DateTime(2000, 3, 21), 2000.00, d2);
            Seller s3 = new Seller(3, "Ezequiel Moreira", "ezequiel@gmail.com", new DateTime(2001, 4, 14), 3000.00, d3);
            Seller s4 = new Seller(4, "Andrew Moreira", "andrew@gmail.com", new DateTime(2011, 4, 11), 5000.00, d4);
            Seller s5 = new Seller(5, "Caua Moreira", "caua@hotmail.com", new DateTime(2001, 01, 25), 3000.00, d4);
            Seller s6 = new Seller(6, "Telcy Amador", "telcy@amador", new DateTime(1984, 01, 04), 10000.00, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 4, 21), 1222.00, SalesStatus.billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 4, 26), 2000.00, SalesStatus.billed, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 5, 22), 2323.00, SalesStatus.billed, s6);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 4, 25), 2323.00, SalesStatus.billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 7, 24), 1212.00, SalesStatus.billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 9, 12), 1000.00, SalesStatus.pending, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 9, 3), 1000.00, SalesStatus.cancel, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 2, 12), 1000.00, SalesStatus.billed, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 2, 23), 1000.00, SalesStatus.billed, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 7, 6), 1000.00, SalesStatus.billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 8, 26), 1000.00, SalesStatus.billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 11, 26), 1000.00, SalesStatus.billed, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 2, 26), 1000.00, SalesStatus.billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 9, 28), 1000.00, SalesStatus.billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 9, 21), 1000.00, SalesStatus.billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 3, 21), 1000.00, SalesStatus.billed, s1);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 3, 21), 1000.00, SalesStatus.billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 6, 21), 1000.00, SalesStatus.billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 2, 21), 1000.00, SalesStatus.billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 4, 21), 1000.00, SalesStatus.billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SaleRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20);

            _context.SaveChanges();





        }

    }
}
