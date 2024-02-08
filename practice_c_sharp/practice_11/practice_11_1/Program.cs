using System;
using System.IO;
class ExceptionTest
{
    static void Write(string filename, string message)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            try
            {
                sw.WriteLine(message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                sw.Close();
                Console.WriteLine("file closed succeccfully");
            }
        }
       
    }

    static void Main()
    {
        Write("D:\\practice_c_sharp\\practice_11\\practice_11_1\\content.txt", "Good Morning.");
    }
}
   