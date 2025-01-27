using System;

namespace Skills;

public class Comments
{
    // create a method that generates a comment for a given skill
    public string GenerateComment(string skill)
    {
        // return a string that mentions the skill
        return $"This person is skilled in {skill}.";
    }
}
