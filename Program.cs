namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram proMaster = new Ram();

            fxs.MainColor = "Boardwalk Red";
            modelS.MainColor = "Bumblebee Yellow";
            mx410.MainColor = "Vader Black";
            proMaster.MainColor = "Goldenrod";

            fxs.MaximumOccupancy = "1";
            modelS.MaximumOccupancy = "5";
            mx410.MaximumOccupancy = "8";
            proMaster.MaximumOccupancy = "12";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            proMaster.Drive();
        }
    }
}
