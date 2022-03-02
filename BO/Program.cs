using BO.Codes;


// BO.Codes indeholder koden til bilerne.

// QUIZ SECTION 1/5
/*
Vehicle vehicle1 = new Vehicle();
Vehicle vehicle2 = new Car();
Vehicle vehicle3 = new Audi(); // Fejler ikke. Vehicle kan konvertere nedarvet properties tilbage til parent. Derfor er vehicle2 og 3 ikke Car eller Audi instancer, men Vehicle instanser - og derfor har vehicle3 ikke properties Make and Model!

//Audi audi1 = new Vehicle(); Fejler , Vehicle har ikke Audis properties, Vehicle kan ikke "få" disse automatisk
//Audi audi2 = new Car(); // Fejler, samme grund.
Audi audi3 = new Audi(); // Fejler ikke. Audi har både Mærke og Hestekrafter og Model
*/




// QUIZ SECTION 2/5

/*
Vehicle Vehicles = new()
{
    Cars = new()
    {
        new Car() { Horsepower = 60, Make = "Toyota", Model = "Aygo" },
        new Car() { Horsepower = 90, Make = "Fiat", Model = "Punto"},
        new Car() { Horsepower = 175, Make = "Audi", Model = "A6"}
    }
};

// Liste over biler med hestekræfter over 60
var horsepowerList = Vehicles.Cars.Where(Car => Car.Horsepower > 60);

foreach (var item in horsepowerList)
{
    Console.WriteLine($"1. Mærke: {item.Make}\n2. Model: {item.Model}\n3. Hestekræfter: {item.Horsepower}\n");
}

// Først instans af bil med mærket audi
var audi = Vehicles.Cars.Where(Car => Car.Make == "Audi").First();
Console.WriteLine($"1. Mærke: {audi.Make}\n2. Model: {audi.Model}\n3. Hestekræfter: {audi.Horsepower}\n");
*/




// QUIZ SECTION 3/5

/*
    1. Ingen retunere en List<>. Where() retunere en IEnumerable<>, som kan konverteres med ToList() metoden. Men konverteres ikke implicit.
    2. First() retunere den første intans af et object i en liste.
    3. FirstOrDefault() retunere en default værdi fx null for nullables ref værdier eller 0 for enumberables. 
    4. First() SKAL have mulighed for at finde noget ellers crasher den. Idet at First() ikke instansiere et default object hvis ikke fundet noget.
*/



// QUIZ SECTION 4/5

 /*
    Brug virtual til at oprette metoden i parent klassen og så overskriv den i child klassen.
 */
// Audi audi = new Audi() { Make = "Audi", Model = "En hurtig en"};
// Console.WriteLine(audi.WeightTax());




// QUIZ SECTION 5/5

/*
    SetSyn() er overloaded med én. dvs der er to metoder der hedder det samme men tager forskellige argumenter.
*/

/*
Audi audi = new Audi();
audi.SetSyn(DateTime.Now);
audi.SetSyn(DateTime.Now, DateTime.MinValue);
*/