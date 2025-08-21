using System;
using System.Collections.Generic;

class ProcessData
{
    public List<int> p(List<int> n)
    {
        List<int> r = new List<int>();
        for (int i = 0; i < n.Count; i++)
        {
            if (n[i] % 2 == 0)
            {
                r.Add(n[i] * 2);
            }
            else
            {
                r.Add(n[i] + 1);
            }
        }
        return r;
    }
}