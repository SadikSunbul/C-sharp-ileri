using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
	public class Customer : BaseEntity
	{
		public string İsim { get; set; }
		public string Soyisim { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public ICollection<Order> Orders { get; set; }
		public ICollection<Basket> Baskets { get; set; }
		public ICollection<Like> foods { get; set; }
		public ICollection<Payment> Payments { get; set; }

	}
}
