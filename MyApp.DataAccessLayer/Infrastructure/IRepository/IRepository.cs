using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
    public class IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}
