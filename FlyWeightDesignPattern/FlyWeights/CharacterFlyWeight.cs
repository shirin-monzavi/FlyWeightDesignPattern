namespace FlyWeightDesignPattern.FlyWeights;

public class CharacterFlyWeight
{
    #region Field
    private readonly char _symbol;
    #endregion

    public CharacterFlyWeight(char symbol)
    {
        _symbol = symbol;
    }

    public void Display(int position)
    {
        Console.WriteLine($"Character: {_symbol}, at position: {position}");
    }
}
