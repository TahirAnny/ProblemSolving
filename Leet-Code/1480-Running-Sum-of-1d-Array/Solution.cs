public class Solution {
    public int[] RunningSum(int[] nums) {
        
        if( nums == null || nums.Length == 0 )
            return new int[0];
        
        for( int i = 1; i < nums.Length; i++ )
            nums[i] += nums[i-1];
        
        return nums;
    }
}

//With Linq
 
public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int sum = 0;
        return nums.Select(x => sum += x).ToArray();
        
    }
}

//Using Recursion

public class Solution {
    public int[] RunningSum(int[] nums, int i = 1) {
    
       if(i == nums.Length ) return nums;
        
        nums[i] += nums[i-1];
        
        return RunningSum(nums,++i);
    }
}
