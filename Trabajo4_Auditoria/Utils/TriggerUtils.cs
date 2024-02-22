using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trabajo4_Auditoria.Utils
{
    public class TriggerUtils
    {
        public static void getTableAndColumns(string script)
        {

            // Expresiones regulares para identificar tablas y columnas
            string tablaPattern = @"\bFROM\s+\[dbo\]\.(\w+)\b";
            string columnaPattern = @"\b\w+\.\w+\b";

            // Buscar tablas involucradas
            List<string> tablasInvolucradas = GetMatches(script, tablaPattern);

            // Buscar columnas respectivas sobre las cuales se revisa la integridad referencial
            List<string> columnasReferenciales = GetMatches(script, columnaPattern);

            // Imprimir resultados
            Console.WriteLine("Tablas involucradas:");
            foreach (var tabla in tablasInvolucradas)
            {
                Console.WriteLine(tabla);
            }

            Console.WriteLine("\nColumnas referenciales:");
            foreach (var columna in columnasReferenciales)
            {
                Console.WriteLine(columna);
            }
        }

        static List<string> GetMatches(string input, string pattern)
        {
            List<string> matches = new List<string>();
            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(input))
            {
                matches.Add(match.Groups[1].Value);
            }

            return matches;
        }
    }
}
