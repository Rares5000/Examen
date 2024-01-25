using Examen.Models.Domain;

namespace Examen.Models.DTO
{
    public class AutorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Editura Editura { get; set; }
        public List<CarteDto> Carti { get; set; } = new List<CarteDto>();
    }
}
