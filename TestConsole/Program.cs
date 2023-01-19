using RainbowEdit;

namespace TestConsole;

public static class TestConsole
{
    static void Main(string[] args)
    {
        List<IEnumerable<Operator>> opClasses = new List<IEnumerable<Operator>>() { Game.Defenders, Game.Attackers };
        for (int i = 0; i < opClasses.Count; i++)
        {
            IEnumerable<Operator> opClass = opClasses[i];
            Console.WriteLine(i == 0 ? "DEFENDERS" : "\r\nATTACKERS");
            Console.WriteLine("=========");

            foreach (Operator op in opClass)
            {
                Console.WriteLine($"{op}{op.GetRandomLoadout()}");
            }
        }
    }
}
