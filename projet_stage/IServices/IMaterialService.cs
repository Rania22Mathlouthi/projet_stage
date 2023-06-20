using projet_stage.models;

namespace projet_stage.IServices
{
    public interface IMaterialService
    {
        public IEnumerable<Material> GetMaterial();
        public Material Create(Material material);
        public Material GetById(int id);
        public Material Update(int id ,Material material);
        public void Delete(int id);
    }
}
