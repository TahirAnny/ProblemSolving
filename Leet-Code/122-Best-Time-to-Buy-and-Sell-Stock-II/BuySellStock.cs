public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> newList = new List<string>();

        for (int i= 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                newList.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                newList.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                newList.Add("Buzz");
            }
            else
            {
                newList.Add(i.ToString());
            }
        }

        return newList;
    }
}