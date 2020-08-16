using System;
using System.Collections.Generic;
using System.Text;

namespace EX24poppo
{
    /// <summary>
    /// PoppoEvoluttion
    /// Poppoの進化計算機
    /// </summary>
    class PoppoEvolution
    {
        int poppo;   // ポッポ
        int candy;  // 飴
        int pigeon; // ピジョン

        public PoppoEvolution(  // コンストラクタ
            int poppo, // ポッポ
            int candy, // 飴
            int pigeon // ピジョン
            )
        {
            this.poppo = poppo;
            this.candy = candy;
            this.pigeon = pigeon;
        }
        public PoppoEvolution()
        {
            this.poppo = 0;
            this.candy = 0;
            this.pigeon = 0;
        }
    }
}
