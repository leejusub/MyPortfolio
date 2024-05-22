using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalPowerMonitor
{
    public abstract class DBHelper
    {
        //enum CRUD { INSERT, UPDATE, DELETE }
        //enum POWERPLANTS_ARGS { METRO, DISTRICT, SOURCE }
        protected SqlConnection conn = new SqlConnection();
        protected SqlDataAdapter da;
        protected DataSet ds;
        public DataTable dt;
        //public static SqlDataReader reader;
        protected abstract void ConnectDB();
        public abstract void DoQuery(); //select용, 전체
        public abstract void DoQuery(string metro, string source); //select용
        public abstract void DoQuery(string metro, int year); //select용
        public abstract void DoQuerySY(string source, int year); //select용
        public abstract void LoadMetroComboBox(); //metroComboBox 로드용
        public abstract void LoadSourceComboBox(); //sourceComboBox 로드용
        public abstract void LoadYearComboBox(); //yearComboBox 로드용
        //public abstract void DoQuery(string args1, string args2, ENERGY_ARGS.METRO, ENERGY_ARGS.DISTRICT); //select용
        //public abstract void DoQuery(User user); //update insert delete용
    }
}
