//найти максимум из массива
Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 23;
int b1 = 65;
int c1 = 2033;
int a2 = 51;
int b2 = 7;
int c2 = 43;
int a3 = 69;
int b3 = 2033;
int c3 = 93;
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.Write(max);