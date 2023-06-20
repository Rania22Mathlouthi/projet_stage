using projet_stage.models;
using System.ComponentModel.DataAnnotations;

namespace projet_stage.DTO
{
    public class EmployeeDTO
    {
        public EmployeeDTO() { }
        public EmployeeDTO(Employee employee) 
        {
            this.Id = employee.Id;
            this.Name = employee.Name;  
            this.Email = employee.Email;
            this.Prename = employee.Prename;
            this.CIN = employee.CIN;
            this.Phone_Number = employee.Phone_Number;
            this.Emp_Function = employee.Emp_Function;
            this.Home_Adress = employee.Home_Adress;
        }

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Prename { get; set; }
        public string? CIN { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Home_Adress { get; set; }
        public string? Emp_Function { get; set; }


    }

}

