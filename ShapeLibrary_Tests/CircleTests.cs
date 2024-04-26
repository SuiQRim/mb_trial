using ShapeLibrary;
using ShapeLibrary.Exceptions;

namespace ShapeLibrary_Tests;

internal class CircleTests
{
	private const double PRECISION = 0.01d;

	[Test]
	[TestCase(-4)]
	[TestCase(0)]
	public void Create_NonExistentCircle_UnexistException(
		double radius)
	{
		Assert.Throws<FigureUnexistException>(() => new Circle(radius));
	}

	[Test]
	[TestCase(5, 78.53d)]
	[TestCase(45.5d, 6503.88d)]
	public void GetSquare(double radius, double expect)
	{
		//arrange
		Circle circle = new(radius);

		//act
		double result = circle.GetSquare();

		//assert
		Assert.That(result, Is.EqualTo(expect).Within(PRECISION));
	}
}
