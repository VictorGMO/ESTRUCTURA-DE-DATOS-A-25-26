using System;
using System.Collections.Generic;
using System.Linq;

public class Traductor
{
    //Diccionario privado que almacena las palabras en español y su traducción al ingles
    //usa comparador sin distinción entre mayúsculas/minúsculas para facilitar búsquedas
    private readonly Dictionary<string, string> _diccionario;

    //inicializa el diccionario con palabras base sugeridas en la guia.
    public Traductor()
    {
        _diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "tiempo", "time" }, { "persona", "person" }, { "año", "year" },
            { "camino", "way" }, { "forma", "way" }, { "día", "day" },
            { "cosa", "thing" }, { "hombre", "man" }, { "mundo", "world" },
            { "vida", "life" }, { "mano", "hand" }, { "parte", "part" },
            { "niño", "child" }, { "niña", "child" }, { "ojo", "eye" },
            { "mujer", "woman" }, { "lugar", "place" }, { "trabajo", "work" },
            { "semana", "week" }, { "caso", "case" }, { "punto", "point" },
            { "tema", "point" }, { "gobierno", "government" }, { "empresa", "company" },
            { "compañía", "company" }
        };
    }

    //agrega una nueva palabra al diccionario si aun no existe
    //Retorna true si se agrego; false si ya existia.
    public bool AgregarPalabra(string espanol, string ingles)
    {
        espanol = espanol.Trim().ToLower();
        if (string.IsNullOrEmpty(espanol) || string.IsNullOrEmpty(ingles))
            return false;

        if (_diccionario.ContainsKey(espanol))
            return false;

        _diccionario[espanol] = ingles.Trim();
        return true;
    }

    //traduce una frase completa del español al ingles.
    //solo traduce palabras que existen en el diccionario; el resto se mantiene intacto.
    //conserva signos de puntuación y respeta mayúsculas iniciales cuando es posible.
    public string TraducirFrase(string frase)
    {
        if (string.IsNullOrWhiteSpace(frase))
            return string.Empty;

        //separa la frase en tokens respetando espacios y signos comunes
        char[] separadores = { ' ', ',', '.', ';', ':', '!', '?', '\t', '\n' };
        string[] tokens = frase.Split(separadores, StringSplitOptions.None);
        var resultado = new List<string>();

        foreach (string token in tokens)
        {
            if (string.IsNullOrEmpty(token))
            {
                resultado.Add(token); //mantiene separadores vacíos si existen
                continue;
            }

            //extrae la palabra limpia (sin signos) para buscar en el diccionario
            string palabraLimpia = new string(token.Where(c => char.IsLetter(c)).ToArray());
            bool tieneMayusculaInicial = palabraLimpia.Length > 0 && char.IsUpper(token[0]);

            if (!string.IsNullOrEmpty(palabraLimpia) && _diccionario.TryGetValue(palabraLimpia.ToLower(), out string traduccion))
            {
                //Aplica mayuscula inicial si la original la tenía
                if (tieneMayusculaInicial && traduccion.Length > 0)
                    traduccion = char.ToUpper(traduccion[0]) + traduccion.Substring(1);

                //reemplaza solo la parte alfabetica, conservando cualquier signo adjunto
                string reemplazo = token.Replace(palabraLimpia, traduccion);
                resultado.Add(reemplazo);
            }
            else
            {
                resultado.Add(token);
            }
        }

        return string.Join(" ", resultado).Trim();
    }
}