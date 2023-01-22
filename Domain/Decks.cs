using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Decks
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int BossesId { get; set; }
        public int CardsId { get; set; }
        public Bosses? Bosses { get; set; }
        public Cards? Cards { get; set; }

    }
}