using AbstractFactory.AbstractAuto;
using AbstractFactory.Autos;

namespace AbstractFactory.Factories
{
    public class MarutiFactory : IAutoFactory
    {
        public ISportsCar CreateSportsCar()
        {
            return new MarutiBreeza();
        }

        public ILuxuryCar CreateLuxuryCar()
        {
            return new MarutiBaleno();
        }

        public IEconomyCar CreateEconomyCar()
        {
            return new MarutiWaganor();
        }
    }
}