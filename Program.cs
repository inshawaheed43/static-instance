class Program
{

    static void Main()
    {

        Student Ali = new Student();
        Ali.rollNo = 23;
        Ali.firstname = "Ali";
        Ali.lastname = "Khan";
        Ali.standard = 4;



        Student Zain = new Student();
        Zain.rollNo = 25;
        Zain.firstname = "Zain ";
        Zain.lastname = "Ali";
        Zain.standard = 4;


        Console.WriteLine(Ali.rollNo);
        Console.WriteLine(Ali.firstname);
        Console.WriteLine(Ali.lastname);
        Console.WriteLine(Ali.standard);
        Ali.printFullName();
        Console.WriteLine(Student.schoolName);
        Console.WriteLine(Student.fees);


        Console.WriteLine("------------------------------------------");
        Console.WriteLine(Zain.rollNo);
        Console.WriteLine(Zain.firstname);
        Console.WriteLine(Zain.lastname);
        Console.WriteLine(Zain.standard);
        Zain.printFullName();
        Console.WriteLine(Student.schoolName);
        Console.WriteLine(Student.fees);



    }
}

class Student {
    public int rollNo;
    public string firstname;
    public string lastname;
    public int standard;

    public static int fees = 4000;

    //THIS IS A STATIC VARIABLE//
    public static string schoolName = "ABC School";

    public void printFullName()
    {
        string fullname = this.firstname + " " + this.lastname;

        Console.WriteLine("your full name is {0}", fullname);
    }


    // JO STATIC METHODS OR VARIABLE HEIN UNKE LIE OBJECT CREATE KRNE KI ZAROORT NI 
    // USKE LIE CLASS NAME USE HOTA HAI 

    public static int getFees()
    {
        return fees;

    }

}
