using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic;

public class Filter
{
    /// <summary>
    /// sorguya konu olacak filreler burada olacak
    /// </summary>
    public string Field { get; set; }
    public string? Value { get; set; }
    public string Operator { get; set; }
    public string? Logic { get; set; }
    public IEnumerable<Filter> Filters  { get; set; }
    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }
    public Filter(string field, string @operator)
    {
        // operator kelimesi c# var olduğu için kullanamazsın diyor. Kullanmak için 
        // başına @ işareti koyuyoruz. @operator
        Field = field;
        Operator = @operator;
       
    }
}
