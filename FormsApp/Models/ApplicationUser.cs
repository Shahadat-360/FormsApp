using Microsoft.AspNetCore.Identity;

namespace FormsApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsBlocked { get; set; } = false;
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual ICollection<FormTemplate> CreatedTemplates { get; set; } = new List<FormTemplate>();
        public virtual ICollection<FormResponse> FilledForms { get; set; } = new List<FormResponse>();
        public virtual ICollection<ApiToken> ApiTokens { get; set; } = new List<ApiToken>();

        // Salesforce integration properties
        public virtual SalesforceUserProfile? SalesforceProfile { get; set; }
    }
} 
