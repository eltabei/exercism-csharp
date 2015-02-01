using System;
using System.Collections.Generic;
using System.Linq;

public class SecretHandshake
{
    [Flags]
    enum Move
    {
        wink = 1,
        double_blink = 2,
        close_your_eyes = 4,
        jump = 8,
        reverse = 16
    }

    private readonly Move moves;

    public SecretHandshake(int i)
    {
        moves = (Move)i;
    }

    public List<string> Commands()
    {
        List<string> res = (from Move m in Enum.GetValues(typeof(Move))
                            where moves.HasFlag(m)
                            select m.ToString().Replace("_", " "))
                            .ToList();
        string r = Move.reverse.ToString();
        if (res.Remove(r))
        {
            res.Reverse();
        }
        return res;
    }
}