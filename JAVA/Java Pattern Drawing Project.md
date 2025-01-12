---

# 🖼️ Java Pattern Drawing Project

Welcome to the **Java Pattern Drawing Project**! 🎉 This project is designed to help you practice Java concepts like nested loops, conditional statements, and user input.  

---

## 📝 Project Overview

Your task is to create a Java program that draws various patterns in the console. The user will choose a pattern, provide the required dimensions, and the program will display the result.

---

## 🎯 Objectives

By completing this project, you will:  
1️⃣ Learn how to use **nested loops** to create patterns.  
2️⃣ Implement **if-else conditions** to add logic to your program.  
3️⃣ Handle **user input** to make the program dynamic.  
4️⃣ Understand how to manage **alignment** using spaces and characters.  

---

## 🚀 Patterns to Implement

1️⃣ **Right-angled Triangle**  
```
*
**
***
****
*****
```

2️⃣ **Square with Hollow Center**  
```
*****
*   *
*   *
*   *
*****
```

3️⃣ **Diamond**  
```
  *
 ***
*****
 ***
  *
```

4️⃣ **Left-angled Triangle**  
```
****
***
**
*
```

5️⃣ **Hollow Square**  
```
******
*    *
*    *
*    *
*    *
******
```

6️⃣ **Pyramid**  
```
   *
  ***
 *****
*******
```

7️⃣ **Reverse Pyramid**  
```
*******
 *****
  ***
   *
```

8️⃣ **Rectangle with Hollow Center**  
```
********
*      *
*      *
********
```

---

## 📋 Requirements

1️⃣ **Console Menu**  
- Display a menu with all patterns.  
- Let the user select a pattern by entering a number (e.g., `1` for Right-angled Triangle).

2️⃣ **Dynamic Inputs**  
- Ask the user for dimensions like the number of rows or size of the shape.  
- For rectangles, ask for both width and height.

3️⃣ **Pattern Logic**  
- Use nested loops to create the specified pattern based on the inputs.  
- Align patterns using spaces where necessary.  

4️⃣ **Validation**  
- Validate user input to ensure it's a valid choice and reasonable size (e.g., no negative or zero values).  

5️⃣ **Optional Features**  
- Add an option for users to restart the program or exit.  

---

## 🌟 Bonus Ideas  

- Add more patterns like spirals, checkerboards, or alphabets.  
- Allow the program to save patterns to a text file.  
- Add color to the output using libraries like `ANSI escape codes` or `jansi`.  

---

## 🛠️ Code Skeleton  

Here’s the skeleton code your students can use to implement the project:

```java
import java.util.Scanner;

public class PatternDrawing {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Step 1: Display a menu to the user
        System.out.println("🌟 Welcome to the Java Pattern Drawing Program!");
        System.out.println("Choose a pattern type:");
        System.out.println("1. Right-angled Triangle");
        System.out.println("2. Square with Hollow Center");
        System.out.println("3. Diamond");
        System.out.println("4. Left-angled Triangle");
        System.out.println("5. Hollow Square");
        System.out.println("6. Pyramid");
        System.out.println("7. Reverse Pyramid");
        System.out.println("8. Rectangle with Hollow Center");

        // Step 2: Get the user's choice
        System.out.print("Enter the number corresponding to your choice: ");
        int choice = scanner.nextInt();

        // Step 3: Get dimensions based on choice
        int rows = 0, width = 0, height = 0;
        if (choice >= 1 && choice <= 7) {
            // TODO: Prompt the user to enter the number of rows
        } else if (choice == 8) {
            // TODO: Prompt the user to enter the width and height of the rectangle
        } else {
            System.out.println("❌ Invalid choice! Please restart the program.");
            return;
        }

        // Step 4: Generate the selected pattern
        switch (choice) {
            case 1: // Right-angled Triangle
                // TODO: Use nested loops to create a right-angled triangle
                break;

            case 2: // Square with Hollow Center
                // TODO: Use nested loops to create a square with a hollow center
                break;

            case 3: // Diamond
                // TODO: Use nested loops to create a diamond shape
                break;

            case 4: // Left-angled Triangle
                // TODO: Use nested loops to create a left-angled triangle
                break;

            case 5: // Hollow Square
                // TODO: Use nested loops to create a hollow square
                break;

            case 6: // Pyramid
                // TODO: Use nested loops to create a centered pyramid
                break;

            case 7: // Reverse Pyramid
                // TODO: Use nested loops to create a reverse pyramid
                break;

            case 8: // Rectangle with Hollow Center
                // TODO: Use nested loops to create a rectangle with a hollow center
                break;

            default:
                System.out.println("❌ Invalid choice! Please restart the program.");
                break;
        }

        // Step 5: Optional - Allow the user to restart or exit
        // TODO: Add a feature to let the user restart the program or exit
    }
}
```

---

## 🏁 Conclusion  

This project will help you practice fundamental Java programming skills while building something fun and interactive. Follow the steps, fill in the logic, and don’t hesitate to experiment with additional features. Have fun coding! 🚀
