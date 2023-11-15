Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
dog myDog = new dog(myDogName);

dog neighboursDog = new dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness !=5)
{
    myDog.bark();
}

myDog.WagTail();


class dog
{
    private string _name; //field
    private int _levelOfHappiness = 0;

    //constructor
    public dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }


    public int LevelOfHapiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}

dog anotherDog = new dog();








