
namespace PrototypePattern.ex1
{
    public abstract class Cloneable
    {
        private string id;

        public Cloneable(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract Cloneable Clone();
    }
}