using projet_stage.models;

namespace projet_stage.IDAO
{
    public interface IMaterialDAO
    {
        public IEnumerable<Material> GetMaterial();
        public Material Create(Material material);
        public Material GetById(int id);
        public Material Update(Material material);
        public void Delete(int id);
    }
}
