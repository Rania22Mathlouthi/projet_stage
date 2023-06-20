using projet_stage.Data;
using projet_stage.IDAO;
using projet_stage.models;
using System.Reflection.Metadata.Ecma335; 

namespace projet_stage.DAO
{
    public class EmployeeDAO : IEmployeeDAO
    {
        private ModelDbContext Context;
        public EmployeeDAO(ModelDbContext context)
        {
            this.Context = context;
        }
        public IEnumerable<Employee> GetEmployee()
        {
            return this.Context.Employees.ToList();
        }
        public Employee GetById(int id)
        {
            IQueryable<Employee> categories = this.Context.Employees.Where(e => e.Id == id);
            return categories.SingleOrDefault();
        }
        public Employee Create(Employee employee)
        {
            this.Context.Employees.Add(employee);
            this.Context.SaveChanges();
            return employee;
        }
        public Employee Update(Employee employee)
        {
            this.Context.Update(employee);
            this.Context.SaveChanges(true);
            return employee;
        }
        public void Delete(int id)
        {
            Employee toDelete = this.Context.Employees.Where(e=>e.Id==id).SingleOrDefault();
            if (toDelete == null)
            {
                return;
            }
                this.Context.Employees.Remove(toDelete);
                this.Context.SaveChanges();
            
        }
    }
}
