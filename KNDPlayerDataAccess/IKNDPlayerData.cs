namespace KNDPlayerDataAccess;

public static class KNDPlayerDataAccessExtensions
{
    public static List<KNDPlayer> Get_Players()
    {
        return new List<KNDPlayer>()
        {
            new KNDPlayer(){First_Name = "Joachim"},
            new KNDPlayer(){First_Name = "Lowie"},
            new KNDPlayer(){First_Name = "Wout"},
            new KNDPlayer(){First_Name = "Wout"},
            new KNDPlayer(){First_Name = "Brecht"}
        };
    }
}