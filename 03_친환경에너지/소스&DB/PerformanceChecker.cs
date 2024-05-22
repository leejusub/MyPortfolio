using System;
using System.Management;

namespace UniversalPowerMonitor
{
    public class PerformanceChecker
    {
        public int GetEstimatedChargeRemaining()
        {
            // WMI 클래스 및 인스턴스 가져오기
            var wmi = new ManagementClass("Win32_Battery");
            var allBatteries = wmi.GetInstances();

            // 배터리 정보 추출
            foreach (var battery in allBatteries)
            {
                return Convert.ToInt32(battery["EstimatedChargeRemaining"]);
            }

            // 배터리가 없는 경우
            return 0;
        }

        public int GetEstimatedRunTime()
        {
            // WMI 클래스 및 인스턴스 가져오기
            var wmi = new ManagementClass("Win32_Battery");
            var allBatteries = wmi.GetInstances();

            // 배터리 정보 추출
            foreach (var battery in allBatteries)
            {
                return Convert.ToInt32(battery["EstimatedRunTime"]);
            }

            // 배터리가 없는 경우
            return 0;
        }
    }
}
