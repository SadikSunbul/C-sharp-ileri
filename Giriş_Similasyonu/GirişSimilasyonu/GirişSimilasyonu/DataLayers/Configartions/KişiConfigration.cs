using GirişSimilasyonu.BusinessLayer.Entityler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GirişSimilasyonu.BusinessLayer.Configartions
{
    public class KişiConfigration : IEntityTypeConfiguration<Kişi>
    {
        public void Configure(EntityTypeBuilder<Kişi> builder)
        {
            builder.UseTpcMappingStrategy();
        }
    }
}
