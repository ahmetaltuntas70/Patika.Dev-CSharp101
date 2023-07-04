using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101
{
    class _21_Class_Instance_Field_Property
    {
        static void Main(string[] args)
        {

            // Syntax
            // Class ClassName
            //{
            //    [Access Modifiers]    [Data Type] PropertyName:
            //    [Access Modifiers]    [Return Type] MethodsName ([List of parameters])
            //    {
            //        // Operations
            //    }

            //Access Modifiers
            // * Public
            // * Private
            // * Internal
            // * Protected




            Employee employeeOne = new Employee();
            employeeOne.Name = "Fero";
            employeeOne.LastName = "Ahmo";
            employeeOne.No = 123456;
            employeeOne.Department = "IT";

            employeeOne.GetEmployeeInfo();

            Console.WriteLine("************");

            Employee employeeTwo = new Employee();
            employeeTwo.Name = "Ahmo";
            employeeTwo.LastName = "Fero";
            employeeTwo.No = 123434;
            employeeTwo.Department = "Hr";

            employeeTwo.GetEmployeeInfo();

        }

        class Employee
        {
            public string Name;
            public string LastName;
            public int No;
            public string Department;

            public void GetEmployeeInfo()
            {
                Console.WriteLine("Name of the employee: {0}", Name);
                Console.WriteLine("Last Name of the employee: {0}", LastName);
                Console.WriteLine("Id of the employee: {0}", No);
                Console.WriteLine("Department of the employee: {0}", Department);
            }
        }
    }
}
