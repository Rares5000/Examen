namespace Examen.Models.Domain
{
    public class Autor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Editura Editura { get; set; }
        public ICollection<Carte> Carti {  get; set; }
    }
}
