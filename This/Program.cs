using System;

namespace This
{
    class Employee
    {
        private string name; // field
        private string alias; // field
        private decimal salary = 3000.00m;

        // Constructor:
        public Employee(string name, string alias)
        {
            // Use this to qualify the fields, name and alias
            // note that name and alias are private
            this.name = name;
            this.alias = alias;
        }

        // Printing method:
        public void printEmployee()
        {
            Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);

            // Passing the object to the CalcTax method by using `this`.
            Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
        }

        public decimal Salary
        {
            get { return salary; }
        }
    }

    class Tax
    {
        public static decimal CalcTax(Employee E)
        {
            return 0.08m * E.Salary;
        }
    }

    class MainClass
    {
        static void Main()
        {
            // Create objects:
            Employee E1 = new Employee("Mingda Pan", "mpan");

            // Display results:
            E1.printEmployee();
        }
    }
    /*
    Output:
        Name: Mingda Pan
        Alias: mpan
        Taxes: $240.00
     */
}
