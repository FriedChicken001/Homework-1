namespace Homework1
{
    /**
     * Make a List of Animals
     * But before you can make a list of Animals
     * You need an Animal
     * So we have to design/make what an Animal looks like
     */

    class Animal
    {
        public string Name { get; set; }
        public int strength { get; set; }

        public string SayHello()
        {

            return $"Hello, I am a {Name} and my power level is {strength}";
        }

        private string SayBye()
        {
            return "Plese Pass Me, I'm Struggling.";
        }

        public string ImplementingHomework()
        {
            string sayHelloReturnValue = SayHello();
            string sayByeReturnValue = SayBye();

            return sayHelloReturnValue + "" + sayByeReturnValue;
        }

    }
    /**
     * We have an Animal class now
     * So we can now make animals
     * 
     * What do we need to do next? We now need a List of ANimals
     * But before we can Populate the list we  must make naimals
     */
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animal mouse = new Animal();
            mouse.Name = "Mouse";
            mouse.strength = 1;

            Animal pikachu = new Animal();
            pikachu.Name = "Pikachu";
            pikachu.strength = 5;

            Animal lethander = new Animal();
            lethander.Name = "Lethander";
            lethander.strength = 100;

            Animals.Add(mouse);
            Animals.Add(pikachu);
            Animals.Add(lethander);


            //Console.WriteLine($"Hello! I am a {mouse.Name} and I can do {mouse.strength} pushups");

            /**
             * Foreach has 3 parts
             * 
             * Data/Object Type
             * GenericName
             * TheDataToAccess/CollectionOfData
             * 
             * foreach (data/objectType genericAccessorName in CollectionOfData)
             * {
             *          RunThisCode();
             * }
             * 
             */


            
            //Hint: do it here sorry I meant inside the loop
            foreach (Animal pokemon in Animals)
            {
                Console.WriteLine("Hello! I am a " + "" + pokemon.Name + "and I can do " + "" + pokemon.strength + ".");
                
                if (pokemon == lethander)
                {
                    Console.WriteLine("Oh no! We lost lethander!" + pokemon.ImplementingHomework());
                    break;
                }
            }

            

         

        }




    }
}