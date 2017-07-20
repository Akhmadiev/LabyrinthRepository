using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    static class Errors
    {
        static List<string> error = new List<string>();        

        public static void AppendError(string msg)
        {
            error.Add(msg);
            new GameForm().ErrorsHandler(error.ToString());
        }

    }
}
