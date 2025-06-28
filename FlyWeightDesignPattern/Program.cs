using FlyWeightDesignPattern.FlyWeightFactories;

var factory = new CharacterFactory();

string text = "Hello World!";

for (int i = 0; i < text.Length; i++)
{
    var character = factory.CreateCharacter(text[i]);
    character.Display(i);
}
