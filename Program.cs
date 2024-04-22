namespace Quetes_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)


        {
            
            Console.WriteLine("Volume disponible");
            decimal Volume = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Bouteille disponible");
            int Bottles = int.Parse(Console.ReadLine());
            Console.WriteLine("Capsule disponible");
            int Capsules = int.Parse(Console.ReadLine());
            
            while (true) {

            BeerMachine machine = new BeerMachine
            {
                AvalaibleBeerVolume = Volume, // centilitres
                AvalaibleBottles = Bottles,
                AvalaibleCapsules = Capsules
            };

            Console.WriteLine($"Initial state - Beer volume: {machine.AvalaibleBeerVolume} cl, Bottles: {machine.AvalaibleBottles}, Capsules: {machine.AvalaibleCapsules}");

            int bottlesProduced = machine.ProduceEncapsulatedBeerBottles(10);

            Console.WriteLine($"Bouteille produit: {bottlesProduced}");
            Console.WriteLine($"Volume restant: {machine.AvalaibleBeerVolume} cl, Bottles: {machine.AvalaibleBottles}, Capsules: {machine.AvalaibleCapsules}");
        } }
    }

}
