// cs0037-5.cs: Cannot convert null to `int' because it is a value type
// Line: 6

class C
{
	object [,] i = new int [2,1] { { null }, { 2 } };
}
 