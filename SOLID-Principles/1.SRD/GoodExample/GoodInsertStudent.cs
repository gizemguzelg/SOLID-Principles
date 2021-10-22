using _1.SRD.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRD.GoodExample
{
   public class GoodInsertStudent
    {
        public GoodLogger goodLogger;

        public GoodInsertStudent() => goodLogger = new GoodLogger();

        string log;

        public bool CreateEmployee(Student student)
        { 
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                stringBuilder.Append(student.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(student.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(student.LastName);
                stringBuilder.AppendLine();
                

                log = goodLogger.BuildLog(stringBuilder.ToString());

                goodLogger.LogFile(@"C:\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                log = goodLogger.BuildLog(ex.Message.ToString());
                goodLogger.LogFile(@"Log.txt", log);

                return false;
            }
        }

    }
}
