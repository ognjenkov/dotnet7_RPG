namespace WebAPI.Dtos.Fight
{
    public class SkillAttackDto
    {
        public Guid AttackerId { get; set; }
        public Guid OpponentId { get; set; }
        public Guid SkillId { get; set; }
    }
}
