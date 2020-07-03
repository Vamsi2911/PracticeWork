using System;
public class Rectangle:Shape, IAreaCalculator{
    public IAreaCalculator calculateRArea { get; set; }
   
    public Rectangle(IAreaCalculator calArea){
        this.calculateRArea = calArea;
    }
    public double GetArea(){
        return calculateRArea.GetArea();
    }
    public override String ToString(){
        return string.Format("Area is {0}", this.calculateRArea.GetArea());
    }



}
