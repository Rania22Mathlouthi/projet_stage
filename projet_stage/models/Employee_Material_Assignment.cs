using System.ComponentModel.DataAnnotations;
using projet_stage.DTO;

namespace projet_stage.models
{
    public class Employee_Material_Assignment
    {
        public Employee_Material_Assignment(Employee_Material_AssignmentsDTO employee_Material_AssignmentDTO)
        {
            this.Id = employee_Material_AssignmentDTO.Id;
            this.Id_Employee = employee_Material_AssignmentDTO.Id_Employee;
            this.Id_Material = employee_Material_AssignmentDTO.Id_Material;
            this.Start_Date = employee_Material_AssignmentDTO.Start_Date;
            this.End_Date = employee_Material_AssignmentDTO.End_Date;
            if (employee_Material_AssignmentDTO.Employee != null)
            { this.Employee = new Employee(employee_Material_AssignmentDTO.Employee); }
            if (employee_Material_AssignmentDTO.Material != null)
            { this.Material = new Material(employee_Material_AssignmentDTO.Material); }
        }
        public Employee_Material_Assignment() { }   
        public int Id { get; set; }

        [Required]
        public DateTime? Start_Date { get; set; }

        public virtual Employee? Employee { get; set; }

        public int? Id_Employee { get; set; }
        public virtual Material? Material { get; set; }

        public int? Id_Material { get; set; }
        public DateTime? End_Date { get; set; }


    }
}
