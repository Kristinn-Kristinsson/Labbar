namespace HarryPotter1
{
    public partial class MainWindow
    {
        public abstract class House
        {
            public string HouseGhost { get; set; }
            public string Mascot { get; set; }
            private string _Password;
            public int Members { get; set; }


            public House()
            {

            }
            public string Password
            {
                get
                { return _Password; }
                set
                { _Password = value; }
            }
        }
    }
}

