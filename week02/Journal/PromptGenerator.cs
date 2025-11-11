using System.Diagnostics.CodeAnalysis;

public class PromptGenerator
{
    public List<string> _prompts;

    public static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "What is somting that sprised you today? ",
            "What is somthing that you learned today? ",
            "What is somthing that you are grateful for? ",
            "What is somthing you learned today? ",
            "Name one thing that you are proud of and why. ",
            "Name one person you are grateful for and why. "
        };

        Random random = new Random();
        int listIndex = random.Next(prompts.Count);
        return prompts[listIndex];
    }
}