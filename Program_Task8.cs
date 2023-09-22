Console.Write("Enter a number: ");
string number = Console.ReadLine();
int N = Int32.Parse(number);

int count = 2;
while(count < N-1)
{
    Console.Write(count);        
    Console.Write(", ");        
    count = count + 2;
}
if(count == N)
{
    Console.Write(count);        
    Console.Write(" ");
}
if(count == N-1)
{
    Console.Write(count);        
    Console.Write(" ");
}