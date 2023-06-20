using projet_stage.IServices;
using projet_stage.IDAO;
using projet_stage.models;
namespace projet_stage.Services
{
    public class MaterialService : IMaterialService
    {
        private IMaterialDAO imaterialdao;
        public MaterialService(IMaterialDAO imaterialdao)
        {
            this.imaterialdao = imaterialdao;
        }

        public Material GetById(int id)
        {
            return imaterialdao.GetById(id);
        }
        public Material Update(int id, Material material)
        {
            if (id != material.Id)
                throw new Exception("Not Valid Id");
            else
                return imaterialdao.Update(material);

        }
        public Material Create(Material material)
        {
            return imaterialdao.Create(material);
        }
        public void Delete(int id)
        {
            imaterialdao.Delete(id);
        }
        public IEnumerable<Material> GetMaterial()
        {
            return imaterialdao.GetMaterial();
        }

    }
}
