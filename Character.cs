using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuest
{
    class Character
    {
        private string Name    { get; set; }
        private int    MaxHP   { get; set; }
        private int    MaxMP   { get; set; }
        private int    Attack  { get; set; }
        private int    Defence { get; set; }
        private int    Speed   { get; set; }
        
        //コンストラクタ
        public Character(
            string name, 
            int maxhp, 
            int maxmp, 
            int attack, 
            int defence, 
            int speed
            )
        {
            Name = name;
            MaxHP = maxhp;
            MaxMP = maxmp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
        }


    }
}
