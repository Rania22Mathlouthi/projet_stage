using projet_stage.models;

namespace projet_stage.IDAO
{
    public interface IEmployeeDAO
    {
        public IEnumerable<Employee> GetEmployee();
        public Employee Create(Employee employee);
        public Employee GetById(int id);
        public Employee Update(Employee employee);
        public void Delete(int id);

    }
}
