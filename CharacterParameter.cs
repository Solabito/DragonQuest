using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuest
{
    class CharacterParameter : Parameter
    {
        //コンストラクタ
        public CharacterParameter(
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
            HP = MaxHP;
            MaxMP = maxmp;
            Attack = attack;
            Defence = defence;
            Speed = speed;
        }

        public void Damage(int damage) {
            HP -= damage;
        }
    }
}
