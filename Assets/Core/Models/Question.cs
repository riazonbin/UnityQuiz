namespace Assets.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
#nullable enable
        public string? Description { get; set; }
        public string? Answer { get; set; }
#nullable disable
    }
}
