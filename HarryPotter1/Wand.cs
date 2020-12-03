//using System.Collections.Generic;

namespace HarryPotter1
{
   
        public class Wand
        {
            //private List<string> WoodL { get; set; }
            //private List<string> CoreL { get; set; }
            public int Size { get; set; }
            public string Wood { get; set; }
            public string Core { get; set; }

            public Wand(string wood, string core, int size)
            {
                Size = size;
                Wood = wood;
                Core = core;
            }

        }
    
}