namespace WebApp_Kubernetes.Model;
public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}
public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employess { get; set; }
}