using RainbowEdit;

namespace TestConsole;

public static class TestConsole
{
    static void Main(string[] args)
    {
        foreach (Operator op in Game.AtkDef)
        {
            Console.WriteLine($"{op.Nickname.PadRight(Game.LongestOperatorNickname.Length + 4)}{op.GetRandomLoadout().ShortString()}");
        }
    }
}
