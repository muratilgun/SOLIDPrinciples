using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.SingleResponsibilityPrinciple.Model;

namespace SOLID.SingleResponsibilityPrinciple.Good
{
    public class GoodEmployeeProcess
    {
        Logger logger; 
        string log;

        public GoodEmployeeProcess()
        {
            logger = new Logger();
        }

        public bool InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);
                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);
                return true;
            }

            catch (Exception ex)
            {
                log = logger.BuildLog("Hata Mesajı: " + ex.Message);
                logger.LogFile(@"C:\Log.txt", log);
                return false;
            }
        }
    }
}
