class Program
{
    static void Main()
    {
        string s = "ckilbkd";
        List<char> characterCheck = new();
        List<int> highestNum = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!characterCheck.Contains(s[i]))
            {
                characterCheck.Add(s[i]);
                if (i == (s.Length - 1))
                {
                    highestNum.Add(string.Concat(characterCheck).Length);
                }
            }
            
            else
            {
                highestNum.Add(string.Concat(characterCheck).Length);
                if (s[i] == s[i - 1])
                {
                    characterCheck.Clear();
                    characterCheck.Add(s[i]);
                }
                else
                {
                    if (characterCheck.IndexOf(s[i]) == 0)
                    {
                        characterCheck.RemoveAt(characterCheck.IndexOf(s[i]));
                        characterCheck.Add(s[i]);
                    }
                    else
                    {
                        characterCheck.RemoveRange(0, characterCheck.IndexOf(s[i]) + 1);
                        characterCheck.Add(s[i]);
                    }
                }
            }
        }

        int result = string.IsNullOrEmpty(s) ? 0 : highestNum.Max(); 
        Console.Write(result);
    }
}