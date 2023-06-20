using projet_stage.models;

namespace projet_stage.IServices
{
    public interface IEmployee_Material_AssignmentService
    {
        public IEnumerable<Employee_Material_Assignment> GetEmployee_Material_Assignment();
        public Employee_Material_Assignment Create(Employee_Material_Assignment assignment);
        public Employee_Material_Assignment GetById(int id);
        public Employee_Material_Assignment Update(int id ,Employee_Material_Assignment assignment);
        public void Delete(int id);
    }
}
