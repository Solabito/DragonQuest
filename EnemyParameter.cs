using System;

namespace DragonQuest
{

    class EnemyParameter : Parameter
    {
        //コンストラクタ
        public EnemyParameter(
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
