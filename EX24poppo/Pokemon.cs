using System;
using System.Collections.Generic;
using System.Text;

namespace EX24poppo
{
    class Pokemon
    {
        public string name { get; private set; }        //名前、コンストラクタだけ設定可能
        public int evolvableCandy { get; private set; } //進化に必要な飴、コンストラクタだけ設定可能
        Pokemon evolved;   //進化後のポケモン
        public Pokemon(string name, int evolvableCandy, Pokemon evolved = null)
        {
            this.name = name;
            this.evolvableCandy = evolvableCandy;
            this.evolved = evolved;
        }
        public Pokemon Evolve(int candy, out int leftCandy)
        {
            Pokemon rc = this;
            leftCandy = candy - evolvableCandy;
            if (leftCandy >= 0)
            {
                rc = evolved;
            }
            return rc;
        }
    }
}
