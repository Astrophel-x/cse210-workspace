
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    public Job()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}



// Class: Person
// Attributes:
// * _givenName : string
// * _familyName : string

// Behaviors:
// * ShowEasternName() : void
// * ShowWesternName() : void

// Person person = new Person();
// person._givenName = "Joseph";
// person._familyName = "Smith";
// person.ShowWesternName();
// person.ShowEasternName();

// Joseph Smith
// Smith, Joseph

// A code template for the category of things known as Person. The responsibility of a Person is to hold and display personal information.
//*public class Person
//*{
    // The C# convention is to start member variables with an underscore _
//     *   public string _givenName = "";
//     *   public string _familyName = "";

    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    //* public Person()
    //* {
    //* }

    // A method that displays the person's full name as used in eastern countries or <family name, given name>.
    //* public void ShowEasternName()
    //* {
    //*     Console.WriteLine($"{_familyName}, {_givenName}");
    //* }

    // A method that displays the person's full name as used in western countries or <given name family name>.
//*     public void ShowWesternName()
//*     {
//*         Console.WriteLine($"{_givenName} {_familyName}");
//*     }
//* }


// A code template for the category of things known as Person. The responsibility of a Person is to hold and display personal information.
// public class Person
// {
// The C# convention is to start member variables with an underscore _
//     public string _givenName = "";
//     public string _familyName = "";

// A special method, called a constructor that is invoked using the  
// new keyword followed by the class name and parentheses.
//     public Person()
//     {
//     }

// A method that displays the person's full name as used in eastern 
// countries or <family name, given name>.
//     public void ShowEasternName()
//     {
//         Console.WriteLine($"{_familyName}, {_givenName}");
//     }

// A method that displays the person's full name as used in western 
// countries or <given name family name>.
//     public void ShowWesternName()
//     {
//         Console.WriteLine($"{_givenName} {_familyName}");
//     }
// }