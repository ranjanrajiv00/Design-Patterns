using SimpleFactory.Autos;

namespace SimpleFactory
{
    public class AutoFactory
    {
        public static IAuto CreateCar(string carName)
        {
            switch (carName)
            {
                case "BMW":
                    return new BMW();

                case "Maruti":
                    return new Maruti();

                default:
                    return null;
            }
        }
    }
}