using Lab.Demo.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class LogicBase
    {
        protected NorthwindContext context;

        public LogicBase()
        {
            context = new NorthwindContext();
        }
    }
}
