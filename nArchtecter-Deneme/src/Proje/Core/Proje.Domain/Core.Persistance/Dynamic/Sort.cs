using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Dynamic
{
    public class Sort
    {
        public string Field { get; set; } //ozellik
        public string Dir { get; set; } //desc asc
        public Sort()
        {
            Field = string.Empty;
            Dir = string.Empty;
        }
        public Sort(string field, string dir)
        {
            Field = field;
            Dir = dir;
        }
    }
}
