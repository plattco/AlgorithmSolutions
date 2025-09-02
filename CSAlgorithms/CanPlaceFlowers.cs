namespace DefaultNamespace;

public class FlowerAlgo
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var plantCount = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                var leftEmpty = (i == 0 || flowerbed[i - 1] == 0);
                var rightEmpty = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);
            
                if (leftEmpty && rightEmpty)
                {
                    flowerbed[i] = 1;
                    plantCount++;
                }
            }
        }
        return plantCount >= n;
    }
    
    public static void Main(string[] args)
    {
        var flowerbed = new int[] {1, 0, 0, 0, 1};
        var result = CanPlaceFlowers(flowerbed, 1);
        Console.WriteLine();
    }
}