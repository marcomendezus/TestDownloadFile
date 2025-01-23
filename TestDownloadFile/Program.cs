
using System;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestDownloadFile.Models;
using Attachment = TestDownloadFile.Models.Attachment;

string json = @"{
	""id"": 1,
	""name"": ""PDF Download Practice"",
	""description"": ""List of URLs to download PDF files"",
	""answer"": [
		{
			""name"": ""W3C"",
			""url"": ""https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf""
		},
		{
			""name"": ""File Examples"",
			""url"": ""https://file-examples.com/wp-content/uploads/2017/10/file-sample_150kB.pdf""
		},
		{
			""name"": ""Adobe Sample"",
			""url"": ""https://www.adobe.com/support/products/enterprise/knowledgecenter/media/c4611_sample_explain.pdf""
		}
	]
}";

#region Test
//Root root = JsonSerializer.Deserialize<Root>(json);

//foreach (Answers answer in root.answer)
//{
//    Console.WriteLine($"Downloading {answer.name} from {answer.url}");
//    // Download the file
//}
#endregion


#region MyRegion
//string jsonReal = @"{""id"":28385565,""attachments"":[{""id"":3061602291,""content_type"":""image/jpeg"",""filename"":""4B38EF5C-B4D0-4523-B0BF-040BA7A3AF96.jpeg"",""name"":""4B38EF5C-B4D0-4523-B0BF-040BA7A3AF96.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/80537ea743f68c76a58cda5eff87d26f7881_3061602291_thumbnail_large_production.PNG?sig=49c38a2b6e714b5426c35b005fc7fefc60e8d6e847949b28bd49ba594256d580"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021164232_production_3061602291.jpeg?sig=a1427b832372955a1df2ae5bf1e4ff8ac02df03e89f0526c2fcb1fc70e8a080c""}],""ball_in_court"":[],""can_email"":true,""closed_at"":""2021-11-29T20:54:49Z"",""comments"":[],""cost_impact"":"""",""cost_impact_amount"":null,""created_at"":""2021-10-19T20:18:05Z"",""current_drawing_revision_ids"":[],""custom_fields"":{},""date_initiated"":""2021-10-19T20:18:05Z"",""deleted_at"":null,""description"":""Finish trim at top of linear panel (blue tape still in place)"",""drawing_ids"":[],""due_date"":""2021-11-24"",""due_tomorrow"":false,""has_attachments"":true,""images"":[],""manager_notified_at"":""2021-10-19T20:18:05Z"",""name"":""Procedure Room 177"",""overdue"":false,""position"":16,""priority"":null,""private"":false,""reference"":"""",""schedule_impact"":"""",""schedule_impact_days"":null,""schedule_risk"":null,""schedule_risk_confidence"":null,""schedule_risk_probability"":null,""schedule_risk_reason"":null,""should_display_risk_flag"":false,""status"":""Closed"",""updated_at"":""2021-11-29T20:54:49Z"",""uuid"":null,""web_images"":[{""id"":3061602291,""content_type"":""image/jpeg"",""filename"":""4B38EF5C-B4D0-4523-B0BF-040BA7A3AF96.jpeg"",""name"":""4B38EF5C-B4D0-4523-B0BF-040BA7A3AF96.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/80537ea743f68c76a58cda5eff87d26f7881_3061602291_thumbnail_large_production.PNG?sig=49c38a2b6e714b5426c35b005fc7fefc60e8d6e847949b28bd49ba594256d580"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021164232_production_3061602291.jpeg?sig=a1427b832372955a1df2ae5bf1e4ff8ac02df03e89f0526c2fcb1fc70e8a080c""}],""workflow_status"":""closed"",""closed_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""created_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""final_approver"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""punch_item_manager"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""location"":null,""trade"":null,""punch_item_type"":null,""cost_code"":null,""distribution_members"":[],""assignments"":[{""id"":38166139,""approved"":false,""attachments"":[],""comment"":null,""login_information"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""manager_accepted_at"":null,""notified_at"":""2021-10-21T20:07:22Z"",""responded_at"":null,""status"":""unresolved"",""updated_at"":""2021-10-21T20:07:22Z"",""vendor"":{""id"":250318,""name"":""Nor-Son Construction, LLC. (Baxter, MN)""}}]}";


//Completo
string jsonReal = @"{""id"":28384116,""attachments"":[{""id"":3061518246,""content_type"":""image/jpeg"",""filename"":""9CF3A5C3-54C3-458B-9D9D-E0B5DE2C1769.jpeg"",""name"":""9CF3A5C3-54C3-458B-9D9D-E0B5DE2C1769.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/a9d25107f2aa0b677cb61fe01c1a407d24ec_3061518246_thumbnail_large_production.PNG?sig=7d2f355e898b4e9c4d55ef80552bc7a368cd3a5d801c865ea97fc96f97f036a3"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021160936_production_3061518246.jpeg?sig=9abc694e826c9dcdc90fbb787d1a55cf9d0aa733c29c048321d76e26c842f0ed""},{""id"":3061518241,""content_type"":""image/jpeg"",""filename"":""216E0102-75C1-42DD-903F-DF910CFE13D9.jpeg"",""name"":""216E0102-75C1-42DD-903F-DF910CFE13D9.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/ce98d775411d86daedeeb10a441d15786fda_3061518241_thumbnail_large_production.PNG?sig=bbed66c9110e754249c4a0988c3f53f0617c565a5fb395fc9b6d017e5dd1d5cf"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021160936_production_3061518241.jpeg?sig=a113718253f991d6b78e8808eb2dcdfe13004f3663baf23d846d4d42164e20b2""}],""ball_in_court"":[],""can_email"":true,""closed_at"":""2021-11-29T20:54:49Z"",""comments"":[],""cost_impact"":"""",""cost_impact_amount"":null,""created_at"":""2021-10-19T19:51:35Z"",""current_drawing_revision_ids"":[],""custom_fields"":{},""date_initiated"":""2021-10-19T19:51:35Z"",""deleted_at"":null,""description"":""Door 121 – Delayed egress panic device is problematic with accidental triggering of alarm when device is bumped while assisting patients."",""drawing_ids"":[],""due_date"":""2021-11-24"",""due_tomorrow"":false,""has_attachments"":true,""images"":[],""manager_notified_at"":""2021-10-19T19:51:35Z"",""name"":""Problem Panic Device"",""overdue"":false,""position"":9,""priority"":null,""private"":false,""reference"":"""",""schedule_impact"":"""",""schedule_impact_days"":null,""schedule_risk"":null,""schedule_risk_confidence"":null,""schedule_risk_probability"":null,""schedule_risk_reason"":null,""should_display_risk_flag"":false,""status"":""Closed"",""updated_at"":""2021-11-29T20:54:49Z"",""uuid"":null,""web_images"":[{""id"":3061518246,""content_type"":""image/jpeg"",""filename"":""9CF3A5C3-54C3-458B-9D9D-E0B5DE2C1769.jpeg"",""name"":""9CF3A5C3-54C3-458B-9D9D-E0B5DE2C1769.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/a9d25107f2aa0b677cb61fe01c1a407d24ec_3061518246_thumbnail_large_production.PNG?sig=7d2f355e898b4e9c4d55ef80552bc7a368cd3a5d801c865ea97fc96f97f036a3"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021160936_production_3061518246.jpeg?sig=9abc694e826c9dcdc90fbb787d1a55cf9d0aa733c29c048321d76e26c842f0ed""},{""id"":3061518241,""content_type"":""image/jpeg"",""filename"":""216E0102-75C1-42DD-903F-DF910CFE13D9.jpeg"",""name"":""216E0102-75C1-42DD-903F-DF910CFE13D9.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/ce98d775411d86daedeeb10a441d15786fda_3061518241_thumbnail_large_production.PNG?sig=bbed66c9110e754249c4a0988c3f53f0617c565a5fb395fc9b6d017e5dd1d5cf"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021160936_production_3061518241.jpeg?sig=a113718253f991d6b78e8808eb2dcdfe13004f3663baf23d846d4d42164e20b2""}],""workflow_status"":""closed"",""closed_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""created_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""final_approver"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""punch_item_manager"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""location"":null,""trade"":null,""punch_item_type"":null,""cost_code"":null,""distribution_members"":[],""assignments"":[{""id"":38552900,""approved"":false,""attachments"":[],""comment"":null,""login_information"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""manager_accepted_at"":null,""notified_at"":""2021-11-02T20:54:09Z"",""responded_at"":null,""status"":""unresolved"",""updated_at"":""2021-11-02T20:54:09Z"",""vendor"":{""id"":250318,""name"":""Nor-Son Construction, LLC. (Baxter, MN)""}},{""id"":38167301,""approved"":false,""attachments"":[{""id"":3064212058,""content_type"":""application/pdf"",""filename"":""E211022 Pine River Delayed Egress.pdf"",""name"":""E211022 Pine River Delayed Egress.pdf"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/cec82c8d8f701a0b8dc42c87f622cc2f93b3_3064212058_thumbnail_large_production.PNG?sig=25745be7c158fc3eefcdc4c1f3281d93fcecaee57b2501f84be6ac97dc8e2d0f"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211022195516_production_3064212058.pdf?sig=9dc8b9d832699f451760374b9ab18645985663bff3321137cb17cc69861228ee""}],""comment"":""Here is a place to start with the existing door hardware.  See the attached file information we received from Allegion.  They are recommending adjusting the \""nuisance delay\"" setting to the maximum of  3 seconds to avoid setting off the alarm whenever anyone bumps the panic device.  This is still the most code compliant solution for this door, and our door hardware consultant advises making this adjustment before researching other options."",""login_information"":{""id"":1589532,""login"":""deb.parrott@widseth.com"",""name"":""Deb Parrott""},""manager_accepted_at"":null,""notified_at"":""2021-10-21T20:07:22Z"",""responded_at"":""2021-10-22T20:03:58Z"",""status"":""ready_for_review"",""updated_at"":""2021-10-22T20:03:58Z"",""vendor"":{""id"":25375864,""name"":""Widseth Smith Nolting, Inc""}}]}";

//Nuevo error
//string jsonReal = @"{""id"":28383508,""attachments"":[{""id"":3061474900,""content_type"":""image/jpeg"",""filename"":""1BB10D7A-8D18-4101-AD2B-F806C6089157.jpeg"",""name"":""1BB10D7A-8D18-4101-AD2B-F806C6089157.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/efacc471836e74009b0de2bedf1ce0c57e6d_3061474900_thumbnail_large_production.PNG?sig=a825a738e4193cdb23081847a4bd9c4052ad31782f3e7642275ad109cdb5335e"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021155250_production_3061474900.jpeg?sig=c556b2aca5a02ef739f594685005a272e7b6557bb472e25300e6589f3433f5cd""}],""ball_in_court"":[{""id"":426438,""name"":""Stacy Hill"",""locale"":null,""login"":""stacy@signspotmn.com""}],""can_email"":true,""closed_at"":null,""comments"":[],""cost_impact"":"""",""cost_impact_amount"":null,""created_at"":""2021-10-19T19:37:52Z"",""current_drawing_revision_ids"":[],""custom_fields"":{},""date_initiated"":""2021-10-19T19:37:52Z"",""deleted_at"":null,""description"":""Essentia signage at front door is blocked by column. Signage is provided by Essentia marketing and so the design team was not involved. Eric will check with Sign Spot to determine the difficulty in relocating/reconfiguring the sign layout. Final layout will need to be coordinated with Essentia marketing."",""drawing_ids"":[],""due_date"":""2021-12-31"",""due_tomorrow"":false,""has_attachments"":true,""images"":[],""manager_notified_at"":""2021-10-19T19:37:52Z"",""name"":""EXTERIOR: Signage blocked by column"",""overdue"":true,""position"":6,""priority"":null,""private"":false,""reference"":"""",""schedule_impact"":"""",""schedule_impact_days"":null,""schedule_risk"":null,""schedule_risk_confidence"":null,""schedule_risk_probability"":null,""schedule_risk_reason"":null,""should_display_risk_flag"":false,""status"":""Overdue"",""updated_at"":""2021-12-14T14:00:45Z"",""uuid"":null,""web_images"":[{""id"":3061474900,""content_type"":""image/jpeg"",""filename"":""1BB10D7A-8D18-4101-AD2B-F806C6089157.jpeg"",""name"":""1BB10D7A-8D18-4101-AD2B-F806C6089157.jpeg"",""thumbnail_url"":""https://storage.procore.com/v4/d/us-east-1/prostore-thumbnail-bucket-production/efacc471836e74009b0de2bedf1ce0c57e6d_3061474900_thumbnail_large_production.PNG?sig=a825a738e4193cdb23081847a4bd9c4052ad31782f3e7642275ad109cdb5335e"",""url"":""https://storage.procore.com/v4/d/us-east-1/pro-core.com/prostore/20211021155250_production_3061474900.jpeg?sig=c556b2aca5a02ef739f594685005a272e7b6557bb472e25300e6589f3433f5cd""}],""workflow_status"":""work_required"",""closed_by"":null,""created_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""final_approver"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""punch_item_manager"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""location"":null,""trade"":null,""punch_item_type"":null,""cost_code"":null,""distribution_members"":[],""assignments"":[{""id"":38167105,""approved"":false,""attachments"":[],""comment"":null,""login_information"":{""id"":426438,""login"":""stacy@signspotmn.com"",""name"":""Stacy Hill""},""manager_accepted_at"":null,""notified_at"":""2021-10-21T20:07:22Z"",""responded_at"":null,""status"":""unresolved"",""updated_at"":""2021-10-21T20:07:22Z"",""vendor"":{""id"":906186,""name"":""SignSpot, Inc""}}]}";

//parcialmente vacio
//string jsonReal = @"{""id"":28383019,""attachments"":[],""ball_in_court"":[],""can_email"":true,""closed_at"":""2021-10-21T20:07:12Z"",""comments"":[{""id"":2677057,""body"":""Monitor snow melt system"",""created_at"":""2021-10-21T19:14:52Z"",""creator"":{""id"":6313577,""name"":""Ryan Schwieters""}}],""cost_impact"":"""",""cost_impact_amount"":null,""created_at"":""2021-10-19T19:31:04Z"",""current_drawing_revision_ids"":[],""custom_fields"":{},""date_initiated"":""2021-10-19T19:31:04Z"",""deleted_at"":null,""description"":""Concrete slabs at entries look good. Anxious to see them after snow-melt system has been in operation."",""drawing_ids"":[],""due_date"":""2021-11-24"",""due_tomorrow"":false,""has_attachments"":false,""images"":[],""manager_notified_at"":""2021-10-19T19:31:04Z"",""name"":""Concrete Slabs"",""overdue"":false,""position"":1,""priority"":null,""private"":false,""reference"":"""",""schedule_impact"":"""",""schedule_impact_days"":null,""schedule_risk"":null,""schedule_risk_confidence"":null,""schedule_risk_probability"":null,""schedule_risk_reason"":null,""should_display_risk_flag"":false,""status"":""Closed"",""updated_at"":""2021-10-21T20:07:12Z"",""uuid"":null,""web_images"":[],""workflow_status"":""closed"",""closed_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""created_by"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""final_approver"":{""id"":200724,""login"":""dennis.korte@nor-son.com"",""name"":""Dennis Korte""},""punch_item_manager"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""location"":null,""trade"":null,""punch_item_type"":null,""cost_code"":null,""distribution_members"":[],""assignments"":[{""id"":38166383,""approved"":true,""attachments"":[],""comment"":null,""login_information"":{""id"":6313577,""login"":""ryan.schwieters@nor-son.com"",""name"":""Ryan Schwieters""},""manager_accepted_at"":""2021-10-21T20:07:08Z"",""notified_at"":null,""responded_at"":null,""status"":""resolved"",""updated_at"":""2021-10-21T20:07:08Z"",""vendor"":{""id"":250318,""name"":""Nor-Son Construction, LLC. (Baxter, MN)""}}]}";

var options = new JsonSerializerOptions
{
    ReferenceHandler = ReferenceHandler.Preserve, // Manejar referencias circulares
    PropertyNameCaseInsensitive = true
};

//var showRfis = JsonSerializer.Deserialize<Rootv1>(jsonReal, options);
var showRfis = JsonSerializer.Deserialize<ModelV3>(jsonReal, options);


var all = showRfis.attachments.Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name }).ToList();

var allwebImage = showRfis.web_images.Select(x => new WebImagev1 { url = x.url, filename = x.filename, name = x.name }).ToList();

var allAssigments= showRfis.assignments.SelectMany(b => b.attachments.Select(c => new Attachmentv1 { url = c.url, filename = c.filename, name = c.name })).ToList();

var allAttachments = showRfis.attachments
    .Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name })
    .Concat(showRfis.web_images.Select(x => new Attachmentv1 { url = x.url, filename = x.filename, name = x.name }))
    .Concat(showRfis.assignments.SelectMany(b => b.attachments.Select(c => new Attachmentv1 { url = c.url, filename = c.filename, name = c.name })))
    .ToList();


string filePath = @"C:\Client\Test Download PDF\{name}";
//await DownloadFileAsyncWithModel(url, filePath);

#region segunda opcion
//var aadsfasdfas = JsonSerializer.Deserialize<RfiData>(jsonReal, options);

JsonDocument doc = JsonDocument.Parse(jsonReal);

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

#endregion

var test = string.Empty;

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
DownloadFileAsyncWithModel(allAttachments, filePath);



#endregion

#region Metodos
static async Task DownloadFileAsyncWithModel2(List<Attachment> attachments, string folderPath)
{
    using (HttpClient client = new HttpClient())
    {
        foreach (var attachment in attachments)
        {
            try
            {
                string pdfName = attachment.Filename ?? attachment.Name;
                string filePath = folderPath.Replace("{name}", pdfName);

                using (WebClient webClient = new WebClient())
                {
                    await webClient.DownloadFileTaskAsync(new Uri(attachment.Url), filePath);
                }

                Console.WriteLine($"Archivo descargado y guardado en: {filePath}");
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error HTTP al descargar el archivo desde {attachment.Url}: {httpEx.Message}");
            }
            catch (TaskCanceledException timeoutEx)
            {
                Console.WriteLine($"Timeout al descargar el archivo desde {attachment.Url}: {timeoutEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error desconocido al descargar el archivo desde {attachment.Url}: {ex.Message}");
            }
        }
    }
}

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
