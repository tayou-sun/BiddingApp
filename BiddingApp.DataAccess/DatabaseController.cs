
using BiddingApp.DataAccess.Repository;

namespace BiddingApp.DataAccess
{
    public class DatabaseController
    {
        private readonly DatabaseContext _databaseContext;

        public DatabaseController()
        {
            _databaseContext = new DatabaseContext();
            //Тут дергать, чтобы перестроить базу
            //_databaseContext.Database.Initialize(false);

            Bidding = new BiddingRepository(_databaseContext);
        }

        public BiddingRepository Bidding { get; private set; }

        public void Save()
        {
            
        }
    }
}