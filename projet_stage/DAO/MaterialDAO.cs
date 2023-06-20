using projet_stage.Data;
using projet_stage.IDAO;
using projet_stage.models;

namespace projet_stage.DAO
{
    public class MaterialDAO : IMaterialDAO
    {
        private ModelDbContext Context;
        public MaterialDAO(ModelDbContext context) 
        { 
           this.Context = context;
            
        }
        public IEnumerable<Material> GetMaterial()
        {
            return this.Context.Materials.ToList();
        }
        public Material GetById(int id)
        {
            IQueryable<Material> categories = this.Context.Materials.Where(e => e.Id == id);
            return categories.SingleOrDefault();
        }
        public Material Create(Material material)
        {
            this.Context.Materials.Add(material);
            this.Context.SaveChanges();
            return material;
        }
        public Material Update(Material material)
        {
            this.Context.Update(material);
            this.Context.SaveChanges(true);
            return material;
        }
        public void Delete(int id)
        {
            Material toDelete = this.Context.Materials.Where(e => e.Id == id).SingleOrDefault();
            if (toDelete == null)
            {
                return;
            }
            this.Context.Materials.Remove(toDelete);
            this.Context.SaveChanges();

        }


    }
}
