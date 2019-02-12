using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb.Models;
using SalesWeb.Models.Enums;


namespace SalesWeb.Data
{
    public class SeedingService
    {
        private SalesWebContext _context;

        public SeedingService(SalesWebContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail", new DateTime(1979, 4, 21), 1000.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "bob@gmail", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail", new DateTime(1998, 4, 21), 1000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail", new DateTime(2000, 4, 21), 1000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail", new DateTime(1997, 3, 4), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s2, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);

            _context.SaveChanges();
        }

    }

}
