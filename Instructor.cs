using System;
using System.Collections.Generic;

namespace studentPractice
{
    class Instructor
    {

        //add constructor
        public List<Student> StudentNames = new List<Student>();

        public string FirstName { get; set; } // This property is an instructor's first name

        public string LastName { get; set; } // This property is an instructor's last name

        public string SlackHandle { get; set; } // This property is an instructor's slack handle

        public int InstructorCohort { get; set; } // This property is an instructor's cohort

        public string InstructorSpeciality { get; set; } // This property is an instructor's speciality

        // need method to assign an exercise to a student ... look at classes chapter for method example

        public void AssignExercise(Exercise Exercise, Student Student)
        {
            Student.AddExercise(Exercise);
        }


    }
}
