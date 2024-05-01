/*
    Given an integer num, return the number of steps to reduce it to zero.

In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

 

Example 1:

Input: num = 14
Output: 6
Explanation: 
Step 1) 14 is even; divide by 2 and obtain 7. 
Step 2) 7 is odd; subtract 1 and obtain 6.
Step 3) 6 is even; divide by 2 and obtain 3. 
Step 4) 3 is odd; subtract 1 and obtain 2. 
Step 5) 2 is even; divide by 2 and obtain 1. 
Step 6) 1 is odd; subtract 1 and obtain 0.
Example 2:

Input: num = 8
Output: 4
Explanation: 
Step 1) 8 is even; divide by 2 and obtain 4. 
Step 2) 4 is even; divide by 2 and obtain 2. 
Step 3) 2 is even; divide by 2 and obtain 1. 
Step 4) 1 is odd; subtract 1 and obtain 0.
Example 3:

Input: num = 123
Output: 12
 

Constraints:

0 <= num <= 106

*/


// My solution
public class Solution {
    public int NumberOfSteps(int num) {
        int step = 0;
        int division = num;
        while(division != 0){
            step++;
            bool isEven = division % 2 == 0;
            if(!isEven) division--;
            else division = division / 2;
        }
        return step;
    }
}


// Bitwise Solution
// To divide a number by half in binary, we remove the righthest bit, we do a shift

public class BitwiseSolution(){
        int step = 0;
        int division = num;
        while(division > 0){
            step++;
            // Before we used division % 2 == 0;
            bool isEven = (division & 1) == 0;
            if(!isEven) division--;
            else division >>= 1; // Here we do a division by 2, by a binary shift
        }
        return step;
} 