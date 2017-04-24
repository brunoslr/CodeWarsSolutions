/* URL: http://www.codewars.com/kata/patterncraft-decorator/train/csharp
 The Decorator Design Pattern can be used, for example, in the StarCraft game to manage upgrades.

The pattern consists in "incrementing" your base class with extra functionality.

A decorator will receive an instance of the base class and use it to call the add the new things you want.

Your Task

Complete the code so that when a Marine gets a WeaponUpgrade it increases the damage by 1, and if it is a ArmorUpgrade then increase the armor by 1.

You have 3 classes:

Marine: has a damage and an armor properties
MarineWeaponUpgrade and MarineArmorUpgrade: upgrades to apply on marine. Accepts a Marine in the constructor and has the same properties as the Marine
Resouces

*/

namespace CodeWarsSolutions.SixKyu
{
    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineDecorator : IMarine
    {
        protected IMarine marine;
        public MarineDecorator(IMarine marine)
        {
            this.marine = marine;
        }

        virtual public int Damage { get { return marine.Damage; } set { marine.Damage = value; } }
        virtual public int Armor { get { return marine.Armor; } set { marine.Armor = value; } }
    }

    public class MarineWeaponUpgrade : MarineDecorator
    {
        public MarineWeaponUpgrade(IMarine marine) : base(marine)
        {
            this.marine = marine;
        }
        override public int Damage { get { return marine.Damage + 1; } }
    }

    public class MarineArmorUpgrade : MarineDecorator
    {
        public MarineArmorUpgrade(IMarine marine) : base(marine)
        {
            this.marine = marine;
        }

        override public int Armor { get { return marine.Armor + 1; } }
    }
}
