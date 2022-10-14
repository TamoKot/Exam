class Admin {
    protected string AdminEmail;
    protected string AdminPassword;
    

    public Admin(string AdminEmail, string AdminPassword) {
        this.AdminEmail = AdminEmail;
        this.AdminPassword = AdminPassword;
        
    }

    public string GetAdminEmail() {
        return this.AdminEmail;
    }

    public string GetAdminPassword() {
        return this.AdminPassword;
    }

    


}