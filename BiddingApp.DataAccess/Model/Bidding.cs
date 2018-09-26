using System;
using System.Collections.Generic;
using System.Text;

namespace BiddingApp.DataAccess
{
    public class Bidding
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatingDate { get; set; }
        public int Author { get; set; }
    }
}
