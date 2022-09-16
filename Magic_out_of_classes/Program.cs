int[,] v = {
    {40, 1},
    {1, 30},
    {80, 30}
};
int x = v[0, 0], y = v[0, 1];
int count = 2000;

while(true)
{
    Console.Clear();
    for (int i = 1; i < count; i++)
    {
        int what = new Random().Next(0, 3);
        x = (x + v[what, 0]) / 2;
        y = (y + v[what, 1]) / 2;

        Console.SetCursorPosition(x, y);
        Console.WriteLine(".");
    }
    Thread.Sleep(10);
    v[1, 0]++;
    v[2, 0]--;
}