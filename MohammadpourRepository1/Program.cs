// See https://aka.ms/new-console-template for more information
using MohammadpourRepository1;

Console.WriteLine("Hello, World!");

Employee employee = new Employee();

employee.name = "REza";
employee.family = "MOhammadpour";

employee.id = 1200;


Console.WriteLine($"Employee: {employee.id}, {employee.name}, {employee.family}");
