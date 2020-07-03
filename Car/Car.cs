using System;
public class Car:IVehicle{
    public String Start(){
        return String.Format("Car is Started");
    }
    public String Accelerate(){
        return String.Format("Car is Accelerated");
    }
    public String Stop(){
        return String.Format("Car is Stopped");
    }
}
