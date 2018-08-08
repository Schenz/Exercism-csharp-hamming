using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) {
            throw new ArgumentException();
        }

        var distance = 0;

        for(var index1 = 0; index1 < firstStrand.Length; index1++)
        {
            if (firstStrand[index1].ToString() != secondStrand.Substring(index1, 1)) 
            {
                distance++;
            }
        }
        
        return distance;
    }
}