using projet_stage.models;

namespace projet_stage.IServices
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetEmployee();


        public Employee Create(Employee employee);


        public Employee GetById(int id);


        public Employee Update(int id ,Employee employee);


        public void Delete(int id);
    }
}
