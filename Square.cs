using System;
namespace Arv
{
	public class Square:Shape
	{
		int side;

		public Square(int side) 
		{
			this.side = side;
		}

		public override int GetArea()
		{
			return side * side;
		}
	}
}

