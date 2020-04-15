namespace StringCalculator
{
    public class Calculator
    {
        public int Calculate(string numbers)
        {
            if(numbers == "")
            {
                return 0;
            }
            if(numbers.Contains(","))
            {
                int answer = 0;
                for(int i = 0; i < numbers.Length; i += 2)
                {
                    answer += int.Parse(numbers[i].ToString()); 
                }
                return answer;
            }
            return int.Parse(numbers);
        }
    }
}