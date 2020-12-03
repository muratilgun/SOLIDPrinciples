using System;
using System.IO;
using System.Text;
using SOLID.SingleResponsibilityPrinciple.ExampleOne.Model;

namespace SOLID.SingleResponsibilityPrinciple.ExampleOne.Bad
{
    public class BadEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                //Çalışan Ekleme İşlemi
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                File.WriteAllText(@"C.\EmployeeData.txt", sb.ToString());
                //Ekleme işlemine dair logların tutulması
                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Personel Id: ");
                sb.Append(newEmployee.Id);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());
            }
            catch (Exception ex)
            {
                //Ekleme işleminde hata alınırsa hata loglarının tutulması işlemi
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Hata..!");
            }
        }
    }
}
