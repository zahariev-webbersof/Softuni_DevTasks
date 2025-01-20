### Exploring HTTP Basics with Python and Postman 🌐🐍

#### **Purpose** 🏆  
The goal of this task is to help you become familiar with the fundamentals of the HTTP protocol, including HTTP requests and responses, developer tools, HTML forms, and URL structures. By the end of this exercise, you should understand how to interact with existing web APIs, use Postman for testing, and analyze HTTP traffic effectively.

---

#### **Project Overview** 📖  
You will create a simple Python project that interacts with an existing public API to demonstrate key HTTP concepts. You’ll explore HTTP methods (GET, POST, PUT, DELETE), work with HTML forms, and analyze HTTP requests and responses using Postman and browser developer tools.

---

#### **Requirements** 📋  

1. **HTTP Developer Tools Exploration** 🔍  
   - Open your browser's developer tools (e.g., Chrome DevTools).  
   - Visit a website and inspect its network activity.  
   - Identify:  
     - A **GET request** fetching a resource (e.g., an image or a script).  
     - A **POST request** triggered by submitting a form.  
   - Document the request headers and response headers.  

2. **HTML Form Interaction** ✍️  
   - Create a basic HTML form with fields for "Name" and "Email".  
   - Use a free public service like [webhook.site](https://webhook.site/) to simulate form submission.  
   - Log the captured form data and observe how the request is structured.  

   **Example Form Code:**  
   ```html
   <form action="https://webhook.site/your-custom-url" method="POST">
       <label for="name">Name:</label>
       <input type="text" id="name" name="name"><br>
       <label for="email">Email:</label>
       <input type="email" id="email" name="email"><br>
       <button type="submit">Submit</button>
   </form>
   ```

3. **API Interaction with Python** 🛠️  
   - Use a free public API (e.g., [JSONPlaceholder](https://jsonplaceholder.typicode.com/)) to send HTTP requests.  
   - Write Python scripts to:  
     - Fetch data using a **GET request**.  
     - Create a new resource using a **POST request**.  
     - Update an existing resource using a **PUT request**.  
     - Delete a resource using a **DELETE request**.  

   **Example Python Script (GET request):**  
   ```python
   import requests

   response = requests.get("https://jsonplaceholder.typicode.com/posts/1")
   print(response.status_code)
   print(response.json())
   ```

4. **Postman Testing** 🧪  
   - Import the public API endpoints into Postman.  
   - Test all the HTTP methods you used in Python.  
   - Observe and document the response structure and status codes (e.g., 200, 201, 404).  

---

#### **Steps to Complete** 🚀  

1. **Install Required Tools:**  
   - Install Postman ([Download Here](https://www.postman.com/downloads/)).  
   - Set up your Python environment with the `requests` library:  
     ```bash
     pip install requests
     ```

2. **Interact with an HTML Form:**  
   - Use [webhook.site](https://webhook.site/) or a similar tool to observe form submissions without needing to set up a backend.  

3. **Write Python Scripts:**  
   - Use the `requests` library to interact with the [JSONPlaceholder](https://jsonplaceholder.typicode.com/) API.  
   - Write separate scripts for GET, POST, PUT, and DELETE methods.  

4. **Test API in Postman:**  
   - Import and test the same endpoints from JSONPlaceholder.  
   - Experiment with request bodies and headers to see different responses.  

5. **Document Your Findings:**  
   - Write a short report summarizing:  
     - HTTP methods used and their purposes.  
     - Examples of request and response headers.  
     - Observations from Postman and developer tools.  

---

#### **Additional Information** ℹ️  

- **Status Codes to Know:**  
  - 200: OK  
  - 201: Created  
  - 400: Bad Request  
  - 404: Not Found  
  - 500: Internal Server Error  

- **Tools:**  
  - Use [Postman Documentation](https://learning.postman.com/) for additional guidance.  
  - Practice with free public APIs for more experience (e.g., [OpenWeatherMap](https://openweathermap.org/api)).  

---

#### **Upload the project to your GitHub** 📤  

1. Your Python project files.  
2. Screenshots of your Postman tests.  
3. A brief report (1-2 pages) summarizing your findings.  

💡 **Pro Tip:** Focus on the interaction between client and server. Pay attention to how URLs, headers, and bodies work together in HTTP communication.  

Happy learning! 🎉  

---
