using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class OuterSource
    {
        public int ID { get; set; }

        public List<OuterSourceListItem> List { get; set; }

        public string OuterSourceProp1 { get; set; }// Notice how you can have prop on source which is not on dest, no complaints from AutoMapper there
    }
}