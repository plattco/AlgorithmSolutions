public class Candies {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> boolList = new List<bool>();
        int maxCandy = 0;
        foreach (var candy in candies)
        {
            if (candy > maxCandy)
            {
                maxCandy = candy;
            }
        }

        foreach (var candy in candies)
        {
            if (candy + extraCandies >= maxCandy)
            {
                boolList.Add(true);
            }
            else
            {
                boolList.Add(false);
            }
        }
        return boolList;
    }
    
    static void Main(string[] args)
    {
        //var candies = KidsWithCandies();
    }
}

