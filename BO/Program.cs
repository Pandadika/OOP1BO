

Course course;

int input;
bool test;

while (true)
{
    Console.Clear();
    Console.WriteLine("Vælg Uddanelselinje\n1) Programmering\n2) Support\n3) Infrastruktur\n\nVælg 1, 2 eller 3:");

    test = Int32.TryParse(Console.ReadLine(), out input);
    if (!test || (input < 1 || input > 3))
    {
        Console.WriteLine("Input kun tal mellem 1 og 3");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        break;
    }
}

ConsoleColor colour = ConsoleColor.White;
string colourName = "";


while (true)
{
switch (input)
{
    case 1:
        course = new(SchoolingCategory.Programmeringslinje);
        colour = ConsoleColor.Green;
        colourName = "grøn";
        break;
    case 2:
        course = new(SchoolingCategory.Supporterlinje);
        colour = ConsoleColor.Yellow;
        colourName = "gul";
        break;
    case 3:
        course = new(SchoolingCategory.Infrastrukturlinje);
        colour = ConsoleColor.Red;
        colourName = "rød";
        break;
    default:
        course = new(SchoolingCategory.Programmeringslinje);
        break;
}

    Console.Clear();
    Console.WriteLine(course.ToString() + "\n");
    Console.WriteLine("-----------------------------------------------------------");
    Console.Write("Af alle fag, har");
    Console.ForegroundColor = colour;
    Console.Write(" " + course.SchoolingCategory.GetEnumDescription() + " ");
    Console.ResetColor();
    Console.Write("føglende fag vist med");
    Console.ForegroundColor = colour;
    Console.Write(" " + colourName + "\n");
    Console.ResetColor();
    Console.WriteLine("-----------------------------------------------------------");

    
    foreach (var item in course.Courses)
    {
        if (course.SchoolingCourses.Contains(item))
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(item.GetEnumDescription());
            Console.ResetColor();
        }
        else Console.WriteLine(item.GetEnumDescription());
    }
    Console.WriteLine("\nLærere:");
    foreach (var item in course.Teachers)
    {
        if (course.GetTeacher() == item.fullname)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(item.fullname);
            Console.ResetColor();
        }
        else Console.WriteLine(item.fullname);
    }
    Console.WriteLine("-----------------------------------------------------------");
    while (true)
    {
        Console.WriteLine("Vælg Uddanelselinje\n1) Programmering\n2) Support\n3) Infrastruktur\n\nVælg 1, 2 eller 3:");

        test = Int32.TryParse(Console.ReadLine(), out input);
        if (!test || (input < 1 || input > 3))
        {
            Console.WriteLine("Input kun tal mellem 1 og 3");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            break;
        }
    }
}
