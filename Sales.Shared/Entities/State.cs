using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado/Departamento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string Name { get; set; } = null!;

        public ICollection<City> Cities { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
