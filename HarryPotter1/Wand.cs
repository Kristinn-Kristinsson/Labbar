//using System.Collections.Generic;

namespace HarryPotter1
{
    public partial class MainWindow
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
            public Wand()
            {

            }

            /*public void WandAlreadyExists()
            {
                bool w = false, c = false;
                foreach (string wo in WoodL)
                    if (wo == Wood)
                    {
                        w = true;
                    }
                foreach (string co in CoreL)
                    if (co == Core)
                    {
                        c = true;
                    }
                if (w == true)
                    CoreL.Add(Core);
                if (c == true)
                    WoodL.Add(Wood);

            }*/
        }
    }
}