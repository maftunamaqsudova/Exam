namespace Exam
{
    internal class Program
    {
        static List<int> Masala1(List<int> nums)
        {
            var counter = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    counter++;
                }
            }
            return nums;
        }

        static List<string> Masala2(List<string> texts)
        {
            bool s;
            if (texts.Count > 5)
            {
                s = true;
            }
            else
            {
                s = false;
            }

            return texts;
        }


        static string Masala3(string str)
        {

            var res = str.Substring(0, 3);
            return res;
        }

        static bool Masala4(string str)
        {
            if (str.Substring(0, 3) == "PDP")
            {
                return true;
            }
            return false;
        }

        static bool Masala5(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'G' && str[i + 1] == '1' && str[i + 2] == '3')
                {
                    return true;
                }

            }
            return false;
        }
        static List<int> Masala6(List<int> nums)
        {

            var res = nums[0] + nums[1];

            return nums;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
