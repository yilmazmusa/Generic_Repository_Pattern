namespace Generic_Repository_Pattern.Relationals
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } 

    }
}
