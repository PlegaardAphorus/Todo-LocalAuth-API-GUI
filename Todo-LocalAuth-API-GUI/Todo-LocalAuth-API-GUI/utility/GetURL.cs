using Microsoft.VisualBasic;

namespace Todo_LocalAuth_API_GUI.utility
{
    public class URL
    {
        public static string GetURL()
        {
            string path = @"..\..\..\..\..\port.txt";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string port = sr.ReadLine();

                if (port.Contains("HTTPS_PORT:"))
                {
                    port = port.Substring(port.IndexOf(":") + 1);
                    return $@"https://localhost:{port}/api/";
                }
                else
                {
                    throw new Exception("Die Datei enthält keinen Gültigen Port");
                }
            }
            else
            {
                throw new Exception("Es wurde keine port.txt Datei gefunden.");
            }
        }
    }
}