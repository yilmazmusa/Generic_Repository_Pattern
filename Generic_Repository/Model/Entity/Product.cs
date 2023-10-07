using Generic_Repository_Pattern.Relationals;

namespace Generic_Repository_Pattern.Model.Entity
{
    public class Product : BaseEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Type { get; set; }
        
        public string Description { get; set; }
        
    }
}
