# **🔍 Validate & Extract Data with C# REGEX! 📝**  

## **👋 Welcome, Future C# Experts!**  
In this project, you will **discover the power of Regular Expressions (Regex)** by extracting, validating, and manipulating text in C#! 💻  

By the end of this project, you’ll be able to:  
✅ Understand how **regular expressions** work in C#.  
✅ Extract important data (emails, phone numbers, dates, etc.).  
✅ Validate user input using regex patterns.  
✅ Build a **useful tool** for text analysis!  

---

## **🛠️ Step 1: Set Up Your Project**  
📌 Open your favorite **C# editor (Visual Studio, VS Code, or JetBrains Rider)**.  
📌 Create a new **C# Console Application**.  
📌 Name the file `RegexProject.cs`.  
📌 Ensure you have **.NET 6+** installed.  

---

## **🖥️ Step 2: Extract an Email from Text**  
🔹 Your task is to **find and extract an email address** from a given text.  
🔹 Use the `Regex` class to match an email.  

```csharp
using System;
using System.Text.RegularExpressions;

class RegexProject
{
    public static string FindEmail(string text)
    {
        /**
         * This function should find and return an email address from the given text.
         * Use Regex.Match() with a regex pattern to match an email format.
         */
        // Write your regex pattern here

        // Search for the email in the text

        // Return the matched email (if found)
        return null; // Change this to return the actual result
    }

    static void Main()
    {
        string text = "Hello! My email is student123@gmail.com and my phone number is +359 888-123-456.";
        Console.WriteLine(FindEmail(text)); // Expected Output: student123@gmail.com
    }
}
```

---

## **🔢 Step 3: Extract Multiple Emails & Phone Numbers**  
🔹 Your task is to **find all emails and phone numbers** in a given text.  
🔹 Use `Regex.Matches()` with the **global matching option** to extract multiple matches.  

```csharp
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RegexProject
{
    public static Dictionary<string, List<string>> ExtractEmailsAndPhones(string text)
    {
        /**
         * This function should find and return all email addresses and phone numbers from the given text.
         * Use Regex.Matches() to match emails and phone numbers.
         */
        // Write your regex patterns here

        // Find all emails in the text

        // Find all phone numbers in the text

        // Return both lists (emails, phones)
        return new Dictionary<string, List<string>>(); // Change this to return actual results
    }

    static void Main()
    {
        string text = @"
            Contact us at support@company.com or sales@business.net.
            For urgent inquiries, call +1-555-678-9999 or +44 123 4567 890.
        ";
        Console.WriteLine(ExtractEmailsAndPhones(text));  
        // Expected Output: { emails: ['support@company.com', 'sales@business.net'], phones: ['+1-555-678-9999', '+44 123 4567 890'] }
    }
}
```

---

## **🔐 Step 4: Validate User Input (Email & Password Checker)**  
🔹 Your task is to **validate email addresses and passwords**.  
🔹 A **valid email** should follow the format `example@domain.com`.  
🔹 A **strong password** must:  
   ✅ Be **at least 8 characters long**  
   ✅ Contain **one uppercase letter**  
   ✅ Contain **one number**  
   ✅ Contain **one special character (@$!%*?&)**  

```csharp
using System;
using System.Text.RegularExpressions;

class RegexProject
{
    public static bool ValidateEmail(string email)
    {
        /**
         * This function should check if the email is valid.
         * Use Regex.IsMatch() with a regex pattern to match a correct email format.
         */
        // Write your regex pattern here

        // Return true if the email is valid, otherwise false
        return false; // Change this to return the actual result
    }

    public static bool ValidatePassword(string password)
    {
        /**
         * This function should check if the password is strong.
         * Use Regex.IsMatch() with a regex pattern to check for the required conditions.
         */
        // Write your regex pattern here

        // Return true if the password meets all conditions, otherwise false
        return false; // Change this to return the actual result
    }

    static void Main()
    {
        Console.WriteLine(ValidateEmail("user@domain.com"));  // Expected Output: true  
        Console.WriteLine(ValidateEmail("invalid-email"));    // Expected Output: false  

        Console.WriteLine(ValidatePassword("Secure123!"));    // Expected Output: true  
        Console.WriteLine(ValidatePassword("weakpass"));      // Expected Output: false  
    }
}
```

---

## **🎯 Bonus Challenges (For Extra Learning!)**  
🚀 Want to **level up your regex skills**? Try these!  

✨ **Extract Dates** – Find dates in formats like **DD/MM/YYYY** or **MM-DD-YYYY**.  
✨ **Find URLs** – Extract all links (e.g., `https://example.com`) from text.  
✨ **Replace Words** – Replace all instances of a word (e.g., `"C#" → "F#"`) using regex.  

```csharp
using System;
using System.Text.RegularExpressions;

class RegexProject
{
    public static string ReplaceWord(string text, string oldWord, string newWord)
    {
        /**
         * This function should replace all occurrences of 'oldWord' with 'newWord' in the given text.
         * Use Regex.Replace() with a regex pattern.
         */
        // Write your regex pattern here

        // Return the modified text
        return text; // Change this to return actual results
    }

    static void Main()
    {
        string text = "I love C#! C# is amazing!";
        Console.WriteLine(ReplaceWord(text, "C#", "F#"));  
        // Expected Output: "I love F#! F# is amazing!"
    }
}
```

---

## **📌 Helpful Resources**  
🔗 [C# Regex Documentation](https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions)  
📖 [Regex101 - Online Regex Tester](https://regex101.com/)  

---

## **📊 Grading Criteria**  
| Task                                      | Points |
|-------------------------------------------|--------|
| Successfully extracts emails & phones     | ✅ 20  |
| Validates user input correctly            | ✅ 30  |
| Uses regex creatively for extra tasks     | ✅ 20  |
| Implements at least one bonus challenge   | ✅ 30  |

---

## **🎉 Ready? Let’s Master REGEX! 🚀**  
This project is an **exciting way** to explore **pattern matching, text extraction, and data validation** using C#.  

**Happy Coding! 🚀🔥**  
