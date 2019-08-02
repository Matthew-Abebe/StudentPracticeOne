using System;
using System.Collections.Generic;

namespace studentPractice
{
    class Student
    {

        //add constructor here

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int StudentCohort { get; set; }

        public Student(string firstName, string lastName, string slackHandle, int studentCohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            StudentCohort = studentCohort;
            // StudentExercises = studentExercises;

        }

       

    public List<Exercise> StudentExercises { get; } = new List<Exercise>(); // A list of student exercises that are type Exercises (Class)
    public void AddExercise(Exercise studentWork)
    {
        StudentExercises.Add(studentWork);
    }
    }



}
