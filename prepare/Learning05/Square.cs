class Square 
: Shape
{
    private double _side;


    public Square(string color, double side) 
    : base(color)
    {
        _side = side;
    }

    override public double GetArea()
    {
        return _side * _side;
    }
}