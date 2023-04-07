Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");
int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;
PrintX(xa, ya);
PrintX(xb, yb);
PrintX(xc, yc);
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
int x = xa, y = xb;
int count = 0;
while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        Medium(xa, ya);
    }
    if (what == 1)
    {
        Medium(xb, xb);
    }
    if (what == 2)
    {
        Medium(xc, yc);
    }
    PrintX(x, y);
    count++;
}
void PrintX(int a, int b)
{
    Console.SetCursorPosition(a, b);
    Console.WriteLine("+");
}
void Medium(int A, int B)
{
    x = (x + A) / 2;
    y = (y + B) / 2;
}
