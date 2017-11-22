using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus.bus
{
    public class nhiemvubus
    {
        public IRepository<nhiemvu> db;
        public nhiemvubus()
        {
            db = new GenericRepository<nhiemvu>();
        }
    }
}
