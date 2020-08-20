using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class OuterDest
    {
        public int ID { get; set; }

        public List<OuterDestListItem> List { get; set; }
    }
}
