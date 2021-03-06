﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceC.Objects
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", Id, Name);
        }
    }
}
