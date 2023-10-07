using Generic_Repository_Pattern.Relationals;

namespace Generic_Repository_Pattern.Model.Entity
{
    public class Book : BaseEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get; set; }
        public string Author { get; set; }

    }
}
