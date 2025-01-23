namespace TestDownloadFile.Models
{
    public class AssignmentV2
    {
        public int id { get; set; }
        public bool approved { get; set; }
        public List<AttachmentV2> attachments { get; set; }
        public object comment { get; set; }
        public LoginInformationV2 login_information { get; set; }
        public object manager_accepted_at { get; set; }
        public object notified_at { get; set; }
        public DateTime? responded_at { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public VendorV2 vendor { get; set; }
    }

    public class AttachmentV2
    {
        public object id { get; set; }
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }

    public class ClosedByV2
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CreatedByV2
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CommentV2
    {
        public int id { get; set; }
        public string body { get; set; }
        public DateTime created_at { get; set; }
        public CreatorV2 creator { get; set; }
    }

    public class CreatorV2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CustomFieldsV2
    {
        // Mantener vacío
    }

    public class FinalApproverV2
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class LoginInformationV2
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class PunchItemManagerV2
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class VendorV2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class WebImageV2
    {
        public object id { get; set; }
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }

    public class ModelV2
    {
        public int id { get; set; }
        public List<AttachmentV2> attachments { get; set; }
        public List<object> ball_in_court { get; set; }
        public bool can_email { get; set; }
        public DateTime closed_at { get; set; }
        public List<CommentV2> comments { get; set; }
        public string cost_impact { get; set; }
        public object cost_impact_amount { get; set; }
        public DateTime created_at { get; set; }
        public List<object> current_drawing_revision_ids { get; set; }
        public CustomFieldsV2 custom_fields { get; set; }
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
        public List<WebImageV2> web_images { get; set; }
        public string workflow_status { get; set; }
        public ClosedByV2 closed_by { get; set; }
        public CreatedByV2 created_by { get; set; }
        public FinalApproverV2 final_approver { get; set; }
        public PunchItemManagerV2 punch_item_manager { get; set; }
        public object location { get; set; }
        public object trade { get; set; }
        public object punch_item_type { get; set; }
        public object cost_code { get; set; }
        public List<object> distribution_members { get; set; }
        public List<AssignmentV2> assignments { get; set; }
    }

}
