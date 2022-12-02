string[] ThreeChar (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    string[] resultArray = new string[count];
    count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        
        if(array[j].Length <= 3) 
        {
            resultArray[count] = array[j];
            count++;
        }
    }
    return resultArray;
}
void ShowStrArray (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
string[] simbols = {"hi", "!) ", "Hello","its",  "Qwerty","What's your name?", " ME"};
string[] myArray = ThreeChar(simbols);
ShowStrArray(myArray);
