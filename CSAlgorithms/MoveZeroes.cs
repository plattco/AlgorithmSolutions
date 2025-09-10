namespace DefaultNamespace;

public class MoveZeroes
{
    // Given an integer array nums, move all 0's to the end of it while
    // maintaining the relative order of the non-zero elements.
    public void MoveZeroes(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            // when there is a zero, iterate an inner loop
            // where we swap that zero with the next nonzero
            if (nums[i] == 0) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[j] != 0) {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }
        }
    }
}