class CollegeStudentInfo: Info
{
    private string studentID;
    private bool checkAdmin;
    private string email;
    private string password;

    public CollegeStudentInfo(string title, string name, string lastname, string studentID, string age, string allergic, string religion, bool checkAdmin, string email, string password)
    :base(title, name, lastname, age, allergic, religion)
    {
        this.studentID = studentID;
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