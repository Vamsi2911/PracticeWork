using System;
class Practice{
    static void Main(String[] args){
        //Circle
        Circle circleObject = new Circle(7);
        Console.WriteLine(circleObject);
        Console.WriteLine("Area Of Circle is {0}", circleObject.GetArea());
        //Rectangle
        var rectangleAreaCalc = new ReactangleAreaCalculator(5,7);
        Shape rectangle = new Rectangle(rectangleAreaCalc);
        Console.WriteLine(rectangle);
        //Square 
        var squareAreaCalc = new SquareleAreaCalculator(6);
        Shape square = new Square(squareAreaCalc);
        Console.WriteLine(square);

    }
}