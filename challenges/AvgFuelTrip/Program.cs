using System;

namespace AvgFuelTrip {
  class Program {
      
    public static void Main (string[] args) {  
      string[] inputs = Console.ReadLine().Split();
        
      int tripTime = Int32.Parse(inputs[0]);
      int avgSpeed = Int32.Parse(inputs[1]);

      double avgFuelConsumption = 12;
      double distanceRidden = (tripTime * avgSpeed);
      double avgLiters = distanceRidden/avgFuelConsumption;

      Console.WriteLine(avgLiters.ToString("N3"));
    }
  }
}