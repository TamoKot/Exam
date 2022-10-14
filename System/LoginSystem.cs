using System.Collections.Generic;
using System;

class LoginSystem {

    public void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
        InputLogin();
    }

    public void InputLogin() {
        string Email = InputAdminEmail();
        string Password = InputAdminPassword();
    }

    public string InputAdminEmail() {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    public string InputAdminPassword() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------"); 
    }

}