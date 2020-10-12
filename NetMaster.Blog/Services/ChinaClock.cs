using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Services
{
    public class ChinaClock : IClock
    {
        public DateTime Clock()
        {
            return DateTime.Now;
        }
    }
}
