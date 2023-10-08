
using System.Globalization;

namespace CursoParte02.Section14.Exercises.ExerciseIComparable.Entities;

internal class Employee : IComparable
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string EmployeeCSV)
    {
        string[] vect = EmployeeCSV.Split(',');
        Name = vect[0];
        Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
    }

    public override string ToString()
    {
        return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }

    public int CompareTo(object? obj)
    {
        if(!(obj is Employee))
        {
            throw new ArgumentException("Comparing error: argument is not an Employee");
        }

        Employee employeeToCompare = obj as Employee;
        return Name.CompareTo(employeeToCompare.Name);
    }
}
