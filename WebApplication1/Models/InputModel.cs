using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class InputModel
    {
        public int MyProperty1 { get; set; }

        public List<Class1InputModel> MyList { get; set; }

        public string SomeAggregateProp { get; set; }
    }
}