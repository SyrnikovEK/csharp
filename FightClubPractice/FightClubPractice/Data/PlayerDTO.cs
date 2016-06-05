using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Data
{
    public class PlayerDTO
    {       
        public int PlayerDTOId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Hp { get; set; }
        public int Straight { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
    }
}
