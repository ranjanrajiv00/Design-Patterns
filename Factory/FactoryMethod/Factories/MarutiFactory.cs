using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class MarutiFactory : IAutoFactory
    {
        public IAuto CreateAutoMobile()
        {
            var bmw = new Maruti();
            bmw.ModelName = "Maruti Swift VDI";
            return bmw;
        }
    }
}