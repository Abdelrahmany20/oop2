using System.Reflection;
using System.Xml.Linq;

namespace assinment
{


    public struct point
    {
        //Q01 P1

        public double X;
        public double Y;
    }

    public struct Person
    {

        //Q02 P1
        public string name;
        public int age;

        public Person(string name, int age)
        {
           this.name = name;
           this.age = age;
        }
    }





    public class Employee
    {  //Q01 p2



        //public int ID;
        //public string Name;
        //public string Security;
        //public decimal Salary;
        //public DateTime HireDate;
        //public string Gender;


        //0.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)


        public int ID { get; set; }
        public string Name { get; set; }
        public string Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int id, string name, string securityLevel, decimal salary, DateTime hireDate, string gender)

        {
            ID = id;
            Name = name;
            Security = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;

        }

        public override string ToString()
        {
            return $"ID :{ID} , name : {Name} , securityLevel : {Security} , salary : {Salary} , HireDate :{HireDate} , Gender : {Gender}  ";
        }




        public void  empinfo()
        {//0.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)


            Console.WriteLine($"ID :{ID} , name : {Name} , securityLevel : {Security} , salary : {Salary} , HireDate :{HireDate} , Gender : {Gender}  ");


        }
    }
            public enum Gender
            {
                M, F
            }

            public enum SecurityLevel
            {
                Guest,
                Developer,
                Secretary,
                DBA
            }


    public class HiringDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"Day : {Day} , Month : {Month} , Year : {Year}";
        }
    }







    internal class Program
    {
        static void Main(string[] args)
        {



            #region part 1

            #region Q01
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.





            //point p1 = new point();
            //point p2= new point();



            //Console.WriteLine("Enter the X 1:");
            //p1.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Y 1:");
            //p1.Y = double.Parse(Console.ReadLine());



            //Console.WriteLine("Enter the X 2:");
            //p2.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Y 2:");
            //p2.Y = double.Parse(Console.ReadLine());


            //double distance =Math.Sqrt(Math.Pow(p2.X-p1.X,2)+Math.Pow(p2.Y-p1.Y,2));

            //Console.WriteLine(distance);


            #endregion

            #region Q02
            //2.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)


            //{

            //Console.WriteLine("Enter the Name :");
            //string name = Console.ReadLine();


            //Console.WriteLine("Enter The Age :");
            //int age = int.Parse(Console.ReadLine());

            //people[i] = new Person(name, age);

            //}
            //Person oldestPerson = people[0];

            //for (int i = 1; i < 3; i++)
            //{
            //if (people[i].age > oldestPerson.age)
            //oldestPerson = people[i];
            //}

            //Console.WriteLine($"Oldest person is :{oldestPerson.name}");

            #endregion


            #endregion

            #region part 2


            #region Q01


            //Employee emp1 = new Employee(10,"a", "Guest",100, new DateOnly(2000, 10, 2), "M");


            //Console.WriteLine(emp1);


            #endregion


            #region Q02

            //HiringDate hireDate = new HiringDate(10, 10, 2010);


            //Employee emp1 = new Employee(10,"a", "Guest",100, hireDate, "M");



            #endregion



            #region Q03


            //try
            //{
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "a", "DBA", 1000, new DateTime(2000, 1, 1), "M");
            //EmpArr[1] = new Employee(2, "b", "Guest", 2000, new DateTime(2000, 2, 2), "M");
            //EmpArr[2] = new Employee(3, "c", "Security Officer", 5000, new DateTime(2000, 3, 3), "M");

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //EmpArr[i].empinfo();
            //}
            //}
            //catch (Exception ex)
            //{
            //Console.WriteLine(ex.Message);
            //}

            #endregion


            #region Q04



            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ahmed", "DBA", 5000, new DateTime(2010, 1, 1), "M");
            EmpArr[1] = new Employee(2, "Sara", "Guest", 3000, new DateTime(2012, 3, 5), "F");
            EmpArr[2] = new Employee(3, "Mohamed", "Security Officer", 7000, new DateTime(2005, 5, 15), "M");

            int boxingCount = 0;
            int unboxingCount = 0;


            Console.WriteLine(" before sorting :");
            for (int i = 0; i < EmpArr.Length; i++)
            {
                EmpArr[i].empinfo();
            }


            Array.Sort(EmpArr);
            Console.WriteLine("after sorting:");

            Console.WriteLine("\nEmployees sorted by hire date:");
            foreach (var employee in EmpArr)
            {
                Console.WriteLine($"Name: {employee.Name}, Security: {employee.Security}, Salary: {employee.Salary}, Hire Date: {employee.HireDate}, Gender : {employee.Gender}");
            }



            #endregion
        }

        













        #endregion

    }
}







