using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1 {
    public class Book {
        public string Title { get; set; }
        public Publisher Publisher { get; set; }
        public Author[] Authors { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Isbn { get; set; }
        public Subject Subject { get; set; }

        override public string ToString() {
            return String.Format("Name: {0}\t,ISBN: {1}", Title, Isbn);
        }
    }
}
