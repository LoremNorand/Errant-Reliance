using System;
using System.IO;

namespace EReliance.Utility
{
    public static class HtmlManager
    {
        public static void WriteHtmlFile(string content)
        {
            // Оборачиваем контент в HTML-шаблон
            content = WrapHtml(content);

            // Указываем имя файла
            string filePath = "index.html";

            try
            {
                // Записываем содержимое в файл
                File.WriteAllText(filePath, content);

                // Информируем пользователя об успешном создании файла
                Console.WriteLine($"HTML файл успешно создан по пути: {Path.GetFullPath(filePath)}");
            }
            catch (Exception ex)
            {
                // Обработка ошибок записи файла
                Console.WriteLine("Ошибка при записи HTML файла: " + ex.Message);
            }
        }

        private static string WrapHtml(string content)
        {
            return $@"
            <!DOCTYPE html>
            <html lang=""ru"">
            <head>
                <meta charset=""UTF-8"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>Document</title>
                <!-- Подключаем стили, если они нужны -->
                <link rel=""stylesheet"" href=""styles.css"">
            </head>
            <body>
                {content}
            </body>
            </html>";
        }
    }
}
