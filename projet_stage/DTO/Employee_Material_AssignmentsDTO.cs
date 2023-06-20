using projet_stage.IServices;
using projet_stage.models;
using System.ComponentModel.DataAnnotations;

namespace projet_stage.DTO
{
    public class Employee_Material_AssignmentsDTO 
    {
        public Employee_Material_AssignmentsDTO() { }
        public Employee_Material_AssignmentsDTO(Employee_Material_Assignment employee_Material_Assignment) 
        {
            this.Id = employee_Material_Assignment.Id;
            this.Id_Employee = employee_Material_Assignment.Id_Employee;
            this.Id_Material = employee_Material_Assignment.Id_Material;
            this.Start_Date = employee_Material_Assignment.Start_Date;
            this.End_Date = employee_Material_Assignment.End_Date;
            if (employee_Material_Assignment.Employee != null)
            { this.Employee = new EmployeeDTO(employee_Material_Assignment.Employee); }
            if (employee_Material_Assignment.Material != null)
            { this.Material = new MaterialDTO(employee_Material_Assignment.Material); }

        }

        public int Id { get; set; }
        [Required]
        public DateTime? Start_Date { get; set; }

        public virtual EmployeeDTO? Employee { get; set; }

        public int? Id_Employee { get; set; }
        public virtual MaterialDTO? Material { get; set; }

        public int? Id_Material { get; set; }
        public DateTime? End_Date { get; set; }

    }
}
