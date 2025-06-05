using ClinicLab.Application.Models;
using ClinicLab.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicLab.Application.BusinessLogic
{
    public class InvoiceService
    {
        private readonly ClinicLabDbContext _context;

        public InvoiceService(ClinicLabDbContext context)
        {
            _context = context;
        }

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public List<Invoice> GetInvoices()
        {
            return _context.Invoices.AsNoTracking().ToList();
        }

        public List<Invoice> GetInvoicesByDateRange(DateTime fromDate, DateTime toDate)
        {
            return _context.Invoices
                .Where(i => i.InvoiceDate.Date >= fromDate && i.InvoiceDate.Date <= toDate)
                .ToList();
        }


        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            _context.SaveChanges();
        }

        public void DeleteInvoice(int id)
        {
            var invoice = _context.Invoices.Find(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }
    }
}
