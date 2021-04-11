namespace TDDcsharp
{
    public class CarDealership
    {
        public bool isCar(string car)
        {
            string[] whatIsCarArray = {"car", "4 wheels", "brakes", "steering wheel"};
            
            foreach (string carThing in whatIsCarArray)
            {
                if(car == carThing)
                {
                    return true;
                }
            }
            return false;
        }
    }
}