using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1 {
    internal class Program {
        static void Main(string[] args) {
            //------------1---------------
            Console.WriteLine("----1---------");
            var Result = SampleData.Books.Select(e => new { e.Title, e.Isbn });
            foreach (var item in Result) {
                Console.WriteLine(item);
            }
            //----------------2----------------
            Console.WriteLine("-----2---------");
            var res = SampleData.Books.Select(e => new { e.Title, e.Price }).Where(h => h.Price > 25).Take(3);
            foreach (var item in res) {
                Console.WriteLine(item);
            }
            //--------3-------------
            Console.WriteLine("-----3---------");
            var res2 = SampleData.Books.Select(e => new { e.Title, e.Publisher.Name });
            foreach (var item in res2) {
                Console.WriteLine(item);
            }
            //------------4-----------
            Console.WriteLine("-----4---------");
            var res3 = SampleData.Books.Select(e => new { e.Title, e.Price }).Where(h => h.Price > 20).Count();
            Console.WriteLine(res3);
            //-------------5-----------
            Console.WriteLine("-----5---------");
            var res4 = SampleData.Books.Select(e => new { e.Title, e.Price, e.Subject.Name }).OrderBy(h => h.Name).ThenByDescending(h => h.Price);
            foreach (var item in res4) {
                Console.WriteLine(item);
            }
            //-------------6-----------
            Console.WriteLine("-----6---------");
            var subj = SampleData.Subjects.Select(e => e.Name);
            foreach (var item in subj) {
                Console.WriteLine(item);
                var quer1 = SampleData.Books.Select(e => new { e.Title, e.Subject.Name }).Where(e => e.Name == item);
                foreach (var item2 in quer1) {
                    Console.WriteLine(item2);
                }
            }
            //-------------Bonus-----------
            Console.WriteLine("-----Bonus---------");
            var groupby = SampleData.Books.GroupBy(e => e.Publisher.Name);
            foreach (var item in groupby) {
                Console.WriteLine("Publisher: {0}\n",item.Key);
                foreach (var item2 in item) {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-----Bonus---------");
            var groupby2 = SampleData.Books.GroupBy(e => e.Subject.Name);
            foreach (var item in groupby2) {
                Console.WriteLine("Subject: {0}\n",item.Key);
                foreach (var item2 in item) {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("");
            }
        }
    }
}
