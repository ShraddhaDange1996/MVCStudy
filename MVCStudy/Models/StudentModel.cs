﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStudy.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [Display(Name="Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public string StudClass { get; set; }

        public string Stud { get; set; }
    }
}