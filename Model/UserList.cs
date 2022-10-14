using System.Collections.Generic;
using System;

class UserList {
    private List<User> userList;

    public UserList() {
        this.userList = new List<User>();
    }

    public void AddNewUser(User user) {
        this.userList.Add(user);
    }

    public void FetchUserList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(User user in this.userList) {
            if (user is CurrentStudent) {
                Console.WriteLine("Prefix: {0} Name: {1} Surname: {2}  \n Type: Current Student \n",user.GetNamePrefix(), user.GetName(), user.GetSurName());
            } else if (user is Student) {
                Console.WriteLine("Prefix: {0} Name: {1} Surname: {2} \n Type: Student \n",user.GetNamePrefix(), user.GetName(), user.GetSurName());
            }
            else if (user is Teacher) {
                Console.WriteLine("Prefix: {0} Name: {1} Surname: {2} \n Type: Teacher \n",user.GetNamePrefix(), user.GetName(), user.GetSurName());
            }
        }
    }
}