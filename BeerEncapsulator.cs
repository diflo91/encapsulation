using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quetes_Encapsulation
{
    public class BeerMachine
    {
        private decimal _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;

        public decimal AvalaibleBeerVolume
        {
            get { return _avalaibleBeerVolume; }
            set { _avalaibleBeerVolume = value; }
        }

        public int AvalaibleBottles
        {
            get { return _avalaibleBottles; }
            set { _avalaibleBottles = value; }
        }

        public int AvalaibleCapsules
        {
            get { return _avalaibleCapsules; }
            set { _avalaibleCapsules = value; }
        }

        public void AddBeer(decimal volume)
        {
            _avalaibleBeerVolume += volume;
        }

        public int ProduceEncapsulatedBeerBottles(int numberOfBottles)
        {
            int bottlesProduced = 0;

            for (int i = 0; i < numberOfBottles; i++)
            {
                if (_avalaibleBeerVolume >= 33 && _avalaibleBottles > 0 && _avalaibleCapsules > 0)
                {
                    _avalaibleBeerVolume -= 33;
                    _avalaibleBottles--;
                    _avalaibleCapsules--;
                    bottlesProduced++;
                }
                else
                {
                    Console.WriteLine($"Insufficient components. Missing:");
                    if (_avalaibleBeerVolume < 33)
                    {
                        Console.WriteLine($"- Beer volume: Need more beer to produce {numberOfBottles - bottlesProduced} bottles.");
                    }
                    if (_avalaibleBottles <= 0)
                    {
                        Console.WriteLine($"- Bottles: Need more bottles to produce {numberOfBottles - bottlesProduced} bottles.");
                    }
                    if (_avalaibleCapsules <= 0)
                    {
                        Console.WriteLine($"- Capsules: Need more capsules to produce {numberOfBottles - bottlesProduced} bottles.");
                    }
                    break;
                }
            }

            return bottlesProduced;
        }
    }
}
