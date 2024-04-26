using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Triangle : IFigureSquare
{
	private readonly double _side1;
	private readonly double _side2;
	private readonly double _side3;

	public Triangle(double s1, double s2, double s3)
	{
		Validate(s1, s2, s3);

		_side1 = s1;
		_side2 = s2;
		_side3 = s3;
	}

	private static void Validate(double a, double b, double c)
	{
		if (!ValidSidesAttitude(a, b, c))
		{
			throw new FigureUnexistException("The sum of the two sides must be greater than the third side");
		}
		if (!ValidSidesLength(a, b, c))
		{
			throw new FigureUnexistException("All sides must be greater than zero");
		}
	}

	private static bool ValidSidesAttitude(double a, double b, double c) 
		=> a + b > c && a + c > b && b + c > a;
	
	private static bool ValidSidesLength(double a, double b, double c) 
		=> a > 0 && b > 0 && c > 0;
	

	public bool IsRectangle()
	{
		return (_side1 * _side1 + _side2 * _side2 == _side3 * _side3)
			|| (_side1 * _side1 + _side3 * _side3 == _side2 * _side2)
			|| (_side3 * _side3 + _side2 * _side2 == _side1 * _side1);
	}

	public double GetSquare()
	{
		double s = GetPerimeter() / 2;
		return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
	}

	private double GetPerimeter()
	{
		return _side1 + _side2 + _side3;
	}
}
