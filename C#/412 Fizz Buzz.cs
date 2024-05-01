/*Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
 

Example 1:

Input: n = 3
Output: ["1","2","Fizz"]
Example 2:

Input: n = 5
Output: ["1","2","Fizz","4","Buzz"]
Example 3:

Input: n = 15
Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 

Constraints:

1 <= n <= 104
*/


public class Solution2 {
    public IList<string> FizzBuzz(int n) {
        List<string> result = new List<string>(n);
        
        for(int i = 1; i <= n; i++){
            bool divisibleBy3 = i % 3 == 0;
            bool divisibleBy5 = i % 5 == 0;

            string currStr = "";

            if(divisibleBy3) currStr += "Fizz";
            if(divisibleBy5) currStr += "Buzz";
            if(currStr == "") currStr = i.ToString();

            result.Add(currStr);
        }
        return result;
        }
    }
