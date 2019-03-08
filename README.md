# Practice: List employees working at a company

Using C# classes, you need to create custom types to represent an `Employee` and a `Company`. Then you will create some employees, hire them into the company and then display a simple report showing the employee names and their titles.

#### Instructions
1. Create a custom type for `Employee`. An employee has the following properties.
- First name (string)
- Last name (string)
- Title (string)
- Start date (DateTime)

2. Create a custom type for `Company`. A company has the following properties.
- Date founded (DateTime)
- Company name (string)
- Employees (List<Employee>)

3. The `Company` class should also have a `ListEmployees()` method which outputs the name of each employee to the console.

4. In the `Main` method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.
