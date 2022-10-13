class TeacherInfo: Info
{
    private string jobPosition;
    private string numberPlate;
    private bool checkAdmin;
    private string email;
    private string password;

    public TeacherInfo(string title, string name, string lastname, string age, string jobPosition, string allergic, string religion, string numberPlate, bool checkAdmin, string email, string password)
    :base(title, name, lastname, age, allergic, religion)
    {
        this.numberPlate = numberPlate;
        this.checkAdmin = false;
        this.email = email;
        this.password = password;
    }

    public bool CheckAdmin()
    {
        return this.checkAdmin;
    }

    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
}