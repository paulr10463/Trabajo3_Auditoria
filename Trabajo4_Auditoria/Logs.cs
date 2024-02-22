using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4_Auditoria
{
    internal class Logs
    {
        public static void LOG(string msj)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            string directorio = $"{Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)}\\LOG\\";
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            try
            {
                StreamWriter sw = File.AppendText(directorio + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + "auditoria_db.log");
                sw.WriteLine("[" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff") + "] " + msj);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
