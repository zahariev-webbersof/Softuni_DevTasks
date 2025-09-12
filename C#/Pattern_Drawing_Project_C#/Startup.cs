using System;

class Startup
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display menu
            Console.WriteLine("🌟 Welcome to the Enhanced C# Pattern Drawing Program!");
            Console.WriteLine("Choose a pattern type:");
            Console.WriteLine("1. Right-angled Triangle");
            Console.WriteLine("2. Square with Hollow Center");
            Console.WriteLine("3. Diamond");
            Console.WriteLine("4. Left-angled Triangle");
            Console.WriteLine("5. Hollow Square");
            Console.WriteLine("6. Pyramid");
            Console.WriteLine("7. Reverse Pyramid");
            Console.WriteLine("8. Rectangle with Hollow Center");
            Console.WriteLine("9. Spiral");
            Console.WriteLine("10. Checkerboard");
            Console.WriteLine("11. Alphabet Triangle");
            Console.WriteLine("12. Exit");

            Console.Write("Enter the number corresponding to your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 12)
            {
                Console.WriteLine("❌ Invalid choice! Please enter a valid number.");
                continue;
            }

            if (choice == 12) break;

            Console.Clear();

            // Handle input dimensions
            int rows = 0, width = 0, height = 0;
            if (choice >= 1 && choice <= 11)
            {
                if (choice != 8)
                {
                    Console.Write("Enter the number of rows: ");
                    if (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
                    {
                        Console.WriteLine("❌ Invalid input! Rows must be a positive number.");
                        continue;
                    }
                }
                else
                {
                    Console.Write("Enter the width of the rectangle: ");
                    if (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
                    {
                        Console.WriteLine("❌ Invalid input! Width must be a positive number.");
                        continue;
                    }

                    Console.Write("Enter the height of the rectangle: ");
                    if (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
                    {
                        Console.WriteLine("❌ Invalid input! Height must be a positive number.");
                        continue;
                    }
                }
            }

            // Generate the selected pattern
            Console.ForegroundColor = ConsoleColor.Green; // Set pattern color
            string patternOutput = choice switch
            {
                1 => Patterns.DrawRightAngledTriangle(rows),
                2 => Patterns.DrawSquareWithHollowCenter(rows),
                3 => Patterns.DrawDiamond(rows),
                4 => Patterns.DrawLeftAngledTriangle(rows),
                5 => Patterns.DrawHollowSquare(rows),
                6 => Patterns.DrawPyramid(rows),
                7 => Patterns.DrawReversePyramid(rows),
                8 => Patterns.DrawRectangleWithHollowCenter(width, height),
                9 => Patterns.DrawSpiral(rows),
                10 => Patterns.DrawCheckerboard(rows),
                11 => Patterns.DrawAlphabetTriangle(rows),
                _ => "❌ Invalid choice!"
            };
            Console.WriteLine(patternOutput);
            Console.ResetColor(); // Reset console color

            // Ask if the user wants to save the pattern
            Console.Write("\nDo you want to save the pattern to a file? (y/n): ");
            if (Console.ReadLine()?.ToLower() == "y")
            {
                Utilities.SavePatternToFile(patternOutput, "PatternsOutput.txt");
                Console.WriteLine("✅ Pattern saved to PatternsOutput.txt");
            }

            // Ask if the user wants to restart
            Console.Write("\nDo you want to restart the program? (y/n): ");
            if (Console.ReadLine()?.ToLower() != "y")
                break;

            Console.Clear();
        }
    }
}
