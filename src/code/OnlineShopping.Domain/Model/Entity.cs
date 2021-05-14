namespace OnlineShopping.Domain.Model
{
    public abstract class Entity<T>
    {
        protected T Id { get; private set; }
        protected Entity() { }
        protected Entity(T id) => this.Id = id;
    }
}
