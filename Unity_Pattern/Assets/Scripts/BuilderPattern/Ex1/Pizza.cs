
namespace BuilderPattern.ex1
{
    public class Pizza
    {
        string dough;
        string sauce;
        string topping;

        public void SetDough(string dough) {
            this.dough = dough;
        }

        public void SetSauce(string sauce) {
            this.sauce = sauce;
        }

        public void SetTopping(string topping) {
            this.topping = topping;
        }
    }
}