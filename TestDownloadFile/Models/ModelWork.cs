namespace TestDownloadFile.Models
{
    public class RfiData
    {
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string PlainTextBody { get; set; }
        public DateTime QuestionDate { get; set; }
        public string RichTextBody { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    public class Answer
    {
        public int Id { get; set; }
        public string PlainTextBody { get; set; }
        public string RichTextBody { get; set; }
        public DateTime AnswerDate { get; set; }
        public List<Attachment> Attachments { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public bool Official { get; set; }
    }

    public class Attachment
    {
        public string Url { get; set; }
        public string Filename { get; set; }
        public string Name { get; set; }
        public bool CanBeViewed { get; set; }
        public bool Viewable { get; set; }
    }

    public class Assignee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public bool ResponseRequired { get; set; }
    }

    public class CreatedBy
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
    }

    public class CustomTextfield1
    {
        public object Label { get; set; }
        public string Value { get; set; }
    }

    public class CustomTextfield2
    {
        public object Label { get; set; }
        public string Value { get; set; }
    }

    public class CostImpact
    {
        public object Status { get; set; }
        public object Value { get; set; }
    }

    public class ScheduleImpact
    {
        public object Status { get; set; }
        public object Value { get; set; }
    }

    public class ResponsibleContractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DistributionList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
    }

    public class Priority
    {
        public bool Name { get; set; }
        public object Value { get; set; }
    }

    public class ModelWork
    {
        public int Id { get; set; }
        public DateTime InitiatedAt { get; set; }
        public string Link { get; set; }
        public List<Assignee> Assignees { get; set; }
        public CostImpact CostImpact { get; set; }
        public CustomFields CustomFields { get; set; }
        public string DueDate { get; set; }
        public string FullNumber { get; set; }
        public string Number { get; set; }
        public Priority Priority { get; set; }
        public bool IsPrivate { get; set; }
        public string Status { get; set; }
        public DateTime TimeResolved { get; set; }
        public string TranslatedStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Reference { get; set; }
        public List<Question> Questions { get; set; }
        public bool Accepted { get; set; }
        public ResponsibleContractor ResponsibleContractor { get; set; }
        public CreatedBy CreatedBy { get; set; }
    }

    // Custom class if needed (empty for now)
    public class CustomFields
    {
    }
}
