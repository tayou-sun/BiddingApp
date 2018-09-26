using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using BiddingApp.DataAccess.Contracts;

namespace BiddingApp.DataAccess.Repository
{
    public class BiddingRepository : IRepository<Bidding>
    {

        private readonly DatabaseContext _databaseContext;

        public BiddingRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ICollection<Bidding> GetAll()
        {
            return _databaseContext.Bidding?.ToList();
        }

        public Bidding Get(int id)
        {
            return _databaseContext.Bidding.Find(id);
        }

        public void Create(Bidding item)
        {
            _databaseContext.Bidding.Add(item);
            _databaseContext.SaveChanges();
        }

        public void Update(Bidding item)
        {
            _databaseContext.Bidding.Attach(item);
            _databaseContext.SaveChanges();
        }

        public void Delete(Bidding item)
        {
            _databaseContext.Bidding.Remove(item);
            _databaseContext.SaveChanges();
        }
    }
}

