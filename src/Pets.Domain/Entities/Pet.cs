namespace Pets.Domain.Entities
{
    public class Pet : Entity
    {
        public string Name { get; set; }
        public string Specie { get; set; }
        public string Size { get; set; }
        public bool Available { get; set; }
    }
}
