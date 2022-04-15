using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace APRIL_TASK1
{
    class student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double percentage { get; set; }
        public List<string> subintrest { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>() {
             new student(){firstname="Divya",lastname="Sri",smailid="sdivyasree@gamil.com",branch="EEE",percentage=87,subintrest= new List<string>{ "Power sys", "CONTROL engineering " } },
             new student(){firstname="pranathi",lastname="lakshmi",smailid="pranati@gamil.com",branch="CSE",percentage=89,subintrest= new List<string>{ "DBMS","OOPS "} },
             new student(){firstname="yasaswini",lastname="krishnasri",smailid="yasaswini@gamil.com",branch="EEE",percentage=78,subintrest= new List<string>{ "fact","ODS "}},
             new student(){firstname="Syam",lastname="sundar",smailid="syam@gamil.com",branch="ECE",percentage=62,subintrest= new List<string>{ "WSN","DS "} },
             new student(){firstname="Mahima",lastname="angilena",smailid="mahima@gamil.com",branch="ECE",percentage=39,subintrest= new List<string>{ "NETWORKS", "OOPS "}},
             new student(){firstname="vimal",lastname="datta",smailid="vimal@gamil.com",branch="EEE",percentage=48,subintrest= new List<string>{ "ENGINES", "MOTOR"}},
             new student(){firstname="tejaswi",lastname="madduri",smailid="tejaswi@gamil.com",branch="EEE",percentage=91,subintrest= new List<string>{ "MACHINES", "STLD "}},
             new student(){firstname="monika",lastname="naidu",smailid="monika@gamil.com",branch="MECH",percentage=61,subintrest= new List<string>{ "DRAWINGS", "MECHA"}},
             new student(){firstname="prasanth",lastname="kumar",smailid="prasanth@gamil.com",branch="IT",percentage=41,subintrest= new List<string>{ "CAO", "OS "}},
            };

            Console.WriteLine("------select---");
            var query1 = (from i in students select i);

            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + " " + i.smailid + "--" + i.branch + "-->" + i.percentage);
            }

            Console.WriteLine("--SELECT MANY QUERY--");
            var query = students.SelectMany(i => i.subintrest);
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----where---");


            var query2 = (students.Where(i => i.percentage > 90));
            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + " " + i.smailid + "--" + i.branch + "-->" + i.percentage);
            }



            Console.WriteLine("--take--");
            IEnumerable<student> query3 = (from i in students where i.percentage > 55 select i).Take(4);
            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("--skip--");

            var query4 = students.Skip(2);
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("--take while--");

            var query5 = students.TakeWhile(i => i.firstname == "Syam");
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("--SKIP WHILE--");

            var query6 = students.SkipWhile(i => i.firstname == "Syam");
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("-ORDER BY  (DESCENDING)--");

            var query7 = students.OrderByDescending(i => i.percentage > 70);
            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("--ORDER BY  (ASCENDING)--");

            var query8 = students.OrderBy(i => i.percentage > 80);
            foreach (var i in query8)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("--GROUP BY (BRANCH)--");
            var query9 = from i in students group i by i.branch;
            foreach (var group in query9)
            {
                Console.WriteLine(group.Key);
                foreach (var i in group)
                {
                    Console.WriteLine(i.firstname + " " + i.lastname);
                }
                Console.WriteLine("-----------------");
            }

            
            Console.WriteLine("---AGGRIGATE---");
            double sum = (from i in students select i.percentage).Sum();
            Console.WriteLine("Total sum of percentage is:" + sum);

            double max = (from i in students select i.percentage).Max();
            Console.WriteLine("Maximum percentage is:" + max);

            double min = (from i in students select i.percentage).Min();
            Console.WriteLine("Minimum percentage is:" + min);

            double avg = (from i in students select i.percentage).Average();
            Console.WriteLine("Total average of percentage is:" + avg);

            double count = (from i in students select i.percentage).Count();
            Console.WriteLine("Total count is:" + count);

            var disnt = (from i in students select i.branch).Distinct();
            foreach (string i in disnt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**LET ****");
            var LET = from i in students let res = i.percentage + 6 select res;
            foreach (var i in LET)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**INTO**");
            var INTO = from i in students where i.branch == "CSE" select i into res where res.firstname.StartsWith("R") select res;
            foreach (var i in INTO)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }
            Console.WriteLine("**OFF TYPE(DOUBLE)**");
            var OFFDOU = (from i in students select i.percentage).OfType<double>();
            foreach (var i in OFFDOU)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**OFF TYPE(STRING)**");
            var OFFSTR = (from i in students select i.firstname).OfType<String>();
            foreach (var i in OFFSTR)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**FIRST()**");
            var FIR = (from i in students where i.branch == "ECE" select i.firstname).First();
            Console.WriteLine(FIR);
            Console.WriteLine("**FIRSTORDEFAULT()**");
            var FIRD = (from i in students where i.branch == "CSE" select i.firstname).FirstOrDefault();
            Console.WriteLine(FIRD);
            Console.WriteLine("**LAST()**");
            var LAST = (from i in students where i.branch == "ECE" select i.firstname).Last();
            Console.WriteLine(LAST);
            Console.WriteLine("**LASTORDEFAULT()**");
            var LASTD = (from i in students where i.branch == "IT" select i.firstname).LastOrDefault();
            Console.WriteLine(LASTD);
            Console.WriteLine("**SINGLE()**");
            var SINGLE = (from i in students where i.branch == "MECH" select i.firstname).Single();
            Console.WriteLine(SINGLE);
            Console.WriteLine("**SINGLEORDEFAULT()**");
            var SINGLEDEF = (from i in students where i.branch == "CIVIL" select i.firstname).SingleOrDefault();
            Console.WriteLine(SINGLEDEF);
            Console.WriteLine("**ELEMENTAT()**");
            var eleat = (from i in students select i).ElementAt(3);
            Console.WriteLine(eleat.firstname);
            Console.WriteLine("**ELEMENTATORDEFAULT()**");
            var eleatDef = (from i in students select i).ElementAtOrDefault(9);

            Console.WriteLine("**IMMEDIATE EXECUTION**");
            List<student> studet = new List<student>
      {
        new student(){firstname="Anuradha",lastname="palakurthi",smailid="anuradha@gmail.com",branch="ECE",percentage=85},
        new student(){firstname="Amrutha",lastname="Pendurti",smailid="amrutha@gmail.com",branch="CSE",percentage=75},
      };
            var Immed = (from i in studet select i).Count();//immidiate execution takes place if aggregate func used
            studet.Add(new student() { firstname = "Amaira", lastname = "Aggarwal", smailid = "amaira@gmai.com" });
            studet.Add(new student() { firstname = "Anu", lastname = "Aggarwal", smailid = "anu@gmai.com" });
            Console.WriteLine(Immed);

            Console.WriteLine("**DEFFERED EXECUTION**");
            List<student> studet1 = new List<student>
      {
        new student(){firstname="Anuradha",lastname="palakurthi",smailid="anuradha@gmail.com",branch="ECE",percentage=80 },
        new student(){firstname="Amrutha",lastname="Pendurti",smailid="amrutha@gmail.com",branch="CSE",percentage=75},
      };
            var Deffer = (from i in studet1 select i);//here deferred execution takes place
            studet1.Add(new student() { firstname = "Amaira", lastname = "Aggarwal", smailid = "amaira@gmai.com" });
            studet1.Add(new student() { firstname = "Anu", lastname = "Aggarwal", smailid = "anu@gmai.com" });
            foreach (student i in Deffer) //here query1 execution starts
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("**STARTSWITH()**");
            var Startwith = students.Where(i => i.firstname.StartsWith("R"));
            foreach (student i in Startwith)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("**ENDSWITH()**");
            var Endwith = students.Where(i => i.firstname.EndsWith("a"));
            foreach (student i in Endwith)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("**CONTAINS()**");
            var contain = students.Where(i => i.firstname.Contains("m"));
            foreach (student i in contain)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("**Ienumerable**");
            IEnumerable<student> ienu = (from i in students select i).AsEnumerable();
            foreach (var i in ienu)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("**Iqueryable**");
            IQueryable<student> iquery = (from i in students select i).AsQueryable();
            foreach (var i in iquery)
            {
                Console.WriteLine(i.firstname);
            }




        }
    }
}

