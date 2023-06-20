using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projet_stage.models;
using projet_stage.Data;
using projet_stage.DTO;
using projet_stage.IServices;
namespace projet_stage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService iemployeeservice;
        public EmployeeController(IEmployeeService iemployeeservice)
            => this.iemployeeservice = iemployeeservice;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<EmployeeDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetEmployee()
        {
            IEnumerable<EmployeeDTO> list = this.iemployeeservice.GetEmployee().Select(a => new EmployeeDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(EmployeeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            EmployeeDTO EmployeeDTO = new EmployeeDTO(this.iemployeeservice.GetById(id));
            return Ok(EmployeeDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(EmployeeDTO employeeDTO)
        {
            Employee Employee = this.iemployeeservice.Create(new Employee(employeeDTO));
            return Ok(new EmployeeDTO(Employee));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, EmployeeDTO employeeDTO)
        {

            employeeDTO = new EmployeeDTO(this.iemployeeservice.Update(id, new Employee(employeeDTO)));
            return Ok(employeeDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.iemployeeservice.Delete(id);

            return Ok(true);

        }

    }
}
