using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestDownloadFile.Models;
using Attachment = TestDownloadFile.Models.Attachment;

#region MyRegion
string currentDirectory = Directory.GetCurrentDirectory();
string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
string jsonFilePath = Path.Combine(projectDirectory, "Json", "example.json");
string jsonContent = File.ReadAllText(jsonFilePath);
string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string filePathSave = Path.Combine(myDocumentsPath, "Test Download PDF\\{name}"); ;

var options = new JsonSerializerOptions
{
    ReferenceHandler = ReferenceHandler.Preserve, // Manejar referencias circulares
    PropertyNameCaseInsensitive = true
};

var showRfis = JsonSerializer.Deserialize<ModelV3>(jsonContent, options);


#endregion

#region LINQ
var all = showRfis.attachments.Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name }).ToList();

var allwebImage = showRfis.web_images.Select(x => new WebImagev1 { url = x.url, filename = x.filename, name = x.name }).ToList();

var allAssigments = showRfis.assignments.SelectMany(b => b.attachments.Select(c => new Attachmentv1 { url = c.url, filename = c.filename, name = c.name })).ToList();

var allAttachments = showRfis.attachments
    .Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name })
    .Concat(showRfis.web_images.Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name }))
    .Concat(showRfis.assignments.SelectMany(b => b.attachments.Select(c => new Attachmentv1 { url = c.url, filename = c.filename, name = c.name })))
    .ToList();

// Extract all PDF URLs
//var urls = doc.RootElement
//    .GetProperty("questions") // Accede al array de preguntas (si es un array)
//    .EnumerateArray() // Itera sobre cada pregunta
//    .SelectMany(question => question.GetProperty("answers").EnumerateArray()) // Accede al array de 'answers' de cada pregunta
//    .Where(answer => answer.TryGetProperty("attachments", out var attachments)) // Asegura que existen 'attachments'
//    .SelectMany(answer => answer.GetProperty("attachments").EnumerateArray()) // Itera sobre los adjuntos
//    .Where(attachment => attachment.TryGetProperty("url", out var url)) // Asegura que existen 'url' en cada adjunto
//    .Select(attachment => attachment.GetProperty("url").GetString()) // Extrae la URL
//    .ToList();
//var allUrls = showRfis.Questions.Select(aws => aws.Attachments.Select(atms => atms.Url).ToList());

//allUrls += showRfis.Questions.Select(qst => qst.Answers.Select(aws => aws.Attachments.Select(atms => atms.Url).ToList()));

//var testst = showRfis.Questions.Select(qst => qst.Answers.Select(aws => aws.Attachments.Select(atms => atms.Url).ToList()));


//var allUrls = showRfis.Questions
//    .SelectMany(qst => qst.Attachments.Select(atms => atms.Url))
//    .Concat(showRfis.Questions.SelectMany(qst => qst.Answers.SelectMany(aws => aws.Attachments.Select(atms => atms.Url))))
//    .ToList();

//var allAttachments = showRfis.Questions
//    .SelectMany(qst => qst.Attachments.Select(atms => new Attachment { Url = atms.Url, Name = atms.Name, Filename = atms.Filename }))
//    .Concat(showRfis.Questions.SelectMany(qst => qst.Answers.SelectMany(aws => aws.Attachments.Select(atms => new Attachment { Url = atms.Url, Name = atms.Name, Filename = atms.Filename }))))
//    .ToList();

#endregion


DownloadFileAsyncWithModel(allAttachments, filePathSave);

#region Metodos

static async Task DownloadFileAsyncWithModel(List<Attachmentv1> urls, string folderPath)
{
    using (HttpClient client = new HttpClient())
    {
        foreach (var url in urls)
        {
            try
            {
                string pdfName = url.filename ?? url.name;
                string filePath = folderPath.Replace("{name}", pdfName);
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(url.url, filePath);
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error HTTP al descargar el archivo desde {url}: {httpEx.Message}");
            }
        }
    }
}

static async Task DownloadFileAsyncWithHttpClient(List<Attachmentv1> urls, string folderPath)
{
    using (HttpClient client = new HttpClient())
    {
        foreach (var url in urls)
        {
            try
            {
                // Usa el filename si está disponible, sino el nombre
                string pdfName = url.filename ?? url.name;
                // Genera la ruta completa para guardar el archivo
                string filePath = Path.Combine(folderPath, pdfName);

                // Valida que la URL sea válida antes de continuar
                if (string.IsNullOrEmpty(url.url))
                {
                    Console.WriteLine($"La URL para el archivo {pdfName} está vacía. Saltando.");
                    continue;
                }

                // Descarga el contenido del archivo como un arreglo de bytes
                Console.WriteLine($"Descargando archivo desde {url.url}...");
                byte[] fileBytes = await client.GetByteArrayAsync(url.url);

                // Escribe el archivo en la ruta especificada
                await File.WriteAllBytesAsync(filePath, fileBytes);
                Console.WriteLine($"Archivo descargado exitosamente: {filePath}");
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error HTTP al descargar el archivo desde {url.url}: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general al descargar el archivo {url.filename}: {ex.Message}");
            }
        }
    }
}

#endregion
