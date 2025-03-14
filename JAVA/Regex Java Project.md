# **🔍 Validate & Extract Data with Java REGEX! 📝**  

## **👋 Welcome, Future Java Experts!**  
In this project, you will **discover the power of Regular Expressions (Regex)** by extracting, validating, and manipulating text in Java! ☕  

By the end of this project, you’ll be able to:  
✅ Understand how **regular expressions** work in Java.  
✅ Extract important data (emails, phone numbers, dates, etc.).  
✅ Validate user input using regex patterns.  
✅ Build a **useful tool** for text analysis!  

---

## **🛠️ Step 1: Set Up Your Project**  
📌 Open your favorite **Java editor (IntelliJ IDEA, Eclipse, or VS Code)**.  
📌 Create a new **Java file** (e.g., `RegexProject.java`).  
📌 Ensure you have **Java 8+** installed.  

---

## **🖥️ Step 2: Extract an Email from Text**  
🔹 Your task is to **find and extract an email address** from a given text.  
🔹 Use the `Pattern` and `Matcher` classes with a **regex pattern** to match an email.  

```java
import java.util.regex.*;

public class RegexProject {
    public static String findEmail(String text) {
        /**
         * This function should find and return an email address from the given text.
         * Use Pattern.compile() and Matcher.find() to match an email format.
         */
        // Write your regex pattern here

        // Search for the email in the text

        // Return the matched email (if found)
        return null; // Change this to return the actual result
    }

    public static void main(String[] args) {
        String text = "Hello! My email is student123@gmail.com and my phone number is +359 888-123-456.";
        System.out.println(findEmail(text)); // Expected Output: student123@gmail.com
    }
}
```

---

## **🔢 Step 3: Extract Multiple Emails & Phone Numbers**  
🔹 Your task is to **find all emails and phone numbers** in a given text.  
🔹 Use `Pattern.compile()` with the **global matching option** to extract multiple matches.  

```java
import java.util.regex.*;
import java.util.*;

public class RegexProject {
    public static Map<String, List<String>> extractEmailsAndPhones(String text) {
        /**
         * This function should find and return all email addresses and phone numbers from the given text.
         * Use Pattern.compile() and Matcher.find() to match emails and phone numbers.
         */
        // Write your regex patterns here

        // Find all emails in the text

        // Find all phone numbers in the text

        // Return both lists (emails, phones)
        return new HashMap<>(); // Change this to return actual results
    }

    public static void main(String[] args) {
        String text = """
                Contact us at support@company.com or sales@business.net.
                For urgent inquiries, call +1-555-678-9999 or +44 123 4567 890.
                """;
        System.out.println(extractEmailsAndPhones(text));  
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

```java
import java.util.regex.*;

public class RegexProject {
    public static boolean validateEmail(String email) {
        /**
         * This function should check if the email is valid.
         * Use Pattern.matches() with a regex pattern to match a correct email format.
         */
        // Write your regex pattern here

        // Return true if the email is valid, otherwise false
        return false; // Change this to return the actual result
    }

    public static boolean validatePassword(String password) {
        /**
         * This function should check if the password is strong.
         * Use Pattern.matches() with a regex pattern to check for the required conditions.
         */
        // Write your regex pattern here

        // Return true if the password meets all conditions, otherwise false
        return false; // Change this to return the actual result
    }

    public static void main(String[] args) {
        System.out.println(validateEmail("user@domain.com"));  // Expected Output: true  
        System.out.println(validateEmail("invalid-email"));    // Expected Output: false  

        System.out.println(validatePassword("Secure123!"));    // Expected Output: true  
        System.out.println(validatePassword("weakpass"));      // Expected Output: false  
    }
}
```

---

## **🎯 Bonus Challenges (For Extra Learning!)**  
🚀 Want to **level up your regex skills**? Try these!  

✨ **Extract Dates** – Find dates in formats like **DD/MM/YYYY** or **MM-DD-YYYY**.  
✨ **Find URLs** – Extract all links (e.g., `https://example.com`) from text.  
✨ **Replace Words** – Replace all instances of a word (e.g., `"Java" → "Python"`).  

```java
import java.util.regex.*;

public class RegexProject {
    public static String replaceWord(String text, String oldWord, String newWord) {
        /**
         * This function should replace all occurrences of 'oldWord' with 'newWord' in the given text.
         * Use String.replaceAll() with a regex pattern.
         */
        // Write your regex pattern here

        // Return the modified text
        return text; // Change this to return actual results
    }

    public static void main(String[] args) {
        String text = "I love Java! Java is amazing!";
        System.out.println(replaceWord(text, "Java", "Python"));  
        // Expected Output: "I love Python! Python is amazing!"
    }
}
```

---

## **📌 Helpful Resources**  
🔗 [Java Regex Documentation](https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html)  
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
This project is an **exciting way** to explore **pattern matching, text extraction, and data validation** using Java.  

**Happy Coding! ☕🔥**  
