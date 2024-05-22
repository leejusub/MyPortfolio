using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalPowerMonitor
{
    public class DataManager
    {
        public static List<PowerPlants> ppList = new List<PowerPlants>();
        public static List<string> metroCombobox = new List<string>();
        public static List<string> sourceCombobox = new List<string>();
        public static List<int> yearCombobox = new List<int>();
        private static DBHelper_MSSQL mssql = DBHelper_MSSQL.getInstance; //싱글톤

        static DataManager() { Load(); }

        public static void Load() //전체 불러오기
        {
            try
            {
                mssql.DoQuery(); // 전체 조회
                ppList.Clear(); // ppList 초기화
                foreach (DataRow item in mssql.dt.Rows)
                {
                    PowerPlants pp = new PowerPlants();
                    pp.metro = item["metro"].ToString();
                    //pp.district = item["district"].ToString();
                    pp.source = item["source"].ToString();
                    pp.toe = (int)item["toe"];
                    pp.MWh = (int)item["MWh"];
                    pp.kWTotal = (int)item["kWTotal"];
                    //pp.kWNew = (int)item["kWNew"];
                    ppList.Add(pp);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //printLog(ex.StackTrace + " from Load ");
            }
        }

        public static void GetMetroComboBox() // 메트로 콤보박스 값 받아오기
        {
            mssql.LoadMetroComboBox();
        }

        public static void GetSourceComboBox() // 발전원 콤보박스 값 받아오기
        {
            mssql.LoadSourceComboBox();
        }

        public static void GetYearComboBox() // 년도 콤보박스 값 받아오기
        {
            mssql.LoadYearComboBox();
        }

        public static void GetPartData(string metro, string source)
        {
            try
            {
                mssql.DoQuery(metro, source); // 특정 값 조회
                ppList.Clear(); //ppList 초기화                
                foreach (DataRow item in mssql.dt.Rows)
                {
                    PowerPlants pp = new PowerPlants();
                    pp.metro = item["metro"].ToString();
                    //pp.district = item["district"].ToString();
                    pp.source = item["source"].ToString();
                    pp.year = (int)item["year"];
                    pp.toe = (int)item["toe"];
                    pp.MWh = (int)item["MWh"];
                    pp.kWTotal = (int)item["kWTotal"];
                    //pp.kWNew = (int)item["kWNew"];

                    ppList.Add(pp);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //printLog(ex.StackTrace + " from Load ");
            }
        }

        public static void GetPartData(string metro, int year)
        {
            try
            {
                mssql.DoQuery(metro, year); // 특정 값 조회
                ppList.Clear(); //ppList 초기화                
                foreach (DataRow item in mssql.dt.Rows)
                {
                    PowerPlants pp = new PowerPlants();
                    pp.metro = item["metro"].ToString();
                    pp.source = item["source"].ToString();
                    pp.year = (int)item["year"];
                    pp.toe = (int)item["toe"];
                    pp.MWh = (int)item["MWh"];
                    pp.kWTotal = (int)item["kWTotal"];
                    ppList.Add(pp);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }

        public static void GetPartDataSY(string source, int year)
        {
            try
            {
                mssql.DoQuerySY(source, year); // 특정 값 조회
                ppList.Clear(); //ppList 초기화                
                foreach (DataRow item in mssql.dt.Rows)
                {
                    PowerPlants pp = new PowerPlants();
                    pp.metro = item["metro"].ToString();
                    pp.source = item["source"].ToString();
                    pp.year = (int)item["year"];
                    pp.toe = (int)item["toe"];
                    pp.MWh = (int)item["MWh"];
                    pp.kWTotal = (int)item["kWTotal"];
                    ppList.Add(pp);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }

    }
}
