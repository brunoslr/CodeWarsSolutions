/* Studio Sol
 * Create a copy of the Game Scrabble with our own set of rules.
 * Given the letter pontuation (each letter group has different values) rules and 
 * a the word database. If two words are tied with the same value, 
 * return the one with the smallest length (if the ties persists return any).
 * You are supposed to read the input from a the system regular input, and print:
 * The following data for a single word: 
 * The word it hits in the database, the score, and unused letters. 
 * 
 * You should treat accentuation on the database to match regular letters, 
 * there is no case sensitivity;
 * You should treat special characters from the input as unmatchable caracters (leftovers)
 
 * You have 4 hours and can use any language you feel confortable with
 
 "Manada", "porta", "Dado", "Já", "radiografia", "matemática", "prédios", "implementação",
 "balão", "Xícara", "Tédio", "Livro", "superior", "Profissão", "Reunião", "Prédios", "Botânica", 
 "Caixas", "Infestação", "Premiada", "Ratos", "Ruído", "Empresa", "Emissário", "Fratura", 
 "Gratuito", "Hídrico", "Jantar", "Montagem", "Nuvem", "Operação", "Pato", "Pé", "Queijo", 
 "Quintal", "rota", "Tatuagem", "Uva", "Último", "Vitupério", "Zangado", "Dor".

 Example:
    "Digite as letras disponíveis nesta jogada: "
     input-> oahbascaiuxia
    "Abacaxi, palavra de 18 pontos"
    "Sobraram: oahsiu"

My original solution

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
					
public class Program
{

    public static Dictionary<string, int> wordsDictionary;

    // O metodo principal 
    // carrega um dicionario com os valores das palavras validas (utilizei o site regex101.com para efetuar uma limpeza na entrada antes de iniciar o carregamento),
    // recebe a entrada da linha de comando;
    // itera sobre o dicionario criando uma expressao regular para cada palavra, que entao eh verificada contra a entrada
    // a palavra que conferir o maior valor de pontos eh salva e retornada, bem como a pontuacao
    // como no enunciado nao existia uma regra clara para pontuacao de cada letra, 
    // considerei o padrao como o valor da propriedade Length da palavra formada( por exemplo a letra á tem valor devido a propriedade 2) 
    // o valor de cada letra pode ser facilmente modificado no metodo
    // para facilitar o processo de verificacao da expressao regular os valores de entrada e do dicionario foram ordenados
    // ao fim sao verificadas quais letras nao foram usadas na montagem da palavra (bem como caracteres especiais nao tratados)
    public static void Main()
    {
        CreateDictionary();

        Console.WriteLine("Digite as letras disponíveis nesta jogada: ");

        string originalInput = Console.ReadLine();

        string letters = SortInput(originalInput);

        string word = "";
        int wordValue = 0;
        int wordLenght = 0;

        Regex regexTest;


        foreach (var item in wordsDictionary)
        {
            regexTest = CreateRegex(item.Key);
            if (regexTest.IsMatch(letters))
            {
                if (item.Value > wordValue)
                {
                    word = item.Key;
                    wordValue = item.Value;
                    wordLenght = item.Key.Length;
                }

                if (item.Value == wordValue && (CleanString(item.Key).Length < CleanString(word).Length))
                {
                    word = item.Key;
                    wordValue = item.Value;
                    wordLenght = item.Key.Length;
                }
            }
        }

        string leftover = GetLeftOvers(letters, word);

        Console.WriteLine("{0} palavra de {1} pontos", word.ToUpper(), wordValue);
        Console.WriteLine("Sobraram: {0}", leftover);


    }

    //Teste a palavra formada contra a entrada para verificar as sobras
    public static string GetLeftOvers(string input, string word)
    {

        if (input.Length == 0)
            return null;
        if (word.Length == 0)
            return input;

        word = CleanString(word);

        int removalIndex = -1;

        var inputList = input.Select(x => x).ToList();

        for (int i = 0; i < word.Length; i++)
        {
            removalIndex = inputList.IndexOf(word[i]);
            if (removalIndex >= 0)
                inputList.RemoveAt(removalIndex);
        }

        return string.Concat(inputList);
    }



    public static string SortInput(string letters)
    {

        return string.Concat(CleanString(letters).OrderBy(x => x));
    }

    //Funçao que monta o regex de cada palavra no banco a ser testado contra a entrada
    //verifica os trechos que devem bater e coloca um "dont care (.*)" entre eles 
    public static Regex CreateRegex(string word)
    {

        word = string.Concat(CleanString(word).OrderBy(x => x));
        string finalRegex = "";
        for (int i = 0; i < word.Length - 1; i++)
        {
            finalRegex += word[i];
            if (word[i] != word[i + 1])
                finalRegex += "(.*)";
        }
        finalRegex += word[word.Length - 1];

        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Compiled;

        return new Regex(finalRegex, options);

    }

    //tratamento para remoçao dos caracteres especiais apresentados no banco de palavras
    //considerando o jogo original que não considera caracteres especiais na montagem das palavras
    public static string CleanString(string word)
    {
        return word.ToLower()
            .Replace("á", "a")
            .Replace("í", "i")
            .Replace("ç", "c")
            .Replace("ã", "a")
            .Replace("ú", "u")
            .Replace("é", "e");
    }

    //monta o banco de palavras a partir de uma string. Efetuei uma primeira limpeza na entrada utilizando o site regex101
    public static void CreateDictionary()
    {
        wordsDictionary = new Dictionary<string, int>();

        string inputDictionary = "Abacaxi Manada mandar porta mesa Dado Mangas Já coisas radiografia matemática Drogas prédios implementação computador balão Xícara Tédio faixa Livro deixar superior Profissão Reunião Prédios Montanha Botânica Banheiro Caixas Xingamento Infestação Cupim Premiada empanada Ratos Ruído Antecedente Empresa Emissário Folga Fratura Goiaba Gratuito Hídrico Homem Jantar Jogos Montagem Manual Nuvem Neve Operação Ontem Pato Pé viagem Queijo Quarto Quintal Solto rota Selva Tatuagem Tigre Uva Último Vitupério Voltagem Zangado Zombaria Dor";

        foreach (string s in inputDictionary.Split(' '))
        {
            wordsDictionary.Add(s, GetWordValue(s));
        }
        //PrintDictionaryContent();	
    }

    //Caso seja passada uma outra regra pra pontuacao mudar aqui. 
    // Alterado aos 45 do segundo tempo, =) Acredito que esteja funcionando bem
    public static int GetWordValue(string word)
    {
        int wordValue = 0;

        word = CleanString(word).ToUpper();

        for (int i = 0; i < word.Length; i++)
        {
            if ("EAIONRTLSU".Contains(word[i])) wordValue += 1;
            else if ("WDG".Contains(word[i])) wordValue += 2;
            else if ("BCMP".Contains(word[i])) wordValue += 3;
            else if ("FHV".Contains(word[i])) wordValue += 4;
            else if ("JX".Contains(word[i])) wordValue += 8;
            else if ("QZ".Contains(word[i])) wordValue += 10;
        }


        return wordValue;
    }

    //Debug only
    public static void PrintDictionaryContent()
    {
        foreach (var item in wordsDictionary)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }

}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{
    class ScrabblePrototype
    {
    }
}

