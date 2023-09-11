using EticaretApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        //T sadece sınıf olması lazım cunku dbset sadece sınıf alır ıcıne where T : class
        DbSet<T> Table { get; }
    }
}
