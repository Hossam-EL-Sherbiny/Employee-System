// See https://aka.ms/new-console-template for more information

using Employee_Management_System;

// Create a list to store employee objects..
List<Employee> employees = new List<Employee>();

//  Add some employee to the list..
employees.Add(new Employee("Hossam", "Istanbul", 25000.0, "No: 26", 10));
employees.Add(new Employee("Muhammed", "Zonguldak", 25000.0, "No: 12", 2));
employees.Add(new Employee("Hasan", "Akara", 44000.0, "No: 54", 4));
employees.Add(new Employee("Hamza", "Iskendarun", 54000.0, "No: 5", 1));
employees.Add(new Employee("Ali", "Isparta", 21000.0, "No:2", 6));

// Display the information for each employee in the list.. 
foreach(Employee employee in employees)
{
    employee.Display();
}

employees[1].UpdateSalary(72000.0);
employees[2].UpdateAddress("Turkey");
employees[0].UpdateDepartment("No: 27");

// Display the information for each employee in the list after the updates
foreach (Employee employee in employees)
{
    employee.Display();
}

employees[2].Delete();

// Remove the employee object from the list
employees.RemoveAt(0);

// Display the information for each employee in the list after the deletion
foreach (Employee employee in employees)
{
    employee.Display();
}
