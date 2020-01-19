using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsortoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; } //The one joining to Course Table
        public virtual Student Student { get; set; } //The one joining to Student Table

    }
}