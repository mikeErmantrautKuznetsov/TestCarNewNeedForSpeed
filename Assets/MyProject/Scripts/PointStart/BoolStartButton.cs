using System;

public class BoolStartButton
{
    private static readonly Lazy<bool> _instance
        = new Lazy<bool>();

    public static bool Instance = _instance.Value;
}
