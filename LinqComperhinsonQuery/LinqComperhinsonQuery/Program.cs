using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace LinqComperhinsonQuery
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var e = from student in Helper.GetStudents()
                    where student.Name == "Mohamed"
                    select new { Name = student.Name, Grade = student.Mark };

            e.Print();
            e.print2();


            //Important print2 very good
            int[] Numbers = { 3, 7, 5, 4, 6,3,42,2,5,1};
        
             var q =  Numbers.Where2(m => m > 4);
            q.print2();
            Console.ReadKey();

            //var result = from n in Numbers
            //             where n > 4
            //             orderby n descending
            //             select new { Number = n, Even = (n % 2 == 0) };



            //var result2 = Numbers.Where(n => n > 4).OrderByDescending(n => n)
            //    .Select(e => new { Number = e, Even = (e % 2 == 0) });




            //result.Print();
            //Console.WriteLine();
            //foreach (var item in result)
            //{
            //    Console.WriteLine("The Number  {0} is {1}", item.Number, item.Even ? "Even" : "Odd");

            //}
            //Console.WriteLine();
            //Console.WriteLine("Result 2");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine("The Number  {0} is {1}", item.Number, item.Even ? "Even" : "Odd");

            //}
            //---------------------------------Select Many






            //////////////////////////////////////////////////////USing  I/O
            //Thread th = new Thread(OpenFiles())

            //Thread.Sleep(500);
            //lock
            //    {

            //}
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //string Paths=null;

            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    Paths = fbd.SelectedPath;
            //    Console.WriteLine("The File Path "+fbd.SelectedPath);
            //}
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine();
            //if (Paths != null)
            //{
            //    DirectoryInfo f = new DirectoryInfo(Paths);
            //    var q = from file in f.GetFiles()
            //            select file.Name + " Last Access time  "+file.LastAccessTime;

            //    q.Print();
            //}
            Console.ReadKey();
            

        }
    }
}
