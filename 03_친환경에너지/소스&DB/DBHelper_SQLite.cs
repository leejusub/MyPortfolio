using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalPowerMonitor
{
    public class DBHelper_SQLite
    {
        private string databaseDirectory = @"C:\Database";
        private string databaseFileName = "PUBLIC_DATA.db";
        public string DatabasePath => Path.Combine(databaseDirectory, databaseFileName);

        MainForm mainForm;

        public DBHelper_SQLite()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                // 디렉토리 생성
                if (!Directory.Exists(databaseDirectory))
                {
                    Directory.CreateDirectory(databaseDirectory);
                }
            }
            catch
            {
                string offlineDBDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Database");
                DialogResult dialog = MessageBox.Show(Properties.Resources.App_ErrorMessage_Content_OfflineDBDirFault+"\n"+offlineDBDir,
                    Properties.Resources.App_ErrorMessage_Title_FatalError, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            // .db 파일이 원본 위치에서 복사되어야 하는 경우 여기에 로직 추가
        }

        public void CopyDatabaseFile(string sourcePath)
        {
            string destPath = DatabasePath;
            try
            {
                if (!File.Exists(destPath))
                {
                    File.Copy(sourcePath, destPath, overwrite: false);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(Properties.Resources.App_ErrorMessage_Content_CopyDBFileFault+"\n"+ex.Message,
                    Properties.Resources.App_ErrorMessage_Title_FatalError, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(DialogResult.Retry == dialog)
                {
                    CopyDatabaseFile(sourcePath);
                }
            }
        }

        public DataTable LoadData(string query)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={DatabasePath};Version=3;"))
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // 예외 처리
                    throw new Exception("데이터를 불러오는 중 오류가 발생했습니다.", ex);
                }
                return dt;
            }
        }

        public List<string> LoadMetroData()
        {
            List<string> metroData = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={DatabasePath};Version=3;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT METRO FROM POWER_PLANTS ORDER BY METRO"; // "metro" 컬럼의 고유 값 불러오기
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string metroValue = reader.GetString(0); // 첫 번째 컬럼의 값을 읽음
                            if (!string.IsNullOrEmpty(metroValue))
                            {
                                metroData.Add(metroValue);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 예외 처리
                    throw new Exception("metro 데이터를 불러오는 중 오류가 발생했습니다.", ex);
                }
            }
            return metroData;
        }
    }
}
