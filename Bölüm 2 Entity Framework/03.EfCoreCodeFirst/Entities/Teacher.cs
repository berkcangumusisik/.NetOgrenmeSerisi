﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } 
}
