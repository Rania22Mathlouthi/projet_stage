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
    public class Employee_Material_AssignmentsController : ControllerBase
    {
        private IEmployee_Material_AssignmentService iassignments;
        public Employee_Material_AssignmentsController(IEmployee_Material_AssignmentService iassignments)
            => this.iassignments = iassignments;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Employee_Material_AssignmentsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetEmployee_Material_Assignment()
        {
            IEnumerable<Employee_Material_AssignmentsDTO> list = this.iassignments.GetEmployee_Material_Assignment().Select(a => new Employee_Material_AssignmentsDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(Employee_Material_AssignmentsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            Employee_Material_AssignmentsDTO Employee_Material_AssignmentsDTO = new Employee_Material_AssignmentsDTO(this.iassignments.GetById(id));
            return Ok(Employee_Material_AssignmentsDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(Employee_Material_AssignmentsDTO Employee_Material_AssignmentsDTO)
        {
            Employee_Material_Assignment employee_Material_Assignment = this.iassignments.Create(new Employee_Material_Assignment(Employee_Material_AssignmentsDTO));
            return Ok(new Employee_Material_AssignmentsDTO(employee_Material_Assignment));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, Employee_Material_AssignmentsDTO Employee_Material_AssignmentsDTO)
        {

            Employee_Material_AssignmentsDTO = new Employee_Material_AssignmentsDTO(this.iassignments.Update(id, new Employee_Material_Assignment(Employee_Material_AssignmentsDTO)));
            return Ok(Employee_Material_AssignmentsDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.iassignments.Delete(id);

            return Ok(true);

        }

    }
}
