namespace ShapeLibrary.Exceptions;

public class FigureUnexistException : Exception
{
	public FigureUnexistException() { }

	public FigureUnexistException(string message)
		: base(message) { }

	public FigureUnexistException(string message, Exception inner)
		: base(message, inner) { }
}

