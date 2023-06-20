using System.ComponentModel.DataAnnotations;
using projet_stage.DTO;
namespace projet_stage.models
{
    public class Material
    {
        public Material()
        {
            Assignments = new HashSet<Employee_Material_Assignment>();
        }
        public Material(MaterialDTO materialDTO)
        {
            this.Id = materialDTO.Id;
            this.Name = materialDTO.Name;
            this.Price = materialDTO.Price;
            this.Purchase_Date = materialDTO.Purchase_Date;
            this.Brand = materialDTO.Brand;
            this.Reference = materialDTO.Reference;
            this.IsTaken = materialDTO.IsTaken;
        }
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public float? Price { get; set; }
        public DateTime? Purchase_Date { get; set; }
        public string? Brand { get; set; }
        public virtual ICollection<Employee_Material_Assignment>? Assignments { get; set; }

        public string? Reference { get; set; }
        public int? IsTaken { get; set; }





    }
}
