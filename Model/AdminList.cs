using System.Collections.Generic;
using System;

class AdminList {
    private List<Admin> adminList;

    public AdminList() {
        this.adminList = new List<Admin>();
    }

    public void AddNewAdmin(Admin admin) {
        this.adminList.Add(admin);
    }
}