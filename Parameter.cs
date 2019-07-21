using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuest
{
    abstract class Parameter
    {
        protected string Name    { get; set; }
        protected int    MaxHP   { get; set; }
        protected int    MaxMP   { get; set; }
        protected int    Attack  { get; set; }
        protected int    Defence { get; set; }
        protected int    Speed   { get; set; }
    }
}
