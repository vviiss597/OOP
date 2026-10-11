using StudentApplication;
Students student1 = new Students();
student1.Name = "Ana";
student1.Age = 20;
student1.Career = "Computer Science";

Console.WriteLine($"Student: {student1.Name}");
Console.WriteLine($"Age: {student1.Age}");
Console.WriteLine($"Career: {student1.Career}");

Courses course1 = new Courses();
course1.Name = "OOP";
course1.Credits = 4 ;
course1.Teacher = "Luis";

Console.WriteLine($"Course: {course1.Name}");
Console.WriteLine($"Credits: {course1.Credits}");
Console.WriteLine($"Teacher: {course1.Teacher}");
