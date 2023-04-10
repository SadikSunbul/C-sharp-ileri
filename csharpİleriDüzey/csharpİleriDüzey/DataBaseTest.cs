using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpİleriDüzey
{
	public abstract class BaseDb
	{
        //ınterfacelerın ctor ları yok tur ama abstrac larda ctor var dır
        public BaseDb()
        {
            
        }
        public abstract string GetDataBaseVersıon();//interface gıbı ıcersıne bısı yazılmıycak bu sozlesme bunu kesınlıkle kullanmalıdır 
        public DataTable ExecuteSql(string sql)
        {
            //generated sql
            return new DataTable();
        }
    }
	public class SqlServerDb : BaseDb
    {
		
		public string GeneratedSql(int Id)
		{
			return $"Select *From User Where Id={Id}";
		}

        public override string GetDataBaseVersıon()
        {
            return "sqlserver 2019";
        }
    }
    public class OracleDb : BaseDb
	{
       
        public string GeneratedSql(int Id)
        {
            return $"Select *From User Where User_Id={Id}";
        }

        public override string GetDataBaseVersıon()
        {
            return "Oracle 2019";
        }
    }
}
