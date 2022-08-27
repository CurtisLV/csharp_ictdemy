using HeronsFormula;

// calculate area of the tree https://www.ictdemy.com/images/11/csp/exercise/tree.png

// create array of 5 shapes
Shape[] shapes = new Shape[5];

// calculate 4 triangles 15x15x25 cm
for (int i = 0; i < 4; i++)
{
    shapes[i] = new Triangle(15, 15, 25, "green");
}

//calculate tree area 3x26 cm
shapes[4] = new Rectangle(3, 26, "brown");

double total = 0;

foreach (Shape shape in shapes)
{
    total += shape.Area();
}

Console.WriteLine($"The area of the tree is {total} cm^2");
