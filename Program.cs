namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleOne = new Circle(5);
            Circle circleTwo = new Circle(6);

            float areaOne = circleOne.GetArea();
            float areaTwo = circleTwo.GetArea();

            Circle SphereOne = new Circle(5);
            Circle SphereTwo = new Circle(6);

            float volumeSphereOne = circleOne.GetSphereVolume();
            float volumeSphereTwo = circleTwo.GetSphereVolume();

            SquareAndRektangle squareOne = new SquareAndRektangle(2, 4);
            SquareAndRektangle squareTwo = new SquareAndRektangle(10, 20);

            float areaSquareOne = squareOne.GetAreaSquare();
            float areaSquareTwo = squareTwo.GetAreaSquare();

            float sicumferenceOne = squareOne.GetSicumfrenceSquare();
            float sicumferenceTwo = squareTwo.GetSicumfrenceSquare();

            Console.WriteLine("Area of circle with radius 5: " + areaOne);
            Console.WriteLine("Area of circle with radius 6: " + areaTwo);

            Console.WriteLine("Volume of Sphere with radius 5: " + volumeSphereOne);
            Console.WriteLine("Volume of Sphere with radius 6: " + volumeSphereTwo);

            Console.WriteLine("Volume of SpherSquare with base 2 and height 4 : " + areaSquareOne);
            Console.WriteLine("Volume of SpherSquare with base 10 and height 20 : " + areaSquareTwo);

            Console.WriteLine("Sircumference of SpherSquare with base 2 and height 4 : " + sicumferenceOne);
            Console.WriteLine("Sircumference of SpherSquare with base 10 and height 20 : " + sicumferenceTwo);
        }
    }
}
