using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Contract
{
    interface ICRUD<T>
    {
         int Create(T obj1);
         int Update(T obj1);
         T List();
         int Delete(T obj1);

    }
}
