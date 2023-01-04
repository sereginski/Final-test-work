// test work
Console.Clear();
string[] array = {"Happy", "New", "Year", "2023", "Hi"};
string[] newArray = new string[array.Length];

void InputNewArray(string[] array, string[] newArray)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++)
   {
       if(array[i].Length <= 3)
       {
          newArray[count] = array[i];
          count++;
       }
   }
}
   
void Print(string[] mas)
{
  for(int i = 0; i < mas.Length; i++)
  {
     Console.WriteLine($"{mas[i]}");
  }
  Console.WriteLine();
}
InputNewArray(array, newArray);
Print(newArray);