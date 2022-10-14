using System.Collections.Generic;
using System;

class CurrentStudent: User {
   private string CurrentStudentID;
   private string CurrentStudentYearOld;
   private string CurrentStudentAllergy;
   private string CurrentStudentRegious;

   public CurrentStudent(string nameprefix,string name,string surname,UserType type,
   string CurrentStudentID,string CurrentStudentYearOld,string CurrentStudentAllergy,
   string CurrentStudentRegious) : base(nameprefix, name, surname, type) {
        this.CurrentStudentID = CurrentStudentID;
        this.CurrentStudentYearOld = CurrentStudentYearOld;
        this.CurrentStudentAllergy = CurrentStudentAllergy;
        this.CurrentStudentRegious = CurrentStudentRegious;
     }

}