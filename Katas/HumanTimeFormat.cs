using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class HumanTimeFormat      // kyu 4
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            var result = new StringBuilder();

            int sec = seconds % 60;
            int min = ((seconds - sec) / 60) % 60;
            int hours = ((((seconds - sec) / 60) - min) / 60) % 24;
            int days = ((((((seconds - sec) / 60) - min) / 60) - hours) / 24) % 365;
            int years = seconds / 31536000;

            int[] ar = new int[] { sec, min, hours, days, years };
            int counter = -1;

            for (int i = 0; i < 5; i++)
            {
                string s = (ar[i] == 1 ? "" : "s");

                if (ar[i] != 0)
                {
                    counter++;
                    switch (i)
                    {
                        case 0:
                            result.Insert(0, $"{ar[i]} second{s}");
                            break;
                        case 1:
                            result.Insert(0, $"{ar[i]} minute{s}{(ar[i - 1] == 0 ? "" : " and ")}");
                            break;
                        case 2:
                            result.Insert(0, $"{ar[i]} hour{s}{(counter == 0 ? "" : (counter == 1) ? " and " : ", ")}");
                            break;
                        case 3:
                            result.Insert(0, $"{ar[i]} day{s}{(counter == 0 ? "" : (counter == 1) ? " and " : ", ")}");
                            break;
                        case 4:
                            result.Insert(0, $"{ar[i]} year{s}{(counter == 0 ? "" : (counter == 1) ? " and " : ", ")}");
                            break;
                    }
                }
            }
            return result.ToString();
        }
    }
}
