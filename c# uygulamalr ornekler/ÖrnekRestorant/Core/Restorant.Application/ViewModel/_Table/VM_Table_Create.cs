using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.ViewModel._Table
{
    public class VM_Table_Create
    {

        public string TableNo { get; set; }
        public bool Reservation { get; set; }

        public int Maxpepol { get; set; }

        public static implicit operator VM_Table_Create(Table table)
        {
            return new VM_Table_Create { TableNo = table.TableNo, Reservation = table.Reservation , Maxpepol = table.Maxpeople };
        }
        public static implicit operator Table(VM_Table_Create table)
        {
            return new Table { TableNo = table.TableNo, Reservation = table.Reservation, Maxpeople=table.Maxpepol };
        }
    }
}
