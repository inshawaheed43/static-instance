class Program
{

    static void Main()
    {

        Student Ali = new Student();
        Ali.rollNo = 23;
        Student Zain = new Student();
        Zain.rollNo = 25;
        Console.WriteLine(Ali.rollNo + " " + Zain.rollNo);
    }
}

class Student {
    public int rollNo;
    string firstname;
    string lastname;
    int standard;

}
