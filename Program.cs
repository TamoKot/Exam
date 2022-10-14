namespace Exam
{
    class Program
    {
        static MainMenuSystem mainMenuSystem;
        

        static void Main(string[] args) {
            PrepareMainMenuSystem();
            ShowInResgisterMenu();
   
        }
           

        static void PrepareMainMenuSystem() {
            Program.mainMenuSystem = new MainMenuSystem();
        }

        static void ShowInResgisterMenu() {
            Program.mainMenuSystem.ShowInResgisterMenu();
        }

        
    }
}