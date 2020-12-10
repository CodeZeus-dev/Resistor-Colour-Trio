using System;
using System.Linq;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        Dictionary<string, char> resistorColouring = new Dictionary<string, char>();
        resistorColouring.Add("black", '0');
        resistorColouring.Add("brown", '1');
        resistorColouring.Add("red", '2');
        resistorColouring.Add("orange", '3');
        resistorColouring.Add("yellow", '4');
        resistorColouring.Add("green", '5');
        resistorColouring.Add("blue", '6');
        resistorColouring.Add("violet", '7');
        resistorColouring.Add("grey", '8');
        resistorColouring.Add("white", '9');

        var colorValues = colors.Select(item => resistorColouring[item.ToLower()]).ToArray();
        var returnString = new String(new ArraySegment<char>(colorValues, 0, 2));

        int numberOfZeros = Int32.Parse(new ArraySegment<char>(colorValues, 2, 1));

        if (returnString[1] == '0')
        {
            if (numberOfZeros == 2)
            {
                return returnString[0] + " kiloohms";
            }
            else if (numberOfZeros > 2)
            {
                return returnString[0] + new String('0', numberOfZeros - 2) + " kiloohms";
            }
            else
            {
                return returnString + new String('0', numberOfZeros) + " ohms";
            }
        }
        else
        {
            if (numberOfZeros == 3)
            {
                return returnString + " kiloohms";
            }
            else if (numberOfZeros > 3)
            {
                return returnString + new String('0', numberOfZeros - 3) + " kiloohms";
            }
            else
            {
                return returnString + new String('0', numberOfZeros) + " ohms";
            }
        }
    }
}
