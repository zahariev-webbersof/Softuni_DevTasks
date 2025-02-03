# **🧠 Project: Build Your Own AI Chatbot with Groq API in Java! 🤖**  

![Groq Logo](https://cdn.asp.events/CLIENT_Informa__AADDE28D_5056_B739_5481D63BF875B0DF/sites/ai-summit-NY-2022/media/libraries/exhibitors/0b84f0a6-3bbd-11ee-bff906bd0f937899-cover-image.png/fit-in/1500x9999/filters:no_upscale())  

Welcome, Future AI Engineers! 🚀 In this project, you’ll bring **artificial intelligence to life** by creating a chatbot powered by the **Groq API**. This chatbot will respond to user messages in real time using advanced AI models! Instead of a graphical interface, we’re keeping it sleek and **console-based**—just like real-world API integrations.  

---

## **💡 Why This Project?**  
By the end of this project, you’ll:  
✅ Master **API integration** using Java.  
✅ Learn how to **handle errors gracefully** when making API requests.  
✅ Develop a **real-world chatbot** with **multi-turn conversation** capabilities.  
✅ Gain experience working with **AI-powered models** like `llama3-8b-8192`.  

No prior AI experience? No problem! This is your **hands-on introduction** to building with AI! 🚀  

---

## **🛠️ Step 1: Get Your API Key**  
Before we start coding, you'll need access to the **Groq API**. Here’s how to get your key:  

1️⃣ Go to **[Groq’s official website](https://groq.com/)** and create an account.  
2️⃣ Navigate to your **dashboard** and generate an API key.  
3️⃣ Copy the key (keep it secret 🤫) and **paste it into the code** below.  

---

## **🖥️ Step 2: Build Your AI Chatbot in Java**  

Replace `"YOUR_API_KEY_HERE"` with your actual **Groq API key**, then run this Java program:  

### **📌 Java Code: AI Chatbot using Groq API**
```java
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.Scanner;
import org.json.JSONArray;
import org.json.JSONObject;

public class GroqChatbot {
    private static final String API_KEY = "YOUR_API_KEY_HERE"; // Replace with your actual API key
    private static final String API_URL = "https://api.groq.com/v1/chat/completions";

    public static String getAIResponse(String userInput) {
        try {
            // Create JSON request body
            JSONObject requestBody = new JSONObject();
            requestBody.put("model", "llama3-8b-8192");
            JSONArray messages = new JSONArray();
            messages.put(new JSONObject().put("role", "user").put("content", userInput));
            requestBody.put("messages", messages);

            // Create HTTP request
            HttpClient client = HttpClient.newHttpClient();
            HttpRequest request = HttpRequest.newBuilder()
                    .uri(URI.create(API_URL))
                    .header("Authorization", "Bearer " + API_KEY)
                    .header("Content-Type", "application/json")
                    .POST(HttpRequest.BodyPublishers.ofString(requestBody.toString()))
                    .build();

            // Send request and get response
            HttpResponse<String> response = client.send(request, HttpResponse.BodyHandlers.ofString());
            
            // Parse response
            JSONObject jsonResponse = new JSONObject(response.body());
            JSONArray choices = jsonResponse.getJSONArray("choices");
            return choices.getJSONObject(0).getJSONObject("message").getString("content");

        } catch (Exception e) {
            return "Error: " + e.getMessage();
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Welcome to your AI chatbot! Type 'exit' to quit.");

        while (true) {
            System.out.print("\nYou: ");
            String userInput = scanner.nextLine();

            if (userInput.equalsIgnoreCase("exit") || userInput.equalsIgnoreCase("quit")) {
                System.out.println("\nGoodbye! 👋");
                break;
            }

            String response = getAIResponse(userInput);
            System.out.println("AI: " + response);
        }
        scanner.close();
    }
}
```

---

## **🛠️ Step 3: Run Your Chatbot!**  
- Open your **IDE (IntelliJ, Eclipse, VS Code) or terminal**.  
- Make sure you have **Java 11+ installed**.  
- Run the Java file and start chatting with your **AI assistant!**  
- Type `"exit"` or `"quit"` to stop the conversation.  

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
☕ [Java Documentation](https://docs.oracle.com/en/java/)  

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
