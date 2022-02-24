namespace KNDPlayerDataAccess;

public class KNDPlayerDataAccess
{
    public List<KNDPlayer> Get_Players()
    {
        return new List<KNDPlayer>()
        {
            new KNDPlayer(){First_Name = "Joachim", RLV_Number = 5},
            new KNDPlayer(){First_Name = "Lowie"},
            new KNDPlayer(){First_Name = "Wout"},
            new KNDPlayer(){First_Name = "Wout2"},
            new KNDPlayer(){First_Name = "Brecht"}
        };
    }
}