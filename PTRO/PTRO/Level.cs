using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRO
{
    public class Level
    {
        public int LevelNr { get; set; }
        public int LevelScore { get; set; }
        public int TickTime { get; set; }
        public int Anzahl { get; set; }
        public int ScreencastRangeStart { get; set; }
        public int ScreencastRangeEnd { get; set; }
        public Level(int levelNr, int levelScore, int tickTime, int anzahl, int screencastRangeStart, int screencastRangeEnd)
        {
            this.LevelNr = levelNr;
            this.LevelScore = levelScore;
            this.TickTime = tickTime;
            this.Anzahl = anzahl;
            this.ScreencastRangeStart = screencastRangeStart;
            this.ScreencastRangeEnd = screencastRangeEnd;
        }
        
    }
}
