public class Student
{
    public int Id{get;set;}
    public string FirstName{get;set;}=null!;
    public string LastName{get;set;}=null!;
    public int Age{get;set;}
    public string? Gender{get;set;}
    public string? Status;
    public DateTime DateOfStart{get;set;}
    public DateTime DateOfFinish{get;set;}
}