using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutoMobile()
        {
            var bmw = new BMW();
            bmw.ModelName = "BMW x5";
            return bmw;
        }
    }
}