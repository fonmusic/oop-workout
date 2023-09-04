namespace SuperMarket.Models;

/// <summary>
/// Class for promotional client
/// </summary>
public class PromotionalClient : Actor
{
    public sealed override string Name { get; set; }
    public string PromotionName { get; set; }
    public int Id { get; set; }
    
    public static int NumberOfPromotionalParticipants { get; private set; }

    public PromotionalClient(string name, string promotionName) : base(name)
    {
        Name = name;
        PromotionName = promotionName;
        NumberOfPromotionalParticipants++;
        Id = NumberOfPromotionalParticipants;
    }
}