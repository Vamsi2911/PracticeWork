using System;
public class SquareleAreaCalculator: IAreaCalculator{
    private double side;
    public SquareleAreaCalculator(double s){
        this.side=s;

    }
    public double GetArea(){
        return this.side*this.side;
    }
}