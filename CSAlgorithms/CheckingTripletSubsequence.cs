namespace DefaultNamespace;

public class CheckingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (int i in nums)
        {
            if (i <= min1)
            {
                min1 = i;
            }
            else if (i <= min2)
            {
                min2 = i;
            }
            else
            {
                return true;
            }
        }
    }
}