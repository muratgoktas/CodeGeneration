using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic;

public class Sort
{
    public string Field { get; set; }
    public string Dir { get; set; } // A-Z ye mi sort etsin, Z-A ya mı için demek Direction yeni
    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }
    public Sort(string field, string dir)
    {
        Field = Field;
        Dir = dir;
    }


}
