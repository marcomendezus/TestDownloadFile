using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestDownloadFile.Models;
using Attachment = TestDownloadFile.Models.Attachment;

#region MyRegion
string currentDirectory = Directory.GetCurrentDirectory();
string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
string jsonFilePath = Path.Combine(projectDirectory, "Json", "example.json");
string jsonContent = File.ReadAllText(jsonFilePath);

var options = new JsonSerializerOptions
{
    ReferenceHandler = ReferenceHandler.Preserve, // Manejar referencias circulares
    PropertyNameCaseInsensitive = true
};

var modelType = typeof(ModelV3);
dynamic modelDeserialized = null;

try
{
    modelDeserialized = JsonSerializer.Deserialize(jsonContent, modelType, options);
    Console.WriteLine("Successfully deserialized as the specified model.");
}
catch (JsonException ex)
{
    Console.WriteLine($"Failed to deserialize as a single model. Trying as a list... Error: {ex.Message}");

    try
    {
        var listType = typeof(List<>).MakeGenericType(modelType);
        modelDeserialized = JsonSerializer.Deserialize(jsonContent, listType, options);
        Console.WriteLine("Successfully deserialized as a list.");
    }
    catch (JsonException exList)
    {
        Console.WriteLine($"Failed to deserialize as a list. The JSON might contain an object property. Error: {exList.Message}");
        return;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    return;
}

string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string filePathSave = Path.Combine(myDocumentsPath, "Test Download PDF and files", "{name}");
string folderPath = Path.Combine(myDocumentsPath, "Test Download PDF and files");

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

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

static async Task DownloadFileAsyncWithModel(List<Attachmentv1> urls, string filePathSave)
{
    using (HttpClient client = new HttpClient())
    {
        foreach (var url in urls)
        {
            try
            {
                string pdfName = url.filename ?? url.name;
                string filePath = filePathSave.Replace("{name}", pdfName);
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

static async Task DownloadFileAsyncWithHttpClient(List<Attachmentv1> urls, string filePathSave)
{
    using (HttpClient client = new HttpClient())
    {
        foreach (var url in urls)
        {
            try
            {
                string pdfName = url.filename ?? url.name;
                string filePath = Path.Combine(filePathSave, pdfName);

                if (string.IsNullOrEmpty(url.url))
                {
                    continue;
                }

                byte[] fileBytes = await client.GetByteArrayAsync(url.url);

                await File.WriteAllBytesAsync(filePath, fileBytes);
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error HTTP al descargar el archivo desde {url}: {httpEx.Message}");
            }
        }
    }
}

#endregion
