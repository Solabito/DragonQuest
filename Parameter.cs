using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuest
{
    interface IParameter {
        void Damage();
    }

    abstract class Parameter
    {
        public string Name    { get; set; }
        public int    MaxHP   { get; set; }
        public int    MaxMP   { get; set; }
        public int    Attack  { get; set; }
        public int    Defence { get; set; }
        public int    Speed   { get; set; }
        public int    HP      { get; set; }

        public void Damage(int attack, int defence) {
            System.Threading.Thread.Sleep(10);
            Random rand = new Random();
            double BaseDamage = attack / 2 - defence / 4;
            double MinDamage = BaseDamage - BaseDamage / 12 + 1;
            double MaxDamage = BaseDamage + BaseDamage / 12 + 1;
            int Damage = (Int32)(MinDamage + (MaxDamage - MinDamage) * rand.NextDouble());
            Console.WriteLine(Name + "は" + Damage + "ダメージ受けた！");
            HP -= Damage;
            if (HP < 0) {
                HP = 0;
            }
        }
    }
}
