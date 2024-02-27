﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public int WriterName { get; set; }
        public int WriterSurname { get; set; }
        public int WriterImage { get; set; }
        public int WriterMail { get; set; }
        public int WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
