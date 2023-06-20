using Microsoft.EntityFrameworkCore;
using projet_stage.Data;
using projet_stage.IDAO;
using projet_stage.models;

namespace projet_stage.DAO
{
    public class Employee_Material_AssignmentsDAO : IEmployee_Material_AssignmentsDAO
    {
        private ModelDbContext Context;
        public Employee_Material_AssignmentsDAO(ModelDbContext context)
        {
            this.Context = context;

        }
        public IEnumerable<Employee_Material_Assignment> GetEmployee_Material_Assignment()
        {
            return this.Context.Assignments.ToList();
        }
        public Employee_Material_Assignment GetById(int id)
        {
            IQueryable<Employee_Material_Assignment> categories = this.Context.Assignments.Where(e => e.Id == id);
            return categories.SingleOrDefault();
        }
        public Employee_Material_Assignment Create(Employee_Material_Assignment employee_Material_Assignment)
        {
            Employee_Material_Assignment proxy = this.Context.Assignments.CreateProxy();

            this.Context.Entry(proxy).CurrentValues.SetValues(employee_Material_Assignment);
            this.Context.Assignments.Add(proxy);
            this.Context.SaveChanges();

            return employee_Material_Assignment;





        }
        public Employee_Material_Assignment Update(Employee_Material_Assignment employee_Material_Assignment)
        {
            this.Context.Update(employee_Material_Assignment);
            this.Context.SaveChanges(true);
            return employee_Material_Assignment;
        }
        public void Delete(int id)
        {
            Employee_Material_Assignment toDelete = this.Context.Assignments.Where(e => e.Id == id).SingleOrDefault();
            if (toDelete == null)
            {
                return;
            }
            this.Context.Assignments.Remove(toDelete);
            this.Context.SaveChanges();

        }
    }
}
