using Library_2.DAL;
using Library_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Repozitory
{
    public class DebitRepozitory
    {
        private DatabaseContext _databaseContext;
        public DebitRepozitory(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public  List<Debit> GetDebits()
        {
            var Debits = new List<Debit>();
            Debits = _databaseContext.Debits.ToList();
            return Debits;
        }
        public void AddDebit(Debit debit)
        {
            _databaseContext.Debits.Add(debit);
            _databaseContext.SaveChanges();
        }
        public void DeleteDebit(Debit debit)
        {
            _databaseContext.Debits.Remove(debit);
            _databaseContext.SaveChanges();
        }
        public void UpdateDebit(Debit updateDebit)
        {
            var temp = _databaseContext.Debits.FirstOrDefault(item => item.Id == updateDebit.Id);
            if (temp != null)
            {
                //temp.Id = updateDebit.Id;
                temp.BookId = updateDebit.BookId;
                temp.UserId = updateDebit.UserId;
                _databaseContext.SaveChanges();
            }
        }
    }
}
