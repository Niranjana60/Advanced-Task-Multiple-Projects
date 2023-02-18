using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Pages
{
    public class ExtentManager
    {
        
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extentReports;

        private ExtentManager()
        {

        }

        public static ExtentReports getInstance()
        {
            if (extentReports == null)
            {

                String reportpath = @"D:\mvpstudio\vscode\repos\mvpstudio\Advanced Task\ExtentReports\Reports.html";
                htmlReporter = new ExtentHtmlReporter(reportpath);
                extentReports = new ExtentReports();
                extentReports.AttachReporter(htmlReporter);
                extentReports.AddSystemInfo("OS", "Windows");
                extentReports.AddSystemInfo("Host Name", "DESKTOP-TU1VJ5V");
                extentReports.AddSystemInfo("Environment", "QA");
                extentReports.AddSystemInfo("UserName", "niruradh61@gmail.com");

                string extentConfigPath = @"D:\mvpstudio\vscode\repos\mvpstudio\Advanced Task\ExtentReports\extent-config.xml";
                htmlReporter.LoadConfig(extentConfigPath);

            }
            return extentReports;
        }
    }


}
