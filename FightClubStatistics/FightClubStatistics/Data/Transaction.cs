using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public User User { get; set; }
        public decimal Sum { get; set; }
    }
}
