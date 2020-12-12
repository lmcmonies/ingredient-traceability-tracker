using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceabilityLibrary
{
    public static class GlobalConfig
    {
        public static List<IFileConnection> Connection { get; private set; } = new List<IFileConnection>();

        public static void InitialiseConnection(bool textFiles)
        {
            if (textFiles)
            {
                //if true a FileUtility object is created and added to the Connection list so a connection 
                //to the text files is always available from the GUI.
                FileUtility textConnection = new FileUtility();
                Connection.Add(textConnection);
            }
        }
    }
}
