//int a1 = 10, b1 =20, c1 = 34, a2= 4454, b2= 33, c2 =56, a3= 32, b3= 78, c3 = 86; 

int [] array = {15,52,63,47,58,69,70,83,95};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result= arg3;
    return result;
}
//int max1= Max (a1,b1,c1);
//int max2 = Max (a2,b2,c2);
//int max3 = Max (a3,b3,c3);
//int max4 = Max (max1, max2, max3);
int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6], array[7],array[8]));

Console.WriteLine(max);

