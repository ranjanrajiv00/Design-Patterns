using AbstractFactory.AbstractAuto;
using AbstractFactory.Autos;

namespace AbstractFactory.Factories
{
    public class BMWFactory : IAutoFactory
    {
        public ISportsCar CreateSportsCar()
        {
            return new BMWM3();
        }

        public ILuxuryCar CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IEconomyCar CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}