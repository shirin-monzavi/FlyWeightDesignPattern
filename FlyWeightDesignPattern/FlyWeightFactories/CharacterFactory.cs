using FlyWeightDesignPattern.FlyWeights;

namespace FlyWeightDesignPattern.FlyWeightFactories;

public class CharacterFactory
{
    #region Field
    private readonly Dictionary<char, CharacterFlyWeight> _character;
    #endregion

    public CharacterFactory()
    {
        _character = new();
    }

    public CharacterFlyWeight CreateCharacter(char symbol)
    {
        if (_character.ContainsKey(symbol))
        {
            return _character[symbol];
        }

        return _character[symbol] = new CharacterFlyWeight(symbol);
    }
}
