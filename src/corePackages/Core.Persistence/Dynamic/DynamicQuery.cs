using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic;

public class DynamicQuery
{
    public IEnumerable<Sort>? Sort  { get; set; }
    public Filter? Filter { get; set; }
    public DynamicQuery()
    {
        
    }
    public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Sort = sort;
        Filter = filter;
    }

}
// normal adonet sorgusu
//Select * from Products where unitPrice<=10000 and (category =1 or title like 'B%' 
//Entity Framework sorgusu
// p=>p.unitPrice<=10000 && (p.category=1 && p.title="B%"
