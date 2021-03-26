using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.model
{
    public class Book
    {
        public int Id { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public Author author { get; set; }

    }
}