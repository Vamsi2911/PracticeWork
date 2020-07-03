using System;
public class Circle:Shape{
    private int radius;
    public Circle(int r){
        this.radius = r;
    }
    public double GetArea(){
         return this.radius * this.radius * Math.PI;
    }
    public override string ToString(){
        return string.Format("Circle with radius {0}", this.radius);
    }

}