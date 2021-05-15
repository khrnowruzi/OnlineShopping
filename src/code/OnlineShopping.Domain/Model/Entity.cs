namespace OnlineShopping.Domain.Model
{
    public abstract class Entity<T>
    {
        public T Id { get; private set; }
        protected Entity() { }
        protected Entity(T id) => this.Id = id;
    }
}
