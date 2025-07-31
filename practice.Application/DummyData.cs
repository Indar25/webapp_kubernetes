using practice.Application.Dtos;

namespace practice.Application;
public class DummyData
{
    public static List<Department> GetDepartments()
    {
        return new List<Department>
            {
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "HR",
                    Employess = new List<Employee>
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Alice", Salary = 59000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Bob", Salary = 52000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Charlie", Salary = 48000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Diana", Salary = 51000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Evan", Salary = 53000 }
                    }
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "IT",
                    Employess = new List<Employee>
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Frank", Salary = 70000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Grace", Salary = 72000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Henry", Salary = 71000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ivy", Salary = 73000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Jack", Salary = 75000 }
                    }
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Finance",
                    Employess = new List<Employee>
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Kate", Salary = 60000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Leo", Salary = 62000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Mona", Salary = 61000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Nate", Salary = 63000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Olivia", Salary = 64000 }
                    }
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Marketing",
                    Employess = new List<Employee>
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Peter", Salary = 55000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Quinn", Salary = 56000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Rachel", Salary = 57000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Steve", Salary = 58000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tina", Salary = 59000 }
                    }
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Operations",
                    Employess = new List<Employee>
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Uma", Salary = 52000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Victor", Salary = 53000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Wendy", Salary = 54000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Xavier", Salary = 55000 },
                        new Employee { Id = Guid.NewGuid(), Name = "Yara", Salary = 56000 }
                    }
                }
            };
    }
}

