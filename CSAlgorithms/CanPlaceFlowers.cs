namespace DefaultNamespace;

public class CanPlaceFlowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int i = 0;
        int plantCount = 0;
        foreach (var plot in flowerbed)
        {
            if (plot == 0)
            {
                if((flowerbed[i-1] == 0 || i == 0) && (flowerbed[i+1] == 0 || i == (flowerbed.Length - 1)))
                {
                    flowerbed[i] = 1;
                    plantCount++;
                }
            }

            i++;
        }

        if (plantCount == n)
        {
            return true;
        }

        return false;
    }
    
    public static void Main(string[] args)
    {
        console.print(CanPlaceFlowers([1,0,0,0,1], 1));
    }
}