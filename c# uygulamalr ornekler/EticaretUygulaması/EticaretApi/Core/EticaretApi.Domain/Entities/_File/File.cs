using EticaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities._File
{
    public class File :BaseEntity
    {
        public string FileName{ get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }

        [NotMapped]//bu nu ekleme burada dıger kısımları eklıyebılırsın dedık burada
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }


    }
}
