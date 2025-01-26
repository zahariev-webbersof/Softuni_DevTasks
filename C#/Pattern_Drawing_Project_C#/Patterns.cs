using System;

public static class Patterns
{
    public static string DrawRightAngledTriangle(int rows)
    {
        var result = "";
        for (int i = 1; i <= rows; i++)
        {
            result += new string('*', i) + "\n";
        }
        return result;
    }

    public static string DrawSquareWithHollowCenter(int rows)
    {
        var result = "";
        for (int i = 1; i <= rows; i++)
        {
            result += i == 1 || i == rows
                ? new string('*', rows) + "\n"
                : "*" + new string(' ', rows - 2) + "*\n";
        }
        return result;
    }

    public static string DrawDiamond(int rows)
    {
        var result = "";
        for (int i = 1; i <= rows; i++)
            result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\n";

        for (int i = rows - 1; i > 0; i--)
            result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\n";

        return result;
    }

    public static string DrawLeftAngledTriangle(int rows)
    {
        var result = "";
        for (int i = rows; i > 0; i--)
        {
            result += new string('*', i) + "\n";
        }
        return result;
    }

    public static string DrawHollowSquare(int rows)
    {
        return DrawSquareWithHollowCenter(rows);
    }

    public static string DrawPyramid(int rows)
    {
        var result = "";
        for (int i = 1; i <= rows; i++)
        {
            result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\n";
        }
        return result;
    }

    public static string DrawReversePyramid(int rows)
    {
        var result = "";
        for (int i = rows; i > 0; i--)
        {
            result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\n";
        }
        return result;
    }

    public static string DrawRectangleWithHollowCenter(int width, int height)
    {
        var result = "";
        for (int i = 1; i <= height; i++)
        {
            result += i == 1 || i == height
                ? new string('*', width) + "\n"
                : "*" + new string(' ', width - 2) + "*\n";
        }
        return result;
    }

    public static string DrawSpiral(int rows)
    {
        // Ensure rows are a positive number for the square grid
        if (rows <= 0)
            return "❌ Rows must be a positive number!";

        char[,] spiral = new char[rows, rows];
        for (int i = 0; i < rows; i++) // Initialize with spaces
            for (int j = 0; j < rows; j++)
                spiral[i, j] = ' ';

        int top = 0, bottom = rows - 1, left = 0, right = rows - 1;

        while (top <= bottom && left <= right)
        {
            // Fill top row (left to right)
            for (int i = left; i <= right; i++)
                spiral[top, i] = '*';
            top++;

            // Fill right column (top to bottom)
            for (int i = top; i <= bottom; i++)
                spiral[i, right] = '*';
            right--;

            // Fill bottom row (right to left)
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    spiral[bottom, i] = '*';
                bottom--;
            }

            // Fill left column (bottom to top)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    spiral[i, left] = '*';
                left++;
            }
        }

        // Convert the 2D array into a string representation
        var result = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result += spiral[i, j];
            }
            result += "\n";
        }

        return result;
    }

    public static string DrawCheckerboard(int rows)
    {
        var result = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result += (i + j) % 2 == 0 ? "■" : " ";
            }
            result += "\n";
        }
        return result;
    }

    public static string DrawAlphabetTriangle(int rows)
    {
        var result = "";
        char letter = 'A';
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                result += letter++ + " ";
                if (letter > 'Z') letter = 'A';
            }
            result += "\n";
        }
        return result;
    }
}
