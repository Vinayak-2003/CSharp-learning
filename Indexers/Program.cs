#pragma warning disable 8603, 8601
using System.Security.Cryptography.X509Certificates;

namespace Indexers
{
    public class Employee
    {
        // declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }

        // initialize the properties through constructor
        public Employee(int ID, string Name, string Job, double Salary, string Location)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
        }

        // creating indexer using integer index
        public object this[int index]
        {
            // get accessor is used to return a value
            get
            {
                // return the appropriate value based on the index
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Location;
                else
                    return null;
            }

            // set accessor is used to assign a value
            set
            {
                // set the appropriate value according to the index
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Location = value.ToString();
            }
        }

        // creating indexer using string indexer
        public object this[string indexName]
        {
            get
            {
                if (indexName == "ID")
                    return ID;
                else if (indexName == "Name")
                    return Name;
                else if (indexName == "Job")
                    return Job;
                else if (indexName == "Salary")
                    return Salary;
                else if (indexName == "Location")
                    return Location;
                else
                    return null;
            }

            set
            {
                if (indexName == "ID")
                    ID = Convert.ToInt32(value);
                else if (indexName == "Name")
                    Name = value.ToString();
                else if (indexName == "Job")
                    Job = value.ToString();
                else if (indexName == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (indexName == "Location")
                    Location = value.ToString();
            }
        }    
    }

    class Program
    {
        public static void Main()
        {
            Employee employee = new Employee(342, "Vinayak Kanchan", "Developer", 13500, "Jaipur");

            // accessing the employee object using int indexer
            Console.WriteLine($"""
            EmployeeID = {employee[0]}
            Employee Name = {employee[1]}
            Job Role = {employee[2]}
            Salary = {employee[3]}
            City / Location = {employee[4]}
            """);

            employee[2] = "SDE";
            employee[3] = 70000;
            Console.WriteLine("-------------- modified --------------");

            Console.WriteLine($"""
            EmployeeID = {employee[0]}
            Employee Name = {employee[1]}
            Job Role = {employee[2]}
            Salary = {employee[3]}
            City / Location = {employee[4]}
            """);

            Console.WriteLine();

            // accessing the employee object using string indexer
            Console.WriteLine($"""
            EmployeeID = {employee["ID"]}
            Employee Name = {employee["Name"]}
            Job Role = {employee["Job"]}
            Salary = {employee["Salary"]}
            City / Location = {employee["Location"]}
            """);
        }
    }
}