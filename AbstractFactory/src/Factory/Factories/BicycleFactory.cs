namespace AbstractFactory
{
    public class BicycleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleRequirements requirements)
        {
            switch (requirements.Passengers)
            {
                case 1:
                    if(requirements.NumberOfWheels == 1) return new Unicycle();
                    return new Bicycle();
                case 2:
                    return new Tandem();
                case 3:
                    return new Tricyle();
                case 4:

                    if (!requirements.Cargo)
                    {
                        return new FamilyBike();
                    }
                    else
                    {
                        return new GoKart();
                    }

                default:
                    return new Bicycle();
            }
        }
    }
}
