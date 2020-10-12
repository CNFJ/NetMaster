using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Services
{
   public interface IClock
    {
        DateTime Clock();
    }
}
