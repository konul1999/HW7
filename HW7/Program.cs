//using System.Text;

//namespace HW7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //int[] nums = { 1, 2, 3 };
//            //CustomResize(ref nums, 10, 20, 30);

//            //foreach (int num in nums)
//            //{
//            //    Console.Write(num + " ");
//            }
//        }

    //public static void CustomResize(ref int[] nums, params int[] newItems)
    //{
    //    int[] newArray = new int[nums.Length + newItems.Length];

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        newArray[i] = nums[i];
    //    }

    //    for (int i = 0; i < newItems.Length; i++)
    //    {
    //        newArray[nums.Length + i] = newItems[i];
    //    }

    //    nums = newArray;
//}


//public static string FormatSentence(string sentence)
//{
//    Boşluqları silmek ve sözlərə ayırmaq
//            string[] words = sentence.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

//    StringBuilder formatted = new StringBuilder();

//    foreach (string word in words)
//    {
//        ilk hərf böyük, qalanlar kiçik
//                formatted.Append(char.ToUpper(word[0]));

//        for (int i = 1; i < word.Length; i++)
//        {
//            formatted.Append(char.ToLower(word[i]));
//        }
//    }
//    return formatted.ToString().TrimEnd();
//}

//    }
//}

