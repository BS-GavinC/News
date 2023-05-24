using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    public class Hero : Stats
    {

        public Hero(string name)
        {
            Name = name;

            Random rdn = new Random();

            var props = typeof(Stats).GetProperties();

            foreach (var prop in props)
            {
                prop.SetValue(this, rdn.Next(40, 101));
            }

        }

        public string Name { get; set; }
        public int PV { get; set; }
        public int Force { get; set; }
        public int Agility { get; set; }
        public int Discretion { get; set; }
        public int Resistance { get; set; }
        public int Charisma { get; set; }
        public int Spanish { get; set; }

        public void Afficher()
        {
            var props = typeof(Hero).GetProperties();

            foreach (var prop in props)
            {
                Console.WriteLine(prop.Name + " : " + prop.GetValue(this));
            }
        }
    }
}
