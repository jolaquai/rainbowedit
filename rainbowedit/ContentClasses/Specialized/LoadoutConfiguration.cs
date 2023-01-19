using RainbowEdit.Extensions;

namespace RainbowEdit;

public class LoadoutConfiguration
{
    public Operator Source
    {
        get; private set;
    }
    public WeaponConfiguration Primary
    {
        get; private set;
    }
    public WeaponConfiguration Secondary
    {
        get; private set;
    }
    public Weapon.Gadget Gadget
    {
        get; set;
    }

    internal LoadoutConfiguration(Operator source)
    {
        Source = source;

        Random ran = new();

        List<Weapon.Gadget> possibleGadgets = Source.Gadgets.GetSetFlags();

        if (possibleGadgets.Any())
        {
            Gadget = possibleGadgets[ran.Next(possibleGadgets.Count)];
        }

        List<Weapon> primaries = Source.Primaries.ToList();
        List<Weapon> secondaries = Source.Secondaries.ToList();
        Primary = new(primaries[ran.Next(primaries.Count)]);
        Secondary = new(secondaries[ran.Next(secondaries.Count)]);
    }

    public override string ToString() => $"""
        Operator: {Source.Nickname}
        Primary:
        {string.Join(Environment.NewLine, Primary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Secondary:
        {string.Join(Environment.NewLine, Secondary.ToString().Split(Environment.NewLine).Select(str => $"    {str}"))}
        Gadget: {Gadget}
        """;

    public string ShortString() => $"{{ {Primary.Source.Name}, {Secondary.Source.Name}, {Gadget} }}";
}
