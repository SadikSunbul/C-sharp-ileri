using Restorant.Application.Repositorys._Payment;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Payment
{
	public class PaymentReadRepository : ReadRepository<Payment>, IPaymentReadRepository
	{
		public PaymentReadRepository(RestorantDbContext context) : base(context)
		{
		}
	}
}
