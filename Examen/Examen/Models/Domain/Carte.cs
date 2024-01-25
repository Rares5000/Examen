namespace Examen.Models.Domain
{
    public class Carte
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Autor> Autori { get; set; }
    }
}
