using System;
public class Square:Shape, IAreaCalculator{
    public IAreaCalculator calculateArea { get; set; }
   
    public Square(IAreaCalculator calArea){
        this.calculateArea = calArea;
    }
    public double GetArea(){
        return calculateArea.GetArea();

    }
    public override String ToString(){
        return string.Format("Area is {0}", this.calculateArea.GetArea());
    }



}
