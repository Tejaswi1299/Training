using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment7
/*1.Create a console application and add class named Employee with following field.
Employee Class
EmployeeID (Integer)
FirstName(String)
LastName(String)
Title(String)
DOB(Date)
DOJ(Date)
City(String)*/

{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
        #region
        /*2. Create a Generic List Collection empList and populate it with the following records.

        EmployeeID FirstName      LastName Title       DOB DOJ             City
        1001		     Malcolm Daruwalla  Manager 		16/11/1984 	8/6/2011 		Mumbai
        1002 		Asdin Dhalla         AsstManager 	20/08/1984 	7/7/2012 		Mumbai
        1003 		Madhavi Oza             Consultant 	14/11/1987 	12/4/2015 	Pune
        1004 		Saba Shaikh      SE 			3/6/1990	 	2/2/2016	 	Pune
        1005 		Nazia Shaikh      SE 			8/3/1991 		2/2/2016	 	Mumbai
        1006 		Amit Pathak      Consultant 	7/11/1989 	8/8/2014 		Chennai
        1007 		Vijay Natrajan        Consultant 	2/12/1989	 	1/6/2015 		Mumbai
        1008 		Rahul Dubey       Associate	 	11/11/1993 	6/11/2014	 	Chennai
        1009 		Suresh Mistry      Associate 	12/8/1992 	3/12/2014 	Chennai
        1010 		Sumit Shah        Manager 		12/4/1991 	2/1/2016 		Pune*/

        #endregion
        public static List<Employee> EmployeeList()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee {EmployeeID=1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager",     City = "Mumbai", DOB = new DateTime(1984/11/20), DOJ = new DateTime(2011,6,8) },
                new Employee {EmployeeID=1002, FirstName = "Asdin",   LastName = "Dhalla",    Title = "AsstManager", City = "Mumbai", DOB=new DateTime(1984,08,20),   DOJ =new DateTime(2012,7,7) },
                new Employee {EmployeeID=1003, FirstName= "Madhavi",  LastName= "Oza",        Title ="Consultant",   City= "Pune",    DOB=new DateTime(1987,11,14),   DOJ=new DateTime(2015,4,12) },
                new Employee {EmployeeID=1004, FirstName = "Saba",    LastName = "Shaikh",    Title = "SE",          City = "Pune",   DOB =new DateTime (1990,6,3),   DOJ =new DateTime(2016,2,2) },
                new Employee {EmployeeID=1005, FirstName= "Nazia",    LastName = "Shaikh",    Title="SE",            City="Mumbai",   DOB=new DateTime(1991,3,8),     DOJ=new DateTime(2016,2,2)},
                new Employee {EmployeeID=1006, FirstName= "Amit",     LastName= "Pathak",     Title="Consultant",    City= "Chennai", DOB=new DateTime(1989,11,7),    DOJ=new DateTime(2014,8,8)},
                new Employee {EmployeeID=1007, FirstName="Vijay",     LastName= "Natrajan",   Title="Consultant",    City= "Mumbai",  DOB=new DateTime(1989,12,2),    DOJ=new DateTime(2015,6,1)},
                new Employee {EmployeeID=1008, FirstName= "Rahul",    LastName= "Dubey",      Title= "Associate",    City= "Chennai", DOB=new DateTime(1993,11,11),   DOJ=new DateTime(2014,11,6)},
                new Employee {EmployeeID=1009, FirstName= "Suresh",   LastName= "Mistry",     Title= "Associate",    City= "Chennai", DOB=new DateTime(1992,8,12),    DOJ=new DateTime(2014,12,3)},
                new Employee {EmployeeID=1010, FirstName= "Sumit",    LastName="Shah",        Title="Manager",       City= "Pune",    DOB=new DateTime(1991,4,12),    DOJ=new DateTime(2016,1,2) },
            };
            return emplist;
        }
    }
    /*3. Now once the collection is created write down and execute the LINQ queries for collection 
    as follows :*/
    class EmployeeLinq
    {
        public static void Main()
        {

            ////a. Displaying details of all the employees
            #region
            //var empdetails = from allEmployees in Employee.EmployeeList()
            //                 select allEmployees;
            //Console.WriteLine("------Employee Details-----");
            //foreach (var allEmps in empdetails)
            //Console.WriteLine("Emp ID : " + allEmps.EmployeeID + " FirstName:  " + allEmps.FirstName + "   LastName : " + allEmps.LastName + "    Title: " + allEmps.Title + "    City: " + allEmps.City + "   DOB: " + allEmps.DOB.ToShortDateString() + "   DOJ: " + allEmps.DOJ.ToShortDateString());
            #endregion
            // b. Displaying details of all the employee whose location is not Mumbai
            #region
            //var emp_notinmumbai = from MumbaiEmp in Employee.EmployeeList()
            //                      where MumbaiEmp.City != "Mumbai"
            //                      select MumbaiEmp;
            //foreach(var e1 in emp_notinmumbai)
            //{
            //    Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", e1.EmployeeID, e1.FirstName, e1.LastName, e1.Title, e1.City, e1.DOB.ToShortDateString(), e1.DOJ.ToShortDateString());
            //}
            #endregion
            // c.Display details of all the employee whose title is AsstManager
            #region
            //var AssMgr = from assmgr in Employee.EmployeeList()
            //             where assmgr.Title != "AsstManager"
            //             select assmgr;
            //foreach(var Asstmgr in AssMgr)
            //{
            //Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", Asstmgr.EmployeeID, Asstmgr.FirstName, Asstmgr.LastName, Asstmgr.Title, Asstmgr.City, Asstmgr.DOB.ToShortDateString(), Asstmgr.DOJ.ToShortDateString());
            //}
            #endregion
            // d. Display details of all the employee whose Last Name start with S
            #region
            //var Lastname = from Name in Employee.EmployeeList()
            //               where Name.LastName.StartsWith("S")
            //               select Name;
            //foreach(var lastName in Lastname)
            //Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", lastName.EmployeeID, lastName.FirstName, lastName.LastName, lastName.Title, lastName.City, lastName.DOB.ToShortDateString(), lastName.DOJ.ToShortDateString());
            #endregion
            //  e. Display a list of all the employee who have joined before 1/1/2015
            #region
            //  var doj = from Doj in Employee.EmployeeList()
            //            where Doj.DOJ < DateTime.Parse("2015/01/01")
            //            select Doj;
            //  foreach(var Dateofjoining in doj)
            //Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", Dateofjoining.EmployeeID, Dateofjoining.FirstName, Dateofjoining.LastName, Dateofjoining.Title, Dateofjoining.City, Dateofjoining.DOB.ToShortDateString(), Dateofjoining.DOJ.ToShortDateString());
            #endregion
            //f.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            #region
            //var dob = from Dob in Employee.EmployeeList()
            //          where Dob.DOB > DateTime.Parse("1990/01/01")
            //          select Dob;
            //foreach (var Dateofbirth in dob)
            //    Console.WriteLine("EmployeeID : {0} FirstName: {1},  LastName: {2},  Title: {3},  City: {4},  DOB: {5},  DOJ: {6}", Dateofbirth.EmployeeID, Dateofbirth.FirstName, Dateofbirth.LastName, Dateofbirth.Title, Dateofbirth.City, Dateofbirth.DOB.ToShortDateString(), Dateofbirth.DOJ.ToShortDateString());
            #endregion
            //g.Display a list of all the employee whose designation is Consultant and Associate
            #region
            //var Designation = from desn in Employee.EmployeeList()
            //                  where desn.Title == "Consultant" || desn.Title == "Associate"
            //                  select desn;
            //foreach(var des in Designation)
            //{
            //    Console.WriteLine("EmployeeID : {0} FirstName: {1},  LastName: {2},  Title: {3},  City: {4},  DOB: {5},  DOJ: {6}", des.EmployeeID, des.FirstName, des.LastName, des.Title, des.City, des.DOB.ToShortDateString(), des.DOJ.ToShortDateString());
            //}
            #endregion
            //h. Display total number of employees
            #region
            //var List = (from EmpCount in Employee.EmployeeList()
            //            select EmpCount.EmployeeID).Count();
            //Console.WriteLine(" Total Count of Employee is : "+List );
            #endregion
            //i.Display total number of employees belonging to “Chennai”
            #region
            //var ChennaiEmp = (from ChennaiEmployee in Employee.EmployeeList()
            //                 where ChennaiEmployee.City == "Chennai"
            //                 select ChennaiEmployee).Count();
            //Console.WriteLine(" Total Count of Chennai Employees are: " + ChennaiEmp);
            #endregion
            // j. Display highest employee id from the list
            #region
            //var HighestEmpId = (from highestEmpId in Employee.EmployeeList()
            //                    select highestEmpId.EmployeeID).Max();
            //Console.WriteLine(" Highest employee id from the Employee list is: "+ HighestEmpId);
            #endregion
            //k. Display total number of employee who have joined after 1/1/2015
            #region
            //var Doj = (from doj in Employee.EmployeeList()
            //           where doj.DOJ > DateTime.Parse("01/01/2015")
            //           select doj).Count();
            //  Console.WriteLine("Count of employees who have joined after 1/1/2015: "+Doj);
            #endregion
            //l. Display total number of employee whose designation is not “Associate”
            #region
            //var Degn = from role in Employee.EmployeeList()
            //            where role.Title != "Associate"
            //            select role;
            //foreach(var Role in Degn)
            //{
            //Console.WriteLine("EmployeeID : {0} FirstName: {1},  LastName: {2},  Title: {3},  ", Role.EmployeeID, Role.FirstName, Role.LastName, Role.Title);
            //}
            //var Des = (from desn in Employee.EmployeeList()
            //           where desn.Title != "Associate"
            //           select desn).Count();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("total no of Employees whose designation is not Associate are: "+Des);
            #endregion
            //m.Display total number of employee based on City
            #region
            var city = Employee.EmployeeList().GroupBy(a => a.City).OrderBy(b => b.Key);

            Console.WriteLine("Displaying total number of employee based on city");
            foreach (var emp in city)
            {
                Console.WriteLine("The total count of Employees in the {0} city are : {1}", emp.Key, emp.Count());
            }
            #endregion
            // n. Display total number of employee based on city and title
            #region
            Console.WriteLine("------------------------------------------------------------------");
            var CityandTitle = from countEmp in Employee.EmployeeList()
                        group countEmp by new { countEmp.City, countEmp.Title } into i
                        orderby i.Key.City, i.Key.Title
                        select new { city = i.Key.City, title = i.Key.Title, count = i.Count() };

            Console.WriteLine("Displaying total number of employee based on city and title");
            foreach (var employee in CityandTitle)
            {
                Console.WriteLine("{0} {1} in {2} office", employee.count, employee.title, employee.city);
            }
            #endregion
            // o. Display youngest employee who is  in the list
            #region

            var Youngest = (from Emp in Employee.EmployeeList()
                         orderby Emp.DOB ascending
                         select Emp).LastOrDefault();
            Console.WriteLine("----------------------------------------------"); 
            Console.WriteLine("The youngest employee  from the list is : ID: {0}, Name: {1}, DOB : {2}", Youngest.EmployeeID, Youngest.FirstName, Youngest.DOB.Date.ToShortDateString());
            #endregion

            Console.Read();
        }
    }
}
