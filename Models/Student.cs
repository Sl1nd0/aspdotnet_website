using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsortoUniversity.Models
{
    public class Student
    {
        public String FirstMidName { get; set; }
        public String LastName { get; set; }
        public int ID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}