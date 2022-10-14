enum UserType {
    CurrentStudent = 1,
    Student,
    Teacher
}

class User {
    protected string nameprefix;
    protected string name;
    protected string surname;
    protected UserType type;

    public User(string nameprefix, string name, string surname, UserType type) {
        this.nameprefix = nameprefix;
        this.name = name;
        this.surname = surname;
        this.type = type;
    }

    public string GetNamePrefix() {
        return this.nameprefix;
    }

    public string GetName() {
        return this.name;
    }

    public string GetSurName() {
        return this.surname;
    }

    public UserType GetType() {
        return this.type;
    }


}