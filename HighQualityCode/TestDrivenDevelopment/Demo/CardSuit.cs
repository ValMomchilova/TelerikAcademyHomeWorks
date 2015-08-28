using System.ComponentModel;

namespace Poker
{
    public enum CardSuit
    {
        [Description("♣")]
        Clubs = 1,    // ♣
        [Description("♦")]
        Diamonds = 2, // ♦
        [Description("♥")]
        Hearts = 3,   // ♥
        [Description("♠")]
        Spades = 4    // ♠
    }
}
