using System;
using System.Linq;

namespace _03_ReadAndPrintCompanyInformation
{
    class ReadAndPrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write company information: ");
            Console.Write("Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.Write("Fax: ");
            string companyFaxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string companyWebSite = Console.ReadLine();

            Console.WriteLine("Write company's manager information: ");
            Console.Write("First name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Age: ");
            byte managerAge = Byte.Parse(Console.ReadLine());
            Console.Write("Phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Company info: ");
            Console.WriteLine("Name: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone number: {0}", companyPhoneNumber);
            Console.WriteLine("Fax number: {0}", companyFaxNumber);
            Console.WriteLine("Web site: {0}", companyWebSite);

            Console.WriteLine("Manager of {0}:", companyName);
            Console.WriteLine("Name: {0} {1}", managerFirstName, managerLastName);
            Console.WriteLine("Age: {0}", managerAge);
            Console.WriteLine("Phone number: {0}", managerPhoneNumber);
        }
    }
}
