using System;
public class ReactangleAreaCalculator: IAreaCalculator{
    private double Length,breadth;
    public ReactangleAreaCalculator(double l, double b){
        this.Length=l;
        this.breadth=b;
    }
    public double GetArea(){
        return this.Length*this.breadth;
    }
}