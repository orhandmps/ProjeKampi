﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(150)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassWord { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Contact> Contects { get; set; }
        public Writer()
        {
            Headings = new HashSet<Heading>();
            Contects = new HashSet<Contact>();
        }


    }
}
