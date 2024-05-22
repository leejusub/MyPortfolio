
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalPowerMonitor.Properties;
using UniversalPowerMonitor;

namespace UniversalPowerMonitor
{
    public class DBHelper_MSSQL : DBHelper
    {
        private static DBHelper_MSSQL instance = null;

        public static DBHelper_MSSQL getInstance
        {
            get
            {
                if (instance == null)
                    instance = new DBHelper_MSSQL();
                return instance;
            }
        }

        private DBHelper_MSSQL() //private을 썼다는 건 외부에서 인스턴스 못 만듦
        {

        }


        protected override void ConnectDB()
        {
            conn.ConnectionString = $"Data Source=({"local"}); " +
                 $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn.Open();
        }

        public override void DoQuery() //select, 전체정보
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from powerplants";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "powerplants");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void DoQuery(string metro, string source)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from powerplants where metro=@metro and source=@source";
                cmd.Parameters.AddWithValue("@metro", metro);
                cmd.Parameters.AddWithValue("@source", source);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "powerplants");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void DoQuery(string metro, int year)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from powerplants where metro=@metro and year=@year order by toe desc";
                cmd.Parameters.AddWithValue("@metro", metro);
                cmd.Parameters.AddWithValue("@year", year);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "powerplants");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void DoQuerySY(string source, int year)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from powerplants where source=@source and year=@year order by toe desc";
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@year", year);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "powerplants");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }


        public override void LoadMetroComboBox()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct metro from powerplants";
                SqlDataReader reader = cmd.ExecuteReader();

                // Iterate over the results and add them to the list
                while (reader.Read())
                {
                    DataManager.metroCombobox.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void LoadSourceComboBox()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct source from powerplants";
                SqlDataReader reader = cmd.ExecuteReader();

                // Iterate over the results and add them to the list
                while (reader.Read())
                {
                    DataManager.sourceCombobox.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void LoadYearComboBox()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct year from powerplants";
                SqlDataReader reader = cmd.ExecuteReader();

                // Iterate over the results and add them to the list
                while (reader.Read())
                {
                    DataManager.yearCombobox.Add(reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
