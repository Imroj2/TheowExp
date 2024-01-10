class Program
{
    static void Main(string[] args)
    {
        try
        {
            //code that might throw an exception
            int age = 5;
            if(age<0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
        }
        catch(ArgumentException ex)
        {
           //Handle the exception
           Console.WriteLine("Error: " + ex.Message);
        }
    }
}