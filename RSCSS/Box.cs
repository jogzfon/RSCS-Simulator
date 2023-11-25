using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSCSS
{
    public class Box
    {
        readonly string AR = "0000000000000000";    //declare register values
        readonly string PC = "0000000000000000";
        readonly string DR = "00000000";
        readonly string TR = "00000000";
        readonly string IR = "00000000";
        readonly string R = "00000000";
        readonly string AC = "00000000";
        readonly string Z = "0";

        public string IO = "00000000";

        readonly long ARint = 0;
        readonly long PCint = 0;
        readonly long DRint = 0;
        readonly long TRint = 0;
        readonly long IRint = 0;
        readonly long Rint = 0;
        readonly long ACint = 0;
        readonly long Zint = 0;

        public long IOint = 0;

        public int FindNthRowStart(int N, string Text)
        {
            if (N == 1)
            {
                return 0;
            }
            else
            {
                int i = -1;
                int j = 1;
                while (j != N)
                {
                    i = Text.IndexOf("\n", i + 1);
                    j++;
                }
                return i + 1;
            }
        }
        public int FindNthRowEnd(int N, string Text)
        {
            int i = -1;
            int j = 1;

            while (j != N + 1)
            {
                i = Text.IndexOf("\n", i + 1);
                j++;
            }

            if (i == -1)
            {
                return Text.Length - 1;
            }
            else
            {
                return i - 1;
            }
        }

    }
}
