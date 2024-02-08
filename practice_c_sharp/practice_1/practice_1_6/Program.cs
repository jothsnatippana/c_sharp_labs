class EnvironmentInteraction
{
    static int Main(string[] args )
    {
        foreach( string arg in args ) {
            Console.WriteLine(arg);
        }
        return 0;
    }
}