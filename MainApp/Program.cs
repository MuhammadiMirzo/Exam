using Domain.Models;
using Services.Service;
var studentservice = new StudentService();

var stu = new Student()
{
    Id = 1,
    Address = "Muhammad",
    BirthDate = DateTime.Now,
     FatherName = "asdf",
     FirstName = "zokir",
     LastName = "shokir",
     Phone = "90887864"
};
studentservice.Add(stu);
var stu2 = new Student()
{
    Id = 2,
    Address = "ammad",
    BirthDate = DateTime.Now,
    FatherName = "asdf",
    FirstName = "kir",
    LastName = "shor",
    Phone = "901212264"

};
studentservice.Add(stu2);

var stu3 = new Student()
{
    Id = 3,
    Address = "sdfasfds",
    BirthDate = DateTime.Now,
    FatherName = "asdf",
    FirstName = "fdasfdsf",
    LastName = "sasdf",
    Phone = "901212264"

};
// studentservice.Update(stu3,2);
// var list = studentservice.GetStudents();
// foreach (var item in list)
// {
//     Console.WriteLine(item.Id+" "+ item.FirstName+" "+item.LastName+" ");
// }

// var getstudent = studentservice.GetStudentById(1);
// Console.Write(getstudent.Id+" "+ getstudent.FirstName+" "+getstudent.LastName+" ");
studentservice.Delete(2);
 var list = studentservice.GetStudents();
foreach (var item in list)
{
    Console.WriteLine(item.Id+" "+ item.FirstName+" "+item.LastName+" ");
}