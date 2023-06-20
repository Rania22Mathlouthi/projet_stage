using projet_stage.IServices;
using projet_stage.IDAO;
using projet_stage.models;

namespace projet_stage.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeDAO iemployeedao;
        public EmployeeService(IEmployeeDAO iemployeedao)
        {
            this.iemployeedao = iemployeedao;
        }

        public Employee GetById(int id)
        {
            return iemployeedao.GetById(id);
        }
        public Employee Update(int id , Employee employee)
        {
            if (id != employee.Id)
                throw new Exception("Not Valid Id");
            else
                return iemployeedao.Update(employee);

        }
        public Employee Create(Employee employee)
        {
            return iemployeedao.Create(employee);
        }
        public void Delete(int id)
        {
             iemployeedao.Delete(id);
        }
        public IEnumerable<Employee> GetEmployee() 
        {   
            return iemployeedao.GetEmployee();
        }
    }
}
