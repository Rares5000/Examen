using Examen.Models.Domain;

namespace Examen.Models.DTO
{
    public class CreateEdituraRequestDto
    {
        public string Name { get; set; }
        public Guid[] Autori {  get; set; }
    }
}
