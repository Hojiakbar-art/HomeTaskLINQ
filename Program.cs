List<Student> students = new()
{
    new Student()
    {
        Id = 1,
        FirstName = "Usmon",
        LastName = "Usmonov",
        Age = 17,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2026, 1, 10),
        DateOfFinish = new DateTime(2026, 7, 10)
    },

    new Student()
    {
        Id = 2,
        FirstName = "Akbar",
        LastName = "Sharifov",
        Age = 20,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2026, 2, 15),
        DateOfFinish = new DateTime(2026, 8, 15)
    },

    new Student()
    {
        Id = 3,
        FirstName = "Muhammad",
        LastName = "Nematov",
        Age = 18,
        Gender = "Male",
        Status = "Finished",
        DateOfStart = new DateTime(2025, 9, 1),
        DateOfFinish = new DateTime(2026, 3, 1)
    },

    new Student()
    {
        Id = 4,
        FirstName = "Fatima",
        LastName = "Karimova",
        Age = 21,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2026, 3, 20),
        DateOfFinish = new DateTime(2026, 9, 20)
    },

    new Student()
    {
        Id = 5,
        FirstName = "Sara",
        LastName = "Rahmonova",
        Age = 16,
        Gender = "Female",
        Status = "Inactive",
        DateOfStart = new DateTime(2025, 10, 5),
        DateOfFinish = new DateTime(2026, 4, 5)
    }
};
// Task 1
var genders1=
    (from gender in students 
    where gender.Gender=="Male" 
    select gender).ToList();
var genders2=students.Where(x=>x.Gender=="Male").ToList();
// Task 2
var actives1=
    (from active in students where active.Status=="Inactive" select active).ToList();
var actives2=students.Where(x=>x.Status=="Inactive").ToList();
// Task 3
var ageyear1 = (from age in students where DateTime.UtcNow.Year-age.Age > 2000 select age).ToList();
var ageyear2=students.Where(x=>DateTime.UtcNow.Year-x.Age > 2000).ToList();
// Task 4
var age3=(from age1 in students where age1.Age>20 select age1).ToList();
var age2=students.Where(x=>x.Age>20).ToList();
// Task 5
var start1=(from start in students where (DateTime.UtcNow.Year-start.DateOfStart.Year)==16 select start).ToList();
var start2=students.Where(x=>(DateTime.UtcNow.Year-x.DateOfStart.Year)==16).ToList();
// Task 6
var adult1=(from adult in students where (DateTime.UtcNow.Year-adult.DateOfStart.Year)==8 select adult).ToList();
var adult2=students.Where(x=>(DateTime.UtcNow.Year-x.DateOfStart.Year)==18).ToList();
// Task 7
var letter1=(from letter in students where letter.FirstName.StartsWith("I") select letter).ToList();
var letter2=students.Where(x=>x.FirstName.StartsWith("i")).ToList();
// Task 8).ToList()
var equal1=(from equal in students where equal.FirstName[0]==equal.LastName[0] select equal).ToList();
var equal2=students.Where(x=>x.FirstName[0]==x.LastName[0]).ToList();
// Task 10
var summary1=(from summary in students where summary.Gender!="Female"&&summary.Status=="Inactive"&& summary.DateOfFinish.Year-summary.DateOfFinish.Year>=2 select summary).ToList();
var summary2=students.Where(x=>x.Gender!="Female"&&x.Status=="Inactive"&& x.DateOfFinish.Year-x.DateOfFinish.Year>=2).ToList();