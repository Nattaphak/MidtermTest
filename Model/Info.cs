class Info
{
    private string title;
    private string name;
    private string lastname;
    private string age;
    private string allergic;
    private string religion;

    public Info(string title, string name, string lastname, string age, string allergic, string religion)
    {
        this.title = title;
        this.name = name;
        this.lastname = lastname;
        this.age = age;
        this.allergic = allergic;
        this.religion = religion;
    }

    public string GetTitle()
    {
        return this.title;
    } 

    public string GetName()
    {
        return this.name;
    }  

    public string GetLastName()
    {
        return this.lastname;
    }  

    public string GetAge()
    {
        return this.age;
    }  

    public string GetAllergic()
    {
        return this.allergic;
    } 

    public string GetReligion()
    {
        return this.religion;
    } 
}