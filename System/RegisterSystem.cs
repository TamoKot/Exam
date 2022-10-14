using System;

class RegisterSystem {

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
        InputNewUser();
    }

    public User InputNewUser() {
        string nameprefix = InputNamePrefix();
        string name = InputName();
        string surname = InputSurName();
        UserType userType = InputUserType();
        if (userType == UserType.CurrentStudent) {
            string CurrentStudentID = InputCurrentStudentID();
            string CurrentStudentYearOld = InputCurrentStudentYearOld();
            string CurrentStudentAllergy = InputCurrentStudentAllergy();
            string CurrentStudentRegious = InputCurrentStudentRegious();
            //string IsAdmin = InputAdminAnswer();
            //string AdminEmail = InputAdminEmail();
            //string AdminPassword = InputAdminPassword();

            return new CurrentStudent(nameprefix, name, surname, userType, 
            CurrentStudentID, CurrentStudentYearOld, CurrentStudentAllergy,
            CurrentStudentRegious); 

            //return new AdminList(AdminEmail, AdminPassword,userType);

        } else if (userType == UserType.Student) {
            string StudentYearOld = InputStudentYearOld();
            string StudentGrade = InputStudentGrade();
            string StudentAllergy = InputStudentAllergy();
            string StudentRegious = InputStudentRegious();
            string StudentSchool = InputStudentSchool();

            return new Student(nameprefix, name, surname, userType, 
            StudentYearOld, StudentGrade, StudentAllergy,
            StudentRegious, StudentSchool); 

        } else if (userType == UserType.Teacher) {
            string TeacherYearOld = InputTeacherYearOld();
            string TeacherPosition = InputTeacherPosition();
            string TeacherAllergy = InputTeacherAllergy();
            string TeacherRegious = InputTeacherRegious();
            string TeacherCar = InputTeacherCar();
            string TeacherCarNumber = InputTeacherCarNumber();
            //string IsAdmin = InputAdminAnswer();
            //string AdminEmail = InputAdminEmail();
            //string AdminPassword = InputAdminPassword();

            return new Teacher(nameprefix, name, surname, userType, 
            TeacherYearOld,TeacherPosition, TeacherAllergy,
            TeacherRegious, TeacherCar,TeacherCarNumber);   

            //return new AdminList(AdminEmail, AdminPassword,userType);  
            
        }

        return new User(nameprefix, name, surname,userType);
    }
    

    private UserType InputUserType() {
        Console.Write("Input User Type 1 = Current Student, 2 = Student, 3 = Teacher: ");

        int typeNumber = int.Parse(Console.ReadLine());

        UserType userType = (UserType)(typeNumber);

        return userType;
    }

    private string InputNamePrefix() {
        Console.Write("Input name prefix (Only Mr,Ms,Mrs is available): ");

        return Console.ReadLine();
    }

    private string InputName() {
        Console.Write("Input name: ");

        return Console.ReadLine();
    }

    private string InputSurName() {
        Console.Write("Input surname: ");

        return Console.ReadLine();
    }

    private void PrintHeaderRegisterScreen() {
        Console.WriteLine("Register Menu");
        Console.WriteLine("-------------------");
    }
    
    //Current Student Part
    private string InputCurrentStudentID() {
        Console.Write("Input current student ID: ");

        return Console.ReadLine();
    }

    private string InputCurrentStudentYearOld() {
        Console.Write("Input year old: ");

        return Console.ReadLine();
    }

    private string InputCurrentStudentAllergy() {
        Console.Write("Input your alletgy: ");

        return Console.ReadLine();
    }

    private string InputCurrentStudentRegious() {
        Console.Write("Input your regious (Type Only Buddism,Christan,Islam and ETC.): ");

        return Console.ReadLine();
    }
    
    //Student Part
    private string InputStudentYearOld() {
        Console.Write("Input year old: ");

        return Console.ReadLine();
    }

    private string InputStudentGrade() {
        Console.Write("Input student grade (Type Only M4, M5, M6): ");

        return Console.ReadLine();
    }

    private string InputStudentAllergy() {
        Console.Write("Input your alletgy: ");

        return Console.ReadLine();
    }

    private string InputStudentRegious() {
        Console.Write("Input your regious (Type Only Buddism,Christan,Islam and ETC.): ");

        return Console.ReadLine();
    }

    private string InputStudentSchool() {
        Console.Write("Input your school name: ");

        return Console.ReadLine();
    }

    //Teacher Part
    private string InputTeacherYearOld() {
        Console.Write("Input year old: ");

        return Console.ReadLine();
    }

    private string InputTeacherPosition() {
        Console.Write("Input teacher position (Type Only A, B, C): ");

        return Console.ReadLine();
    }

    private string InputTeacherAllergy() {
        Console.Write("Input your alletgy: ");

        return Console.ReadLine();
    }

    private string InputTeacherRegious() {
        Console.Write("Input your regious (Type Only Buddism,Christan,Islam and ETC.): ");

        return Console.ReadLine();
    }

    private string InputTeacherCar() {
        Console.Write("Have car (Type 'Yes' or 'No'): ");

        return Console.ReadLine();
    }

    private string InputTeacherCarNumber() {
        Console.Write("Input your car number (Type '-' if not): ");

        return Console.ReadLine();
    }




}