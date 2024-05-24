using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; }
    public string Value { get; set; }
    public string Operator { get; set; }
    public int MyProperty { get; set; }
}
