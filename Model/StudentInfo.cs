class StudentInfo: Info
{
    private string educationLevel;
    private string school;

    public StudentInfo(string title, string name, string lastname, string age, string educationLevel, string allergic, string religion, string school)
    :base(title, name, lastname, age, allergic, religion)
    {
        this.educationLevel = educationLevel;
        this.school = school;
    }

    public string GetEducationLevel()
    {
        return this.educationLevel;
    }

    public string GetSchool()
    {
        return this.school;
    }
}