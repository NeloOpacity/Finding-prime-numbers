using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegaMega
{
    class PrimesInput
    {
        public int from, to;
        public PrimesInput(int _from, int _to)
        {
            from = _from;
            to = _to;
        }
    }
    static class Worker
    {
        static public int[] FindPrimes(PrimesInput input)
        {
            return FindPrimes(input, null);
        }

        static public int[] FindPrimes(PrimesInput input, BackgroundWorker backgroundWorker)
        {
            int num = input.from;
            int[] arr = new int[input.to - input.from];
            int iteration = arr.Length / 100;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num;
                num++;
            }
            int maxDiv = (int)Math.Floor(Math.Sqrt(input.to));
            int[] marks = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j <= maxDiv; j++)
                {
                    if ((arr[i] != j) && (arr[i] % j == 0))
                    {
                        marks[i] = 1;
                    }
                }
                if ((i % iteration == 0) && (backgroundWorker != null))
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        return null;
                    }
                    if (backgroundWorker.WorkerReportsProgress)
                    {
                        backgroundWorker.ReportProgress(i / iteration);
                    }
                }
            }
            int primes = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == 0)
                    primes++;
            }
            int[] ret = new int[primes];
            int curs = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == 0)
                {
                    ret[curs] = arr[i];
                    curs++;
                }
            }
            if (backgroundWorker != null && backgroundWorker.WorkerReportsProgress)
            {
                backgroundWorker.ReportProgress(100);
            }
            return ret;
        }
    }
}
