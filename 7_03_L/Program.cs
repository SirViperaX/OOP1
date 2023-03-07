using _7_03_L;

/*Stack<int> st = new Stack<int>();
for(int i = 0; i < 10; i++)
{
    st.Push(i); 
}
while(st.Count > 0)
{
    Console.WriteLine(st.Pop());
}
try
{
    st.Pop();
}
catch(InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}
int result;
bool ok = st.TryPop(out result);
if (ok)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Pop failed. Stack empty");
}*/

MyStack ms = new MyStack();
Random rnd  = new Random();

while(true)
{
	try
	{
		ms.Push(rnd.Next(1000));
	}
	catch (StackFullException e)
	{
		Console.WriteLine(e.Message);
		throw;
	}
}

while(!ms.Empty)
{
	Console.WriteLine(ms.Pop());
}