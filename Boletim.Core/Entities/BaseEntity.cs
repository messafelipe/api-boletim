namespace Boletim.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int id)
        {
            Id = id;
        }

        public int Id { get;  set; }
    }
}
