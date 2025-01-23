namespace TestDownloadFile.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Rootv1>(myJsonResponse);
    public class Assignmentv1
    {
        public int id { get; set; }
        public bool approved { get; set; }
        public List<Attachmentv1> attachments { get; set; }
        public string comment { get; set; }
        public LoginInformationv1 login_information { get; set; }
        public object manager_accepted_at { get; set; }
        public DateTime notified_at { get; set; }
        public DateTime? responded_at { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public Vendorv1 vendor { get; set; }
    }

    public class Attachmentv1
    {
        public object id { get; set; }
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }

    public class ClosedByv1
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CreatedByv1
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CustomFieldsv1
    {
    }

    public class FinalApproverv1
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class LoginInformationv1
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class PunchItemManagerv1
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class Rootv1
    {
        public int id { get; set; }
        public List<Attachmentv1> attachments { get; set; }
        public List<object> ball_in_court { get; set; }
        public bool can_email { get; set; }
        public DateTime closed_at { get; set; }
        public List<object> comments { get; set; }
        public string cost_impact { get; set; }
        public object cost_impact_amount { get; set; }
        public DateTime created_at { get; set; }
        public List<object> current_drawing_revision_ids { get; set; }
        public CustomFieldsv1 custom_fields { get; set; }
        public DateTime date_initiated { get; set; }
        public object deleted_at { get; set; }
        public string description { get; set; }
        public List<object> drawing_ids { get; set; }
        public string due_date { get; set; }
        public bool due_tomorrow { get; set; }
        public bool has_attachments { get; set; }
        public List<object> images { get; set; }
        public DateTime manager_notified_at { get; set; }
        public string name { get; set; }
        public bool overdue { get; set; }
        public int position { get; set; }
        public object priority { get; set; }
        public bool @private { get; set; }
        public string reference { get; set; }
        public string schedule_impact { get; set; }
        public object schedule_impact_days { get; set; }
        public object schedule_risk { get; set; }
        public object schedule_risk_confidence { get; set; }
        public object schedule_risk_probability { get; set; }
        public object schedule_risk_reason { get; set; }
        public bool should_display_risk_flag { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public object uuid { get; set; }
        public List<WebImagev1> web_images { get; set; }
        public string workflow_status { get; set; }
        public ClosedByv1 closed_by { get; set; }
        public CreatedByv1 created_by { get; set; }
        public FinalApproverv1 final_approver { get; set; }
        public PunchItemManagerv1 punch_item_manager { get; set; }
        public object location { get; set; }
        public object trade { get; set; }
        public object punch_item_type { get; set; }
        public object cost_code { get; set; }
        public List<object> distribution_members { get; set; }
        public List<Assignmentv1> assignments { get; set; }
    }

    public class Vendorv1
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class WebImagev1
    {
        public object id { get; set; }
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }


}
