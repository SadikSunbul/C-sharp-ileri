using Restorant.Domain.Entiteis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Domain.Entiteis
{
	public class Payment:BaseEntity
	{
        public Guid CustoemrId { get; set; }
        
        public string Masano { get; set; }
		public string İsim { get; set; }
		public string Soyisim { get; set; }
		public string KartNo { get; set; }
		public string SonKullanımTarih { get; set; }
		public string cvv { get; set; }
		public double TotalPrice { get; set; } = 0;
        public ICollection<Food> Foods { get; set; }
        public Customer Custoemr { get; set; }
        

    }
}
