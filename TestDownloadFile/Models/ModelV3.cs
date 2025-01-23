namespace TestDownloadFile.Models
{

    public class AssignmentV3
    {
        public int id { get; set; }
        public bool approved { get; set; }
        public List<AttachmentV3> attachments { get; set; } // Combina lo mejor de ambas versiones
        public object comment { get; set; }
        public LoginInformationV3 login_information { get; set; }
        public DateTime? manager_accepted_at { get; set; } // Usamos nullable DateTime en lugar de object para posibles fechas
        public DateTime? notified_at { get; set; } // Más específico que object
        public DateTime? responded_at { get; set; } // Usamos nullable para más flexibilidad
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public VendorV3 vendor { get; set; }
    }

    public class AttachmentV3
    {
        public long? id { get; set; } // Combina lo mejor de ambas versiones (nullable por flexibilidad)
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }

    public class BallInCourtV3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string locale { get; set; } // Mejor que usar object
        public string login { get; set; }
    }

    public class ClosedByV3
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CommentV3
    {
        public int id { get; set; }
        public string body { get; set; }
        public DateTime created_at { get; set; }
        public CreatorV3 creator { get; set; }
    }

    public class CreatorV3
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CreatedByV3
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class CustomFieldsV3
    {
        // Mantener vacío para futuras personalizaciones
    }

    public class FinalApproverV3
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class LoginInformationV3
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class PunchItemManagerV3
    {
        public int id { get; set; }
        public string login { get; set; }
        public string name { get; set; }
    }

    public class VendorV3
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class WebImageV3
    {
        public long? id { get; set; } // Nullable para reflejar flexibilidad
        public string content_type { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
    }

    public class ModelV3
    {
        public int id { get; set; }
        public List<AttachmentV3> attachments { get; set; }
        public List<BallInCourtV3> ball_in_court { get; set; } // Usar lista específica
        public bool can_email { get; set; }
        public DateTime? closed_at { get; set; } // Nullable DateTime
        public List<CommentV3> comments { get; set; } // Combina lo mejor con detalles específicos
        public string cost_impact { get; set; }
        public decimal? cost_impact_amount { get; set; } // Cambiado de object a nullable decimal
        public DateTime created_at { get; set; }
        public List<int> current_drawing_revision_ids { get; set; } // Lista de enteros
        public CustomFieldsV3 custom_fields { get; set; }
        public DateTime date_initiated { get; set; }
        public DateTime? deleted_at { get; set; } // Nullable para mayor precisión
        public string description { get; set; }
        public List<int> drawing_ids { get; set; } // Cambiado de List<object> a List<int>
        public string due_date { get; set; }
        public bool due_tomorrow { get; set; }
        public bool has_attachments { get; set; }
        public List<WebImageV3> images { get; set; }
        public DateTime? manager_notified_at { get; set; } // Nullable
        public string name { get; set; }
        public bool overdue { get; set; }
        public int position { get; set; }
        public object priority { get; set; } // Se mantiene como object para flexibilidad
        public bool @private { get; set; }
        public string reference { get; set; }
        public string schedule_impact { get; set; }
        public int? schedule_impact_days { get; set; } // Nullable int
        public object schedule_risk { get; set; }
        public object schedule_risk_confidence { get; set; }
        public object schedule_risk_probability { get; set; }
        public object schedule_risk_reason { get; set; }
        public bool should_display_risk_flag { get; set; }
        public string status { get; set; }
        public DateTime updated_at { get; set; }
        public Guid? uuid { get; set; } // Cambiado de object a Guid nullable
        public List<WebImageV3> web_images { get; set; }
        public string workflow_status { get; set; }
        public ClosedByV3 closed_by { get; set; }
        public CreatedByV3 created_by { get; set; }
        public FinalApproverV3 final_approver { get; set; }
        public PunchItemManagerV3 punch_item_manager { get; set; }
        public string location { get; set; } // Cambiado de object a string
        public string trade { get; set; } // Cambiado de object a string
        public string punch_item_type { get; set; } // Cambiado de object a string
        public string cost_code { get; set; } // Cambiado de object a string
        public List<object> distribution_members { get; set; } // Mantiene lista genérica
        public List<AssignmentV3> assignments { get; set; }
    }

}
