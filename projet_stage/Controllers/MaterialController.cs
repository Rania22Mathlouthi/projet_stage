using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projet_stage.DTO;
using projet_stage.IServices;
using projet_stage.models;

namespace projet_stage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private IMaterialService imaterialservice;
        public MaterialController(IMaterialService imaterialservice)
            => this.imaterialservice = imaterialservice;

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(List<MaterialDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetMaterial()
        {
            IEnumerable<MaterialDTO> list = this.imaterialservice.GetMaterial().Select(a => new MaterialDTO(a));
            return Ok(list);
        }


        [Route("GetBYId/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(MaterialDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ObjectResult GetById(int id)
        {
            MaterialDTO materialDTO = new MaterialDTO(this.imaterialservice.GetById(id));
            return Ok(materialDTO);
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ObjectResult Create(MaterialDTO materialDTO)
        {
            Material material = this.imaterialservice.Create(new Material(materialDTO));
            return Ok(new MaterialDTO(material));

        }
        [Route("Update/{id}")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ObjectResult Update(int id, MaterialDTO materialDTO)
        {

            materialDTO = new MaterialDTO(this.imaterialservice.Update(id, new Material(materialDTO)));
            return Ok(materialDTO);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ObjectResult Delete(int id)
        {

            this.imaterialservice.Delete(id);

            return Ok(true);

        }
    }
}
