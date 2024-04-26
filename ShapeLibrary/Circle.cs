using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Circle : IFigureSquare
{
	private readonly double _radius;

	public Circle(double radius)
	{
		Validate(radius);

		_radius = radius;
	}

	private static void Validate(double radius)
	{
		if (radius <= 0)
		{
			throw new FigureUnexistException("Radius cannot be equal to zero or less than zero");
		}
	}

	public double GetSquare()
	{
		return Math.PI * Math.Pow(_radius, 2);
	}

}
