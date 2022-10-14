using System;
using System.Collections.Generic;

enum ChoiceMenu {
    Register = 1,
    GetStat = 2, 
    Login= 3, 
    AllCurrentStudent = 2,
    AllStudent = 3, 
    AllTeacher = 4,
    Logout = 5
}

class MainMenuSystem {

    private RegisterSystem registerSystem;
    private List<User> users;
    private LoginSystem loginSystem;

    public void ShowInResgisterMenu(){
        PrepareListUser();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        Console.Clear();
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }

    private void RouteToMenu(ChoiceMenu menu) {
        if (menu == ChoiceMenu.Register) {
            ShowRegisterScreen();
            PressAnythingToMainMenu();
            ShowMenuScreenInformation();
        } else if (menu == ChoiceMenu.GetStat) {
            Console.WriteLine("Get Stat Menu");
            PressAnythingToMainMenu();
            ShowMenuScreenInformation();
        } else if (menu == ChoiceMenu.Login) {
            ShowLoginScreen();
            ShowResgisterMenu();
            
            
            
        }
    }

    public void PressAnythingToMainMenu() {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to back to main menu: ");
        Console.ReadKey();
    }

    private void PrintHeaderMenuScreen() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("--------------------------");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Get stat person");
        Console.WriteLine("3. Login");
        
    }
    
    public ChoiceMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");
        return (ChoiceMenu)(int.Parse)(Console.ReadLine());
    }


    private void ShowRegisterScreen() {
        this.registerSystem = new RegisterSystem();
        this.registerSystem.ShowRegisterScreen();
         
    }

    private void PrepareListUser() {
        this.users = new List<User>();
    }

    private void ShowLoginScreen() {
        this.loginSystem = new LoginSystem();
        this.loginSystem.ShowLoginScreen();
    }

    //Register Menu Part
    public void ShowResgisterMenu(){
        ShowMenuScreenInformation2();
    }

    private void ShowMenuScreenInformation2() {
        Console.Clear();
        PrintHeaderMenuScreen2();
        PrintListMenuScreen2();
        RouteToMenu2(InputSelectedMenuFromKeyboard2());
    }

    private void RouteToMenu2(ChoiceMenu menu) {
        if (menu == ChoiceMenu.Register) {
            ShowRegisterScreen();
            PressAnythingToMainMenu();
            ShowMenuScreenInformation2();
        } else if (menu == ChoiceMenu.AllCurrentStudent) {
            Console.WriteLine("--------------------------");
            Console.WriteLine("AllCurrentStudent Menu");
            PressAnythingToMainMenu();
            ShowMenuScreenInformation2();
        } else if (menu == ChoiceMenu.AllStudent) {
            Console.WriteLine("--------------------------");
            Console.WriteLine("AllStudent Menu");
            PressAnythingToMainMenu();
            ShowMenuScreenInformation2();
        } else if (menu == ChoiceMenu.AllTeacher) {
            Console.WriteLine("--------------------------");
            Console.WriteLine("AllTeacher Menu");
            PressAnythingToMainMenu();
            ShowMenuScreenInformation2();
        } else if (menu == ChoiceMenu.Logout) {
            ShowInResgisterMenu();
            
        }
    }

    private void PrintHeaderMenuScreen2() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("Registered Edition");
        Console.WriteLine("--------------------------");
    }

    private void PrintListMenuScreen2() {
        Console.WriteLine("1. Register");
        Console.WriteLine("2. All Current Student List");
        Console.WriteLine("3. All Student List");
        Console.WriteLine("4. All Teacher List");
        Console.WriteLine("5. Logout");
        
    }
    
    public ChoiceMenu InputSelectedMenuFromKeyboard2() {
        Console.Write("Select Menu: ");
        return (ChoiceMenu)(int.Parse)(Console.ReadLine());
    }


}
    
