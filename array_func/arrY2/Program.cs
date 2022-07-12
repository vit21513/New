//int[]array ={1,12,31,4,15,16,17,18};
void fillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
       collection[index]= new Random().Next(1, 10);
       index++;
    }
}

int[] array = new int [10];

fillArray(array);
printArray(array);


void printArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
       
    }
    return;


} 

int n = array.Length;
int find = 18;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {Console.WriteLine(index);
    break;
    }


    index++;
}
