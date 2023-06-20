using System.ComponentModel.DataAnnotations;
using projet_stage.DTO;
namespace projet_stage.models
{
    public class Employee
    {
        public Employee() {
            Assignments = new HashSet<Employee_Material_Assignment>();
        }
        public Employee(EmployeeDTO employeeDTO)
        {
            this.Id = employeeDTO.Id;
            this.Name = employeeDTO.Name;
            this.Email = employeeDTO.Email;
            this.Prename = employeeDTO.Prename;
            this.CIN = employeeDTO.CIN;
            this.Phone_Number = employeeDTO.Phone_Number;
            this.Emp_Function = employeeDTO.Emp_Function;
            this.Home_Adress = employeeDTO.Home_Adress;
        }

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Prename { get; set; }
        public virtual ICollection<Employee_Material_Assignment>? Assignments { get; set; }
        public string? CIN { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Home_Adress { get; set; }
        public string? Emp_Function { get; set; }
        

    }
}
