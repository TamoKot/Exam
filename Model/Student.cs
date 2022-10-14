using System.Collections.Generic;
using System;

class Student: User {
   private string StudentYearOld;
   private string StudentGrade;
   private string StudentAllergy;
   private string StudentRegious;
   private string StudentSchool;

   public Student(string nameprefix,string name,string surname, UserType type,
   string StudentYearOld,string StudentGrade,string StudentAllergy,
   string StudentRegious,string StudentSchool) : base(nameprefix, name, surname, type) {
        this.StudentYearOld = StudentYearOld;
        this.StudentGrade = StudentGrade;
        this.StudentAllergy = StudentAllergy;
        this.StudentRegious = StudentRegious;
        this.StudentSchool = StudentSchool;
     }


}