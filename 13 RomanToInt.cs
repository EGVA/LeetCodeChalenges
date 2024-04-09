
public static int RomanToInt(string s)
{
    Dictionary<char, int> romanNumbers =
    new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    int sum = 0;
    char leftChar = ' ';
    char rightChar = ' ';
    foreach(char c in s)
    {
        int rightCharValue = 0;
        rightChar = c;
        if(romanNumbers.TryGetValue(c, out rightCharValue))
        {
            if(leftChar == ' ')
            {
                sum += rightCharValue;
                leftChar = c;
            }
            else
            {
                int leftCharValue = 0;
                romanNumbers.TryGetValue(leftChar, out leftCharValue);
                int temp = 0;
                if(leftCharValue < rightCharValue)
                {
                    sum = (sum - leftCharValue) + rightCharValue - leftCharValue;
                }else
                    sum += rightCharValue; 

                leftChar = c;
            }
        }
    }
    return sum;
    
