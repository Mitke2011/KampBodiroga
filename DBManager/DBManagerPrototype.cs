using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DBManager
{
    public abstract class DBManagerPrototype
    {
        public SqlCommand command;
        public SqlConnection connection;

        public abstract void Save(object o);
        public abstract void Delete(object o);
        public abstract object GetOne(int Id);
        public abstract List<object> GetAll();

        
        public DBManagerPrototype(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }
    }
}
