using System;
using System.Collections.Generic;

namespace studentPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Student newStudent = new Student("Matthew"); //make new instance of student to make new student

            Student studentOne = new Student("Matthew", "Abebe", "matthewabebe", 32); //This line just says I am making a new student
            Student studentTwo = new Student("Spongebob", "Squarepants", "spongebobSql", 33);
            Student studentThree = new Student("Patrick", "Star", "patrickstar", 33);
            Student studentFour = new Student("Squidward", "Tentacles", "tentacruel", 34);
            Student studentFive = new Student("Mr", "Krabs", "moneymoneymoney", 34);

            Exercise exerciseOne = new Exercise(); //This makes a new exercise
            exerciseOne.ExerciseName = "Assignment One";
            exerciseOne.ExerciseLanguage = "HTML";

            Exercise exerciseTwo = new Exercise();
            exerciseTwo.ExerciseName = "Assignment Two";
            exerciseTwo.ExerciseLanguage = "CSS";

            Exercise exerciseThree = new Exercise();
            exerciseThree.ExerciseName = "Assignment Three";
            exerciseThree.ExerciseLanguage = "JavaScript";

            Exercise exerciseFour = new Exercise();
            exerciseFour.ExerciseName = "Assignment Four";
            exerciseFour.ExerciseLanguage = "C Sharp";

            Cohort cohortThirtyTwo = new Cohort();
            Cohort cohortThirtyThree = new Cohort();
            Cohort cohortThirtyFour = new Cohort();

            cohortThirtyTwo.cohortStudents.Add(studentOne);
            cohortThirtyThree.cohortStudents.Add(studentTwo);
            cohortThirtyFour.cohortStudents.Add(studentThree);

            Instructor instructorOne = new Instructor(); //This makes a new instructor
            instructorOne.FirstName = "Jisie";
            instructorOne.LastName = "David";
            instructorOne.SlackHandle = "Jisie David";
            instructorOne.InstructorCohort = 32;
            instructorOne.InstructorSpeciality = "C Sharp";

            Instructor instructorTwo = new Instructor();
            instructorTwo.FirstName = "Adam";
            instructorTwo.LastName = "Schaefer";
            instructorTwo.SlackHandle = "adamdacoder";
            instructorTwo.InstructorCohort = 32;
            instructorTwo.InstructorSpeciality = "C Sharp";

            Instructor instructorThree = new Instructor();
            instructorThree.FirstName = "Brian";
            instructorThree.LastName = "Nielsen";
            instructorThree.SlackHandle = "BrianKneelson";
            instructorThree.InstructorCohort = 33;
            instructorThree.InstructorSpeciality = "JavaScript";

            Instructor instructorFour = new Instructor();
            instructorFour.FirstName = "New";
            instructorFour.LastName = "Guy";
            instructorFour.SlackHandle = "newGuy";
            instructorFour.InstructorCohort = 33;
            instructorFour.InstructorSpeciality = "SQL";

            cohortThirtyTwo.cohortInstructors.Add(instructorOne);
            cohortThirtyTwo.cohortInstructors.Add(instructorTwo);
            cohortThirtyThree.cohortInstructors.Add(instructorThree);
            cohortThirtyFour.cohortInstructors.Add(instructorFour);

            //Have each instructor assign 2 exercises to each of the students.

        }
    }
}
