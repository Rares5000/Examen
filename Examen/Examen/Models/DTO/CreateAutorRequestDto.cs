using Examen.Models.Domain;

namespace Examen.Models.DTO
{
    public class CreateAutorRequestDto
    {
        public string Name { get; set; }
        public Editura Editura { get; set; }
        public Guid[] Carti { get; set; }
    }
}
