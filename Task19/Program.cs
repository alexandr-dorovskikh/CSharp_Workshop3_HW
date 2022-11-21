bool isPalindrome(int num)
{
   bool result = true;
   for (int i = 0; i < 2; i++)
   {

        int digit1 = (num / Convert.ToInt32(Math.Pow(10, i))) % 10;
        int digit2 = (num / Convert.ToInt32(Math.Pow(10, (4-i)))) % 10;

        if (digit1 != digit2) 
        {
            result = false;
            break;
        }    

   } 

   return result;
}

int num = Convert.ToInt32(Console.ReadLine());
if (isPalindrome(num))
    Console.WriteLine("It's a palindrome");
else
    Console.WriteLine("It isn't a palindrome");
