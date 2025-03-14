# **🔍 Validate & Extract Data with JavaScript REGEX! 📝**  

## **👋 Welcome, Future JavaScript Experts!**  
In this project, you will **discover the power of Regular Expressions (Regex)** by extracting, validating, and manipulating text in JavaScript! 💻  

By the end of this project, you’ll be able to:  
✅ Understand how **regular expressions** work in JavaScript.  
✅ Extract important data (emails, phone numbers, dates, etc.).  
✅ Validate user input using regex patterns.  
✅ Build a **useful tool** for text analysis!  

---

## **🛠️ Step 1: Set Up Your Project**  
📌 Open your favorite **JavaScript editor (VS Code, WebStorm, or a browser console)**.  
📌 Create a new **JavaScript file** (e.g., `regex_project.js`).  

---

## **🖥️ Step 2: Extract an Email from Text**  
🔹 Your task is to **find and extract an email address** from a given text.  
🔹 Use the `match()` function with a **regex pattern** to match an email.  

```javascript
function findEmail(text) {
    /**
     * This function should find and return an email address from the given text.
     * Use text.match() with a regex pattern to match an email format.
     */
    // Write your regex pattern here

    // Search for the email in the text

    // Return the matched email (if found)
}

// Test case
const text = "Hello! My email is student123@gmail.com and my phone number is +359 888-123-456.";
console.log(findEmail(text)); // Expected Output: student123@gmail.com
```

---

## **🔢 Step 3: Extract Multiple Emails & Phone Numbers**  
🔹 Your task is to **find all emails and phone numbers** in a given text.  
🔹 Use `match()` with the **global (`g`) flag** to extract multiple matches!  

```javascript
function extractEmailsAndPhones(text) {
    /**
     * This function should find and return all email addresses and phone numbers from the given text.
     * Use text.match() with proper regex patterns to match emails and phone numbers.
     */
    // Write your regex patterns here

    // Find all emails in the text

    // Find all phone numbers in the text

    // Return both lists (emails, phones)
}

// Test case
const textSample = `
Contact us at support@company.com or sales@business.net.
For urgent inquiries, call +1-555-678-9999 or +44 123 4567 890.
`;
console.log(extractEmailsAndPhones(textSample));  
// Expected Output: { emails: ['support@company.com', 'sales@business.net'], phones: ['+1-555-678-9999', '+44 123 4567 890'] }
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

```javascript
function validateEmail(email) {
    /**
     * This function should check if the email is valid.
     * Use a regex pattern with test() to match a correct email format.
     */
    // Write your regex pattern here

    // Return true if the email is valid, otherwise false
}

function validatePassword(password) {
    /**
     * This function should check if the password is strong.
     * Use a regex pattern with test() to check for the required conditions.
     */
    // Write your regex pattern here

    // Return true if the password meets all conditions, otherwise false
}

// Test cases
console.log(validateEmail("user@domain.com"));  // Expected Output: true  
console.log(validateEmail("invalid-email"));    // Expected Output: false  

console.log(validatePassword("Secure123!"));    // Expected Output: true  
console.log(validatePassword("weakpass"));      // Expected Output: false  
```

---

## **🎯 Bonus Challenges (For Extra Learning!)**  
🚀 Want to **level up your regex skills**? Try these!  

✨ **Extract Dates** – Find dates in formats like **DD/MM/YYYY** or **MM-DD-YYYY**.  
✨ **Find URLs** – Extract all links (e.g., `https://example.com`) from text.  
✨ **Replace Words** – Replace all instances of a word (e.g., `"JavaScript" → "TypeScript"`).  

```javascript
function replaceWord(text, oldWord, newWord) {
    /**
     * This function should replace all occurrences of 'oldWord' with 'newWord' in the given text.
     * Use the replace() function with a regex pattern and the global flag (/g).
     */
    // Write your regex pattern here

    // Return the modified text
}

// Test case
const sampleText = "I love JavaScript! JavaScript is amazing!";
console.log(replaceWord(sampleText, "JavaScript", "TypeScript"));  
// Expected Output: "I love TypeScript! TypeScript is amazing!"
```

---

## **📌 Helpful Resources**  
🔗 [JavaScript Regex Documentation](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions)  
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
This project is an **exciting way** to explore **pattern matching, text extraction, and data validation** using JavaScript.  

**Happy Coding! 🚀🔥**  
