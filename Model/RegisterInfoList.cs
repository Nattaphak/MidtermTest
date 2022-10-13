using System.Collections.Generic;

class RegisterInfoList
{
    private List<Info> registerInfoList;

    public RegisterInfoList()
    {
        this.registerInfoList = new List<Info>();
    }

    public void AddNewPerson(Info info)
    {
        this.registerInfoList.Add(info);
        int num = 0;
        num++;
    }

     public void FetchCollegeStudentList()
    {
        Console.WriteLine("List College Student");
        Console.WriteLine("***************************");

        foreach(Info info in this.registerInfoList)
        {
            if(info is CollegeStudentInfo)
            {
                Console.WriteLine("1. {0} {1} {2}", info.GetTitle(), info.GetName(), info.GetLastName());
            }
        }
    }

    public void FetchStudentList()
    {
        Console.WriteLine("List Student");
        Console.WriteLine("***************************");

        foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo)
            {
                Console.WriteLine("1. {0} {1} {2}", info.GetTitle(), info.GetName(), info.GetLastName());
            }
        }
    }

    public void FetchTeacherList()
    {
        Console.WriteLine("List Teacher");
        Console.WriteLine("***************************");

        foreach(Info info in this.registerInfoList)
        {
            if(info is TeacherInfo)
            {
                Console.WriteLine("1. {0} {1} {2}", info.GetTitle(), info.GetName(), info.GetLastName());
            }
        }
    }

    public bool CheckLogin(string email, string password)
    {
         foreach(Info info in this.registerInfoList)
         {
            if(info is TeacherInfo teacherInfo)
            {
                if(teacherInfo.GetEmail() == email && teacherInfo.GetPassword() == password)
                {
                    return true;
                }
            }
            else if(info is CollegeStudentInfo collegeStudentInfo)
            {
                if(collegeStudentInfo.GetEmail() == email && collegeStudentInfo.GetPassword() == password)
                {
                    return true;
                }
            }
         }  
         return false;
    }

    public void CountTeacher()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is TeacherInfo TeacherInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("Teacher : {0}", num);
    }

    public void CountStudent()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo StudentInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("Student : {0}", num);
    }

    public void CountCollegeStudent()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is CollegeStudentInfo collegeStudentInfo)
            {
               num++;
            } 
        }
        Console.WriteLine("College Student : {0}", num);
    }

    public void CountStudent4()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.4")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.4 : {0}", num);
    }

    public void CountStudent5()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.5")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.5 : {0}", num);
    }

    public void CountStudent6()
    {
        int num = 0;
         foreach(Info info in this.registerInfoList)
        {
            if(info is StudentInfo StudentInfo)
            {
               if(StudentInfo.GetEducationLevel() == "M.6")
               {
                    num++;
               }
            } 
        }
        Console.WriteLine("Student M.6 : {0}", num);
    }
}
