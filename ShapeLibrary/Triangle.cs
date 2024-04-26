using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Triangle : IFigureSquare
{
	public Triangle(double s1, double s2, double s3)
	{
		_side1 = s1;
		_side2 = s2;
		_side3 = s3;
	}

	private readonly double _side1;
	private readonly double _side2;
	private readonly double _side3;

	public double GetPerimeter()
	{
		return _side1 + _side2 + _side3;
	}

	public double GetSquare()
	{
		double s = GetPerimeter() / 2;
		return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
	}
	
	public bool IsRectangle
	{
		get =>
			_side1 == _side2 + _side3 ||
			_side2 == _side1 + _side3 ||
			_side3 == _side1 + _side2;	
	}
}
