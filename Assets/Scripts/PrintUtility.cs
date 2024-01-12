using UnityEngine;

public static class PrintUtility
{
    public static void Print(string name, Color color)
    {
        string formattedText = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{name}</color>";
        print($"Visited {formattedText}!");
    }
}