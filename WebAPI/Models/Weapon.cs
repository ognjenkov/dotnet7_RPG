namespace WebAPI.Models
{
    public class Weapon
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public Character? Character { get; set; } 
        public Guid CharacterId { get; set; }
    }
}
