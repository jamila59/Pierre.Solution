using System.Collections.Generic;

namespace Pierre.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }

        public ICollection<FlavorTreat> Flavors { get;}
    }
}