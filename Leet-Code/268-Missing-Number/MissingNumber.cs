public class Solution {
    public int MissingNumber(int[] nums) {
        
        int missingNumber = -1;
		
		for(int i = 0; i <= nums.Length; i++)
		{
			missingNumber = Array.IndexOf(nums, i) > -1 ? missingNumber : i;
		}
        
        return missingNumber;
    }
}
