enum Menu
{
    Register = 1, GetListPersons, Login
}

enum MenuII
{
    Register = 1, CollegeStudentInfo, StudentInfo, TeacherInfo, Logout
}

class Program
{
    static RegisterInfoList registerList;

    static void Main(string[] args)
    {
        PrepareRegisterListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen()
    {
        Console.Clear();

        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintFirstListMenu()
    {
        Console.WriteLine("Welcome to Idea Camp 2022");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Get Exhibitor List.");
        Console.WriteLine("3. Login");
        Console.WriteLine("Any number to end this program.");
        Console.WriteLine("*******************************************************");
    }

    static void PrintSecondListMenu()
    {
        Console.WriteLine("Welcome to Idea Camp 2022");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. College Students Info");
        Console.WriteLine("3. Students Info");
        Console.WriteLine("4. Teachers Info");
        Console.WriteLine("5. Logout");
        Console.WriteLine("*******************************************************");
    }

    static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine())); 

        PresentMenu(menu);
    }

    static void InputMenuIIFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        MenuII menuII = (MenuII)(int.Parse(Console.ReadLine())); 

        PresentMenu(menuII);
    }

    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.Register:
                ShowInputRegister();
                break;

            case Menu.GetListPersons:
                ShowStatistics();
                break;

            case Menu.Login:
                Login();
                break;

            default:
                break;
        }
    }

     static void PresentMenu(MenuII menuII)
    {
        switch (menuII)
        {
            case MenuII.Register:
                ShowInputRegister();
                break;

            case MenuII.CollegeStudentInfo:
               ShowCollegeStudentInfo();
                break;

            case MenuII.StudentInfo:
               ShowStudentInfo();
                break;

            case MenuII.TeacherInfo:
               ShowTeacherInfo();
                break;

            case MenuII.Logout:
                Logout();
                break;

            default:
                BlackToMenuII();
                break;
        }
    }

     static void ShowInputRegister()
    {
        Console.Clear();

        Console.WriteLine("Register for join Idea camp2022");
        Console.WriteLine("*****************************************");

        Console.WriteLine("Input Your Type");
        Console.WriteLine("1.College Student.");
        Console.WriteLine("2.Student.");
        Console.WriteLine("3.Teacher.");
            for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    InputCollegeStudentInfoFromKeyboard();
                    i++;
                }

                else if (s == 2)
                {
                    InputStudentInfoFromKeyboard();
                    i++;
                }

                else if (s == 3)
                {
                    InputTeacherInfoFromKeyboard();
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
          BlackToMenu();
    } 

    static void InputCollegeStudentInfoFromKeyboard()
    {
        bool checkAdmin;
        CollegeStudentInfo collegeStudentCamp = new CollegeStudentInfo(InputTitle(), InputName(), InputLast(),InputStudentID(), InputAge(), InputAllergic(), InputReligion(), checkAdmin = CheckAdmin(), Email(checkAdmin), Password(checkAdmin));
        Program.registerList.AddNewPerson(collegeStudentCamp);
    }

    static void InputStudentInfoFromKeyboard()
    {
        StudentInfo studentCamp = new StudentInfo(InputTitle(), InputName(), InputLast(), InputAge(), InputEducationLevel(), InputAllergic(), InputReligion(), InputSchool());
        Program.registerList.AddNewPerson(studentCamp);
    }

    static void InputTeacherInfoFromKeyboard()
    {
        bool checkAdmin;
        TeacherInfo teacherCamp = new TeacherInfo(InputTitle(), InputName(), InputLast(), InputAge(), InputJobPosition(), InputAllergic(), InputReligion(), InputNumberPlate(), checkAdmin = CheckAdmin(), Email(checkAdmin), Password(checkAdmin));
        Program.registerList.AddNewPerson(teacherCamp);
    }

    static void Login()
    {
        Console.WriteLine("Login");
        Console.WriteLine("***************************");
        Console.WriteLine("Input Email: ");
        string mail = Console.ReadLine();
        Console.WriteLine("Input Password: ");
        string pass = Console.ReadLine();

        if(mail == "exit")
        {
            PrintMenuScreen();
        }
        else if(Program.registerList.CheckLogin(mail, pass))
        {
            BlackToMenuII();
        }
        else
        {
            Login();
        }
    }

    static void ShowStatistics()
    {
        Console.Clear();
        Console.WriteLine("Show Person");
        Console.WriteLine("***************************");

        Program.registerList.CountTeacher();
        Program.registerList.CountStudent();
        Program.registerList.CountCollegeStudent();
        Program.registerList.CountStudent4();
        Program.registerList.CountStudent5();
        Program.registerList.CountStudent6();

        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenu();
    }

       static void ShowCollegeStudentInfo()
    {
        Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");

        Program.registerList.FetchCollegeStudentList();

        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();


    }

    static void ShowStudentInfo()
    {
        Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");

        Program.registerList.FetchStudentList();

        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();

    }

    static void ShowTeacherInfo()
    {
        Console.Clear();
        Console.WriteLine("Show Info");
        Console.WriteLine("***************************");

        Program.registerList.FetchTeacherList();

        Console.WriteLine("Input any key to back to menu.");
        Console.ReadLine();
        BlackToMenuII();

    }

    static void Logout()
    {
        Console.Clear();
        BlackToMenu();
    }

    static void BlackToMenu()
    {
        Console.Clear();
        PrintFirstListMenu();
        InputMenuFromKeyboard();
    }

    static void BlackToMenuII()
    {
        Console.Clear();
        PrintSecondListMenu();
        InputMenuIIFromKeyboard();
    }

     static void PrepareRegisterListWhenProgramIsLoad()
    {
        Program.registerList = new RegisterInfoList();
    }

    static string InputName()
    {
        Console.Write("Name: ");

        return Console.ReadLine();
    }

    static string InputStudentID()
    {
        Console.Write("StudentID: ");

        return Console.ReadLine();
    }

    static string InputLast()
    {
        Console.Write("Last Name: ");

        return Console.ReadLine();
    }

    static string InputAge()
    {
        Console.Write("Age: ");

        return Console.ReadLine();
    }

    static string InputAllergic()
    {
        Console.Write("Allergy: ");

        return Console.ReadLine();
    }

    static string InputSchool()
    {
        Console.Write("School: ");

        return Console.ReadLine();
    }

    static string InputEmail()
    {
       Console.Write("Email: ");

        return Console.ReadLine(); 
    }

    static string InputPassword()
    {
       Console.Write("Password: ");

        return Console.ReadLine(); 
    }

    static bool CheckAdmin()
    {
        Console.WriteLine("Is you Admin ?");
        Console.WriteLine("Type Yes or No");

                string s = Console.ReadLine();
                if (s == "Yes" || s == "yes")
                {
                    return true;
                }

                else if (s == "No" || s == "no")
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Please Enter only Yes or No :"); 
                    return CheckAdmin();            
                }
    }

    static string Email(bool checkAdmin)
    {
        if(checkAdmin == true)
        {
            return InputEmail();
        }

        else 
        {
            return null;
        }
    }

    static string Password(bool checkAdmin)
    {
        if(checkAdmin == true)
        {
            return InputPassword();
        }

        else 
        {
            return null;
        }
    }

    static string InputTitle()
    {
        Console.WriteLine("Input Your Title Name");
        Console.WriteLine("1.Mr.");
        Console.WriteLine("2.Mrs.");
        Console.WriteLine("3.Miss.");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "Mr.";
                    i++;
                }

                else if (s == 2)
                {
                    return "Mrs.";
                    i++;
                }

                else if (s == 3)
                {
                    return "Miss.";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }

    static string InputReligion()
    {
        Console.WriteLine("Input Your Religion");
        Console.WriteLine("1.Buddhism.");
        Console.WriteLine("2.Christianity.");
        Console.WriteLine("3.Islam.");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "Buddhism";
                    i++;
                }

                else if (s == 2)
                {
                    return "Christianity";
                    i++;
                }

                else if (s == 3)
                {
                    return "Islam";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }

    static string InputJobPosition()
    {
        Console.WriteLine("Input Your Job Position");
        Console.WriteLine("1.Dean.");
        Console.WriteLine("2.Head of department.");
        Console.WriteLine("3.Full-time teacher.");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "Dean";
                    i++;
                }

                else if (s == 2)
                {
                    return "Head of department";
                    i++;
                }

                else if (s == 3)
                {
                    return "Full-time teacher";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }

    static string InputEducationLevel()
    {
        Console.WriteLine("Input Your Education Level");
        Console.WriteLine("1.M.4");
        Console.WriteLine("2.M.5");
        Console.WriteLine("3.M.6");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  "M.4";
                    i++;
                }

                else if (s == 2)
                {
                    return "M.5";
                    i++;
                }

                else if (s == 3)
                {
                    return "M.6";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-3 :");             
                }
            }
            return null;
    }

    static string InputNumberPlate()
    {
        Console.WriteLine("Are you have car?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2.No");
        for(int i = 0; i  <= 0;)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    return  Console.ReadLine();
                    i++;
                }

                else if (s == 2)
                {
                    return "No";
                    i++;
                }

                else
                {
                    Console.WriteLine("Please Enter only 1-2 :");             
                }
            }
            return null;
    }

}
