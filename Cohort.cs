using System;
using System.Collections.Generic;

namespace studentPractice
{
    class Cohort
    {
        public string CohortName { get; set; } // This property is the cohort's name

        public List<Student> cohortStudents = new List<Student>(); // Collection of students in the cohort

        public List<Instructor> cohortInstructors = new List<Instructor>(); // Collection of instructors in the cohort

    }
}
