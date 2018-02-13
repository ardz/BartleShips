namespace BartleShips.Vessel
{
    public abstract class Vessel
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public int Hits { get; set; }

        // the first => is an expression body in c# (replaces get { return })
        // if the number of hits is greater than or equal to the length of
        // the vessel then return true (ship is sunk)
        public bool IsSunk => Hits >= Length;
    }
}
