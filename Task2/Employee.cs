using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
public class Employee
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private int _salary;
    public Employee(int id, string firstName,string lastName,int salary)
    {
        _id = id;
        _firstName = firstName; 
        _lastName = lastName;
        _salary = salary;
    }
    public int GetId()
    {
        return _id;
    }
    public string GetFirstName()
    {
        return _firstName;
    }
    public string GetLastName()
    {
        return _lastName;
    }
    public string Name()
    {
        return $"{_firstName}{_lastName}";
    }
    public int GetSalary()
    {
        return _salary;
    }
    public void SetSalary(int salary)
    {
        _salary = salary;
    }
    public int GetAnnualSalary()
    {
        return _salary*12;
    } 
    public int RaiseSalary(int procent)
    {
        return ((_salary*procent)/100)+_salary;
    }
    public override string ToString()
    {
        return $"Employee id={_id} name={_firstName} lastname={_lastName} salary{_salary}";
    }
}