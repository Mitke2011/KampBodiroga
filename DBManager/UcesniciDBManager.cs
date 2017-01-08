using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class UcesniciDBManager : DBManagerPrototype
    {
        string tableName;
        string[] columns = new string[]();
        public UcesniciDBManager(string connectionString)
            : base(connectionString)
        {

        }

        public override void Save(object o)
        {

            string sql = string.Format("insert into {0} {1} values {2}",tableName, columns,valueArray);
            this.command.CommandText = sql;
        }

        public override void Delete(object o)
        {
           
        }

        public override object GetOne(int Id)
        {
            throw new NotImplementedException();
        }

        public override List<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
