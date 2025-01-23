namespace TestDownloadFile.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class RfiData01
    {
        public List<Question01> Questions { get; set; }
    }

    public class Question01
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string PlainTextBody { get; set; }
        public DateTime QuestionDate { get; set; }
        public string RichTextBody { get; set; }
        public List<Answer01> Answers { get; set; }
        public List<Attachment01> Attachments { get; set; }
    }

    public class Answer01
    {
        public int Id { get; set; }
        public string PlainTextBody { get; set; }
        public string RichTextBody { get; set; }
        public DateTime AnswerDate { get; set; }
        public List<Attachment01> Attachments { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public bool Official { get; set; }
    }

    public class Attachment01
    {
        public string Url { get; set; }
        public string Filename { get; set; }
        public string Name { get; set; }
        public bool CanBeViewed { get; set; }
        public bool Viewable { get; set; }
    }

    public class Assignee01
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public bool ResponseRequired { get; set; }
        public DateTime? ManagerAcceptedAt { get; set; }
    }

    public class CreatedBy01
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
    }

    public class CustomTextfield101
    {
        public object Label { get; set; }
        public string Value { get; set; }
    }

    public class CustomTextfield201
    {
        public object Label { get; set; }
        public string Value { get; set; }
    }

    public class CostImpact01
    {
        public object Status { get; set; }
        public object Value { get; set; }
    }

    public class ScheduleImpact01
    {
        public object Status { get; set; }
        public object Value { get; set; }
    }

    public class ResponsibleContractor01
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DistributionList01
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
    }

    public class Priority01
    {
        public bool Name { get; set; }
        public object Value { get; set; }
    }

    public class ModelWork01
    {
        public int Id { get; set; }
        public DateTime InitiatedAt { get; set; }
        public string Link { get; set; }
        public List<Assignee01> Assignees { get; set; }
        public CostImpact01 CostImpact { get; set; }
        public CustomFields01 CustomFields { get; set; }
        public string DueDate { get; set; }
        public string FullNumber { get; set; }
        public string Number { get; set; }
        public Priority01 Priority { get; set; }
        public bool IsPrivate { get; set; }
        public string Status { get; set; }
        public DateTime TimeResolved { get; set; }
        public string TranslatedStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Reference { get; set; }
        public List<Question01> Questions { get; set; }
        public bool Accepted { get; set; }
        public ResponsibleContractor01 ResponsibleContractor { get; set; }
        public CreatedBy01 CreatedBy { get; set; }
    }

    // Custom class if needed (empty for now)
    public class CustomFields01
    {
    }
}
