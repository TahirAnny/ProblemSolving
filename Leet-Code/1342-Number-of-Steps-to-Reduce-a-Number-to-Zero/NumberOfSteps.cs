public class Solution {
    public int NumberOfSteps(int num) {

        var stepCount = 0;
        while(num != 0)
        {
            num = num % 2 == 0 ? num / 2 : num - 1;
            stepCount++;
        }
        
        return stepCount;
    }
}
