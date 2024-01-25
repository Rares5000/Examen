namespace Examen.Models.DTO
{
    public class CreateCarteRequestDto
    {
        public string Name {  get; set; }
        public Guid[] Autori { get; set; }
    }
}
