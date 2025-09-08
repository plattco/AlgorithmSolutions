namespace DefaultNamespace;

public class ProductOfArray
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] leftProducts = new int[nums.Length];
        int[] rightProducts = new int[nums.Length];
        

        int product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            leftProducts[i] = product;
            product *= nums[i];
        }
        product = 1;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            rightProducts[i] = product;
            product *= nums[i];
        }

        List<int> results = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            results.Add(leftProducts[i]*rightProducts[i]);
        }
        return results.ToArray();
    }
}