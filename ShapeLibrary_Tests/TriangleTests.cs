using ShapeLibrary;
using ShapeLibrary.Exceptions;

namespace ShapeLibrary_Tests;

public class TriangleTests
{
	private const double PRECISION = 0.01d;

	[Test]
	[TestCase(4, 700, 5)]
	[TestCase(0, 0, 0)]
	[TestCase(-4, -4, -3)]
	public void Create_NonExistentTriangle_ExistException(
		double side1, double side2, double side3)
	{
		Assert.Throws<FigureUnexistException>(() => new Triangle(side1, side2, side3));
	}

	[Test]
	[TestCase(3,4,5,6d)]
	[TestCase(2.2, 6, 5, 5.28d)]
	public void GetSquare(double side1, double side2, double side3, double expect)
	{
		//arrange
		Triangle triangle = new(side1, side2, side3);

		//act
		double result = triangle.GetSquare();

		//assert
		Assert.That(result, Is.EqualTo(expect).Within(PRECISION));
	}

	[Test]
	[TestCase(3, 4, 5, true)]
	[TestCase(4.4, 3.3, 5.5, true)]
	[TestCase(5, 7, 3, false)]
	public void Check_IsRectangle(double side1, double side2, double side3, bool expect)
	{
		//arrange
		Triangle triangle = new(side1, side2, side3);

		//act
		bool result = triangle.IsRectangle();

		//assert
		Assert.That(result, Is.EqualTo(expect));

	}
}