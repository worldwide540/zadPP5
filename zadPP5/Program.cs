using System;

class TextAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Введите текст (для завершения введите пустую строку):");
        string inputText = "";
        string line;
        while ((line = Console.ReadLine()) != "")
        {
            inputText += line + "\n";
        }

        // Разделение текста на абзацы
        string[] paragraphs = inputText.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
        int paragraphCount = paragraphs.Length;

        int wordCount = 0;
        int sentenceCount = 0;

        foreach (string paragraph in paragraphs)
        {
            // Разделение абзаца на предложения
            string[] sentences = paragraph.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            sentenceCount += sentences.Length;

            foreach (string sentence in sentences)
            {
                // Разделение предложения на слова
                string[] words = sentence.Split(new char[] { ' ', ',', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }

        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");
        Console.WriteLine($"Количество абзацев: {paragraphCount}");
    }
}
