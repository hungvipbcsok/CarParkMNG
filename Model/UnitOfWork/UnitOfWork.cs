using Model.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarBookingContext _context;

        public UnitOfWork(CarBookingContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
