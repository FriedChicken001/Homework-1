namespace Homework 1
{
//    class Animal
//{
//    public string Name { get; set; }

//    public int strengthLevel { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, I am a {Name} and my strength is {strengthLevel}");
        }

        private void SayBye()
        {
            Console.WriteLine("Please find it within your hear to pass me *tears*");
        }
}

    internal class Program
    {
        static int[] arrayTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }
        static List<Animal> Animals { get; set; };
        static List<int> strengthLevel { get; set; };

        static void Main(string[] args)
            {
                int x = 0;

                String.add("Mouse");
                String.add("Cat");
                String.add("Dog");
                String.add("Horse");
                String.add("Human");
                String.add("Tiger");
                String.add("Dragon");
                String.add("Hippo");
                String.add("Moose");
                String.add("MewTwo");

            }
        Animal mouse = new Animal();
        mouse.Name = "Mouse";
        mouse.strengthLevel = 1;

        Console.Writeline(mouse.Name + "" + is + "" + mouse.strengthLevel);

    }
}




