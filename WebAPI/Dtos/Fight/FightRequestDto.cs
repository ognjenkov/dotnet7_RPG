namespace WebAPI.Dtos.Fight
{
    public class FightRequestDto
    {
        public List<Guid> CharacterIds { get; set; } = new List<Guid>();
    }
}
