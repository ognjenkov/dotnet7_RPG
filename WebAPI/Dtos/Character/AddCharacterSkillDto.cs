namespace WebAPI.Dtos.Character
{
    public class AddCharacterSkillDto
    {
        public Guid CharacterId { get; set; }
        public Guid SkillId { get; set; }
    }
}
