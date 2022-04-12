using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace task_1
{
    class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double perc { get; set; }

        public List<string> subjectinterest { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Slist = new Student[]
            {
                new Student(){firstname="Divya sri",lastname="Saladi",smailid="divya@gmail.com",branch="ECE",perc=85,subjectinterest= new List<string>{ "NETWORKS","CONTROL SYSTEMS"}},
                new Student(){firstname="Devi sri",lastname="Chappidi",smailid="devi@gmail.com",branch="CSE",perc=75,subjectinterest= new List<string>{ "DBMS","OOPS "}},
                new Student(){firstname="Bharath",lastname="Sada",smailid="bharath@gmail.com",branch="EEE",perc=67,subjectinterest= new List<string>{ "Power sys","CONTROL engineering"}},
                new Student(){firstname="Ram",lastname="Vanga",smailid="ram@gmail.com",branch="IT",perc=74,subjectinterest= new List<string>{ "Data structures", "DBMS"}},
                new Student(){firstname="Anju",lastname="Saladi",smailid="anju@gmail.com",branch="MECH",perc=69,subjectinterest= new List<string>{ "Solid mechanics","Engg Thermodynamics"}},
                new Student(){firstname="Samantha",lastname="Ruthu",smailid="sam@gmail.com",branch="CIVIL",perc=76,subjectinterest= new List<string>{ "Surveying","Fluid mechanics"}},
                new Student(){firstname="Nageshwar",lastname="Golla",smailid="nageshwar@gmail.com",branch="ECE",perc=93,subjectinterest= new List<string>{ "WSN","EMBEDDED SYSTEMS"}},
                new Student(){firstname="Jessy",lastname="Sada",smailid="jessy@gmail.com",branch="EEE",perc=53,subjectinterest= new List<string>{ "EFT","CONTROL engineering"}},
                new Student(){firstname="Raghu",lastname="Rao",smailid="raghu@gmail.com",branch="CSE",perc=45,subjectinterest= new List<string>{ "Data structures","OOPS"}},
                new Student(){firstname="Chaitra",lastname="Dasari",smailid="chaitra@gmail.com",branch="IT",perc=66,subjectinterest= new List<string>{ "CAO","OS"}}
            };
            Console.WriteLine("*******SELECT QUERY*******");
            var query1 = (from i in Slist select i);
            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + "." + i.lastname + " - " + i.smailid + "--" + i.branch + "->" + i.perc);
            }
            Console.WriteLine("*******SELECT MANY QUERY*******");
            var query = Slist.SelectMany(i => i.subjectinterest);
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******WHERE QUERY*******");
            var query2 = from i in Slist where i.perc > 70 select i;
            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******TAKE QUERY*******");
            IEnumerable<Student> query3 = (from i in Slist where i.perc > 55 select i).Take(4);
            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******SKIP QUERY*******");
            var query4 = Slist.Skip(2);
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******TAKE WHILE QUERY*******");
            var query5 = Slist.TakeWhile(i => i.firstname == "Samantha");
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******SKIP WHILE QUERY*******");
            var query6 = Slist.SkipWhile(i => i.firstname == "Samantha");
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******ORDER BY QUERY (DESCENDING)*******");
            var query7 = Slist.OrderByDescending(i => i.lastname);
            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******ORDER BY QUERY (ASCENDING)*******");

            var query8 = Slist.OrderBy(i => i.lastname);
            foreach (var i in query8)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******GROUP BY QUERY (BRANCH)*******");
            var query9 = from i in Slist group i by i.branch;
            foreach (var group in query9)
            {
                Console.WriteLine(group.Key);
                foreach (var i in group)
                {
                    Console.WriteLine(i.firstname + " " + i.lastname);
                }
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("*******AGGREGATE FUNCTIONS*******");
            double sum = (from i in Slist select i.perc).Sum();
            Console.WriteLine("sum:" + sum);

            double max = (from i in Slist select i.perc).Max();
            Console.WriteLine("Maximum percentage:" + max);

            double min = (from i in Slist select i.perc).Min();
            Console.WriteLine("Minimum percentage:" + min);

            double avg = (from i in Slist select i.perc).Average();
            Console.WriteLine("average:" + avg);

            var disnt = (from i in Slist select i.branch).Distinct();
            foreach (string i in disnt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******LET *******");
            var LET = from i in Slist let res = i.perc + 6 select res;
            foreach (var i in LET)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******INTO*******");
            var INTO = from i in Slist where i.branch == "CSE" select i into res where res.firstname.StartsWith("R") select res;
            foreach (var i in INTO)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("*******OFF TYPE(DOUBLE)*******");
            var OFFDOU = (from i in Slist select i.perc).OfType<double>();
            foreach (var i in OFFDOU)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******OFF TYPE(STRING)*******");
            var OFFSTR = (from i in Slist select i.firstname).OfType<String>();
            foreach (var i in OFFSTR)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******FIRST()*******");
            var FIR = (from i in Slist where i.branch == "ECE" select i.firstname).First();
            Console.WriteLine(FIR);
            Console.WriteLine("*******FIRSTORDEFAULT()*******");
            var FIRD = (from i in Slist where i.branch == "CSE" select i.firstname).FirstOrDefault();
            Console.WriteLine(FIRD);
            Console.WriteLine("*******LAST()*******");
            var LAST = (from i in Slist where i.branch == "ECE" select i.firstname).Last();
            Console.WriteLine(LAST);
            Console.WriteLine("*******LASTORDEFAULT()*******");
            var LASTD = (from i in Slist where i.branch == "IT" select i.firstname).LastOrDefault();
            Console.WriteLine(LASTD);
            Console.WriteLine("*******SINGLE()*******");
            var SINGLE = (from i in Slist where i.branch == "MECH" select i.firstname).Single();
            Console.WriteLine(SINGLE);
            Console.WriteLine("*******SINGLEORDEFAULT()*******");
            var SINGLEDEF = (from i in Slist where i.branch == "CIVIL" select i.firstname).SingleOrDefault();
            Console.WriteLine(SINGLEDEF);
            Console.WriteLine("*******ELEMENTAT()*******");
            var eleat = (from i in Slist select i).ElementAt(3);
            Console.WriteLine(eleat.firstname);
            Console.WriteLine("*******ELEMENTATORDEFAULT()*******");
            var eleatDef = (from i in Slist select i).ElementAtOrDefault(9);
            Console.WriteLine(eleatDef.firstname);

            Console.WriteLine("*******IMMEDIATE EXECUTION*******");
            List<Student> studet = new List<Student>
            {
                new Student(){firstname="Divya sri",lastname="Saladi",smailid="sdivya@gmail.com",branch="ECE",perc=85,subjectinterest= new List<string>{ "EDC","CONTROL SYSTEMS"}},
                new Student(){firstname="Devi",lastname="Chappidi",smailid="devisri@gmail.com",branch="CSE",perc=75,subjectinterest= new List<string>{ "DBMS","Computer Graphics"}},
            };
            var Immed = (from i in studet select i).Count();//immidiate execution takes place if aggregate func used
            studet.Add(new Student() { firstname = "Suma", lastname = "Kanakala", smailid = "suma@gmai.com" });
            studet.Add(new Student() { firstname = "Raji", lastname = "Aggarwal", smailid = "raji@gmai.com" });
            Console.WriteLine(Immed);

            Console.WriteLine("*******DEFFERED EXECUTION*******");
            List<Student> studet1 = new List<Student>
            {
                new Student(){firstname="Divya sri",lastname="Saladi",smailid="sdivya@gmail.com",branch="ECE",perc=85,subjectinterest= new List<string>{ "EDC","CONTROL SYSTEMS"}},
                new Student(){firstname="Devi",lastname="Chappidi",smailid="devisri@gmail.com",branch="CSE",perc=75,subjectinterest= new List<string>{ "DBMS","Computer Graphics"}},
            };
            var Deffer = (from i in studet1 select i);//here deferred execution takes place
            studet1.Add(new Student() { firstname = "Suma", lastname = "Kanakala", smailid = "suma@gmai.com" });
            studet1.Add(new Student() { firstname = "Raji", lastname = "Aggarwal", smailid = "raji@gmai.com" });
            foreach (Student i in Deffer) //here query1 execution starts
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("*******STARTSWITH()*******");
            var Startwith = Slist.Where(i => i.firstname.StartsWith("R"));
            foreach (Student i in Startwith)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("*******ENDSWITH()*******");
            var Endwith = Slist.Where(i => i.firstname.EndsWith("a"));
            foreach (Student i in Endwith)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("*******CONTAINS()*******");
            var contain = Slist.Where(i => i.firstname.Contains("m"));
            foreach (Student i in contain)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("*******Ienumerable*******");
            IEnumerable<Student> ienu = (from i in Slist select i).AsEnumerable();
            foreach (var i in ienu)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("*******Iqueryable*******");
            IQueryable<Student> iquery = (from i in Slist select i).AsQueryable();
            foreach (var i in iquery)
            {
                Console.WriteLine(i.firstname);
            }
        }
    }
}