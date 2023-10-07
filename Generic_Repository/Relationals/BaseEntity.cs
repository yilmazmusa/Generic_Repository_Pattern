namespace Generic_Repository_Pattern.Relationals
{
    public interface BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } //= DateTime.Now;
     
    }
}
