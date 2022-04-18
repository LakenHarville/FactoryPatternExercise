namespace FactoryPatternExercise
{
    public interface IVehicle
    {
        void Drive();
    }

    public class Cars : IVehicle
    {
        public void Drive()
        {
            
        }
    }

    public class Motorcycles : IVehicle
    {
        public void Drive()
        {

        }
    }
}