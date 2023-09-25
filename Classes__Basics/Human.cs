
namespace Classes__Basics
{
    // this class is a blueprint for a datatype
    class Human

    {
        // member variable 
        public string firstName;
        public string lastName;
        public string eyeColor;
        public string age;
        // Constructor
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {0} {1}", firstName, lastName);
        }

    }
}