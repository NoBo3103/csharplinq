﻿using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	IList<Employee> employeeList = new List<Employee>();
    IList<Salary> salaryList = new List<Salary>();
    public Program()
    {
		List<Employee> employeeList = new List<Employee>() { 
			new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
			new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
			new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
			new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
			new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
			new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
			new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}			
		};
		
		List<Salary> salaryList = new List<Salary>() {
			new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
			new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
			new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
			new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
			new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
			new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
			new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
			new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
		};
	}
	

	public static void Main()
	{	
		Program program = new Program();
		
		program.Task1();
		
		program.Task2();
		
		program.Task3();
	}
	
	public void Task1(){
		//Implementation
        var emp = from s in employeeList
							  
							  select s;
		Console.WriteLine("\nTotal Salary List:");
        foreach(Employee s in emp){			
			Console.WriteLine(s.EmployeeFirstName + s.EmployeeLastName);
		}

	}
	
	public void Task2(){
		 //Implementation
	}
	
	public void Task3(){
		 //Implementation
	}
}

public enum SalaryType{
	Monthly,
	Performance,
	Bonus
}

public class Employee{
	public int EmployeeID { get; set; }
	public string EmployeeFirstName { get; set; }
	public string EmployeeLastName { get; set; }
	public int Age { get; set; }	
}

public class Salary{
	public int EmployeeID { get; set; }
	public int Amount { get; set; }
	public SalaryType Type { get; set; }
}
