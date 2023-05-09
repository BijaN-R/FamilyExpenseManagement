namespace Domains
{
    public abstract class BaseModel<T>
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; }
    }

    public abstract class BaseModel : BaseModel<int>
    {
    }
}
