using projet_stage.models;
using System.ComponentModel.DataAnnotations;

namespace projet_stage.DTO
{
    public class MaterialDTO
    {
        public MaterialDTO()
        {
        }
        public MaterialDTO(Material material)
        {
            this.Id=material.Id;
            this.Name=material.Name;   
            this.Price=material.Price;
            this.Purchase_Date =material.Purchase_Date;
            this.Brand =material.Brand;
            this.Reference =material.Reference;
            this.IsTaken =material.IsTaken;
        }

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public float? Price { get; set; }
        public DateTime? Purchase_Date { get; set; }
        public string? Brand { get; set; }

        public string? Reference { get; set; }
        public int? IsTaken { get; set; }



    }
}
