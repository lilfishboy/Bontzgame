using System;

namespace BontzGame
{
    public class Bontz
    {
        public static string Bontzify(int n)
        {
            var bontz = "";

            for (var i = 1; i <= n; i++)
            {
                if (i.ToString().Contains("7") || i % 7 == 0)
                {
                    bontz = bontz + "bontz";
                }
                else
                {
                    bontz = bontz + i;
                }
            }

            return bontz;
        }
    }
}