
namespace BuilderPattern.ex1
{
    /// <summary>
    /// 빌더의 구현 클래스.
    /// </summary>
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough() {
            pizza.SetDough("cross");
        }

        public override void BuildSauce() {
            pizza.SetSauce("mild");
        }

        public override void BuildTopping() {
            pizza.SetTopping("ham + pineapples");
        }
    }
}
