using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqComperhinsonQuery
{
    public static class Helper
    {

        public static IEnumerable<TSource> Where2<TSource>(
                                                       this IEnumerable<TSource> source,
                                                       Func<TSource, bool> predicate) 
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                   
                    yield return item;

                }
            }

        }

        public static List<Student> GetStudents()
        {

            return new List<Student> {
            new Student { Name = "Ahmed", ID = 1, Mark = 15 },
            new Student { Name = "Mohamed", ID = 2, Mark = 14 },
            new Student { Name = "Samy", ID = 3, Mark = 12 }
            };


        }
        public static void print2<TResult>(this IEnumerable<TResult> tstudent)
        {
            foreach (var item in tstudent)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print( this IEnumerable<dynamic> tstudent )
        {
            if(tstudent is IEnumerable<Student>)
            {
                foreach (Student item in tstudent)
                {
                    Console.WriteLine(item.Name + " " + item.ID+ " " +item.Mark);
                   
                }
            }
            else if (tstudent is IEnumerable<string>)
            {
                foreach (string item in tstudent)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
            else
            {
                foreach(var item in tstudent)
                {
                    Console.WriteLine(item);
                }
            }
            


        }


    }




}


