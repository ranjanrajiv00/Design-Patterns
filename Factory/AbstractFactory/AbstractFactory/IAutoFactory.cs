using AbstractFactory.AbstractAuto;

namespace AbstractFactory.Factories
{
    public interface IAutoFactory
    {
        ISportsCar CreateSportsCar();

        ILuxuryCar CreateLuxuryCar();

        IEconomyCar CreateEconomyCar();
    }
}