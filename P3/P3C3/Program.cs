
int x = 1;
int y = 2;
addition(x, y);

int i = 3;
int j = 4;
addition(i, j);

int var1 = 5;
int var2 = 6;
addition(var1, var2);

static void addition(int a, int b)
{
    operation();
    Console.WriteLine("la somme est de " + (a + b));
}

static void operation()
{
    Console.WriteLine("Essayons une addition");
}