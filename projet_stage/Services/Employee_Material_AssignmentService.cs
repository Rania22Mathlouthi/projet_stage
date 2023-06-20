using projet_stage.IServices;
using projet_stage.IDAO;
using projet_stage.models;
using Microsoft.AspNetCore.Mvc;



namespace projet_stage.Services
{
    public class Employee_Material_AssignmentService :IEmployee_Material_AssignmentService
    {
        private IEmployee_Material_AssignmentsDAO iassignments;
        public Employee_Material_AssignmentService(IEmployee_Material_AssignmentsDAO iassignments)
        {
            this.iassignments = iassignments;
        }

        public Employee_Material_Assignment GetById(int id)
        {
            return iassignments.GetById(id);
        }
        public Employee_Material_Assignment Update(int id, Employee_Material_Assignment assignment)
        {
            if (id != assignment.Id)
                throw new Exception("Not Valid Id");
            else
                return iassignments.Update(assignment);

        }
        public Employee_Material_Assignment Create(Employee_Material_Assignment assignment)
        {
            return iassignments.Create(assignment);
        }
        public void Delete(int id)
        {
            iassignments.Delete(id);
        }
        public IEnumerable<Employee_Material_Assignment> GetEmployee_Material_Assignment()
        {
            return iassignments.GetEmployee_Material_Assignment();
        }


    }
}
