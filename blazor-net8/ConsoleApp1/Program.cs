// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

MyAppDBContext dBContext = new MyAppDBContext();

//Student student = new Student();
//student.Name = "Farhan";

//dBContext.Students.Add(student);
//dBContext.SaveChanges();

var student2 = dBContext.Students.OrderBy(s=>s.Name).Last();
//student2.Name = "A new Name";
dBContext.Students.Remove(student2);
dBContext.SaveChanges();



