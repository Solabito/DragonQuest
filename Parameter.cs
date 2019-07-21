using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonQuest
{
    abstract class Parameter
    {
        public string Name    { get; set; }
        public int    MaxHP   { get; set; }
        public int    MaxMP   { get; set; }
        public int    Attack  { get; set; }
        public int    Defence { get; set; }
        public int    Speed   { get; set; }
        public int    HP      { get; set; }
    }
}
