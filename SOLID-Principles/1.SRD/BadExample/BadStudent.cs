using _1.SRD.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRD.BadExample
{
   public class BadStudent
    {
        void CreateStudent(Student student)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {   stringBuilder.Append(student.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(student.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(student.LastName);
                stringBuilder.AppendLine();

                stringBuilder = new StringBuilder();
                stringBuilder.Append("İnsertDate: ");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.Append(student.Id);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());



            }
            catch (Exception ex)
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append(ex.Message);
                stringBuilder.Append(DateTime.Now.ToString());
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());

            }
        }

    }
}
