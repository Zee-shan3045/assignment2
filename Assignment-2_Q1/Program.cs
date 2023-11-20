using System;

public abstract class Telephone
{
    protected string phonetype;

    public abstract void Ring();
}

public class DigitalPhone : Telephone
{
    public DigitalPhone()
    {
        phonetype = "Digital";
    }

    public override void Ring()
    {
        Console.WriteLine("DigitalPhone is ringing!");
    }
}

public class TalkingPhone : Telephone
{
    public TalkingPhone()
    {
        phonetype = "Talking";
    }

    public override void Ring()
    {
        Console.WriteLine("TalkingPhone is ringing!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Telephone digitalPhone = new DigitalPhone();
        Telephone talkingPhone = new TalkingPhone();

        digitalPhone.Ring();
        talkingPhone.Ring();
    }
}
