namespace KNDPlayerDataAccess
{
    public class KNDPlayer
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public int ID => RLV_Number;

        public int RLV_Number { get; set; }

        public int Preferred_Match_Number { get; set; }

        public bool Has_Preferred_Match_Number => Preferred_Match_Number > 0;
    }
}