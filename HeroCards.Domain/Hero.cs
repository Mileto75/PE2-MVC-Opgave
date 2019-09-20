using System.Collections.Generic;

namespace HeroCards.Domain
{
    public class Hero
    {
        public string Name { get; set; }
        public Race Race { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Magic { get; set; }
        public string Image { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}
