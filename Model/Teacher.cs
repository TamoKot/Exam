using System.Collections.Generic;
using System;

class Teacher: User {
   private string TeacherYearOld;
   private string TeacherPosition;
   private string TeacherAllergy;
   private string TeacherRegious;
   private string TeacherCar;
   private string TeacherCarNumber;

   public Teacher(string nameprefix,string name,string surname,UserType type,
   string TeacherYearOld,string TeacherPosition,string TeacherAllergy,
   string TeacherRegious,string TeacherCar,string TeacherCarNumber) : base(nameprefix, name, surname, type) {
        this.TeacherYearOld = TeacherYearOld;
        this.TeacherPosition = TeacherPosition;
        this.TeacherAllergy = TeacherAllergy;
        this.TeacherRegious = TeacherRegious;
        this.TeacherCar = TeacherCar;
        this.TeacherCarNumber = TeacherCarNumber;
     }

}