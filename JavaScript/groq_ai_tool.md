### **✨ Project: Build Your Own AI Chatbot with Groq API! 🤖**  

![Groq Logo](https://cdn.asp.events/CLIENT_Informa__AADDE28D_5056_B739_5481D63BF875B0DF/sites/ai-summit-NY-2022/media/libraries/exhibitors/0b84f0a6-3bbd-11ee-bff906bd0f937899-cover-image.png/fit-in/1500x9999/filters:no_upscale())  

Welcome, Future AI Engineers! 🚀 In this project, you’ll bring **artificial intelligence to life** by creating a chatbot powered by the **Groq API**. This chatbot will respond to user messages in real time using advanced AI models! Instead of a graphical interface, we’re keeping it sleek and **console-based**—just like real-world API integrations.  

---

## **💡 Why This Project?**  
By the end of this project, you’ll:  
✅ Master **API integration** using JavaScript.  
✅ Learn how to **handle errors gracefully** when making API requests.  
✅ Develop a **real-world chatbot** with **multi-turn conversation** capabilities.  
✅ Gain experience working with **AI-powered models** like `llama3-8b-8192`.  

No prior AI experience? No problem! This is your **hands-on introduction** to building with AI! 🚀  

---

## **🛠️ Step 1: Get Your API Key**  
Before we start coding, you'll need access to the **Groq API**. Here’s how to get your key:  

1️⃣ Go to **[Groq’s official website](https://groq.com/)** and create an account.  
2️⃣ Navigate to your **dashboard** and generate an API key.  
3️⃣ Copy the key (keep it secret 🧢) and **paste it into the code** below.  

---

## **🖥️ Step 2: Build Your AI Chatbot**  

Replace `'YOUR_API_KEY_HERE'` with your actual **Groq API key**, then run this script:  

```javascript
const fetch = require("node-fetch");

const API_KEY = "YOUR_API_KEY_HERE"; // Replace with your actual API key
const API_URL = "https://api.groq.com/v1/chat/completions";

async function getAIResponse(userInput) {
    try {
        const response = await fetch(API_URL, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Authorization": `Bearer ${API_KEY}`
            },
            body: JSON.stringify({
                model: "llama3-8b-8192",
                messages: [{ role: "user", content: userInput }]
            })
        });
        
        const data = await response.json();
        return data.choices[0].message.content;
    } catch (error) {
        return `Error: ${error.message}`;
    }
}

(async function main() {
    const readline = require("readline").createInterface({
        input: process.stdin,
        output: process.stdout
    });

    console.log("Welcome to your AI chatbot! Type 'exit' to quit.");

    while (true) {
        await new Promise(resolve => {
            readline.question("\nYou: ", async (userInput) => {
                if (userInput.toLowerCase() === "exit") {
                    console.log("\nGoodbye! 👋");
                    readline.close();
                    process.exit(0);
                }
                const response = await getAIResponse(userInput);
                console.log("AI:", response);
                resolve();
            });
        });
    }
})();
```

### **🛠️ Step 3: Run Your Chatbot!**  
- Open your **terminal** or **command prompt**.  
- Run `node chatbot.js` and start chatting with your **AI assistant!**  
- Type `"exit"` to stop the conversation.  

---

## **🔧 Extra Challenges (Level Up Your Bot!)**  
Want to **supercharge** your chatbot? Try these upgrades:  

✨ **Chat History** – Save all messages to a `.txt` file.  
✨ **Multi-Turn Conversations** – Make the AI remember context!  
✨ **Model Selection** – Let users pick different AI models.  
✨ **Custom Prompts** – Allow users to change the chatbot’s personality!  

---

## **📌 Helpful Resources**  
🔗 [Groq API Documentation](https://console.groq.com/docs/quickstart)  
💻 [Node.js Documentation](https://nodejs.org/en/docs/)  

---

## **🎯 Grading Criteria**  
| Task                                      | Points |
|-------------------------------------------|--------|
| Successfully connects to Groq API         | ✅ 30     |
| Handles errors properly                   | ✅ 20     |
| Console-based chatbot works smoothly      | ✅ 20     |
| Implements additional features            | ✅ 30     |

---

## **🎉 Ready? Let's Build AI! 🚀**  
This project is an **amazing opportunity** to work with **AI-powered APIs** and **create something cool**. Whether you want to impress your peers, add it to your portfolio, or just have fun, this project is for you!  

**Happy Coding! 💻🔥**
