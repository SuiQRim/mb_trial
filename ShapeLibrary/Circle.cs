using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Circle : IFigureSquare
{
	private readonly double _radius;

	public Circle(double radius)
	{
		_radius = radius;
	}

	public double GetSquare()
	{
		return Math.PI * Math.Pow(_radius, 2);
	}
}
