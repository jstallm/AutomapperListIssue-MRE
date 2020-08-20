using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class OuterDest
    {
        public int ID { get; set; }

        public List<OuterDestListItem> List { get; set; }
    }
    public class OuterDestListItem
    {
        public string Name { get; set; }

        public string Desc { get; set; }

        public int MyParentID { get; set; }

    }
}
