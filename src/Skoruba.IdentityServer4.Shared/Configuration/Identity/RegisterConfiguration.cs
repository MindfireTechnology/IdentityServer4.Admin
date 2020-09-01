namespace Skoruba.IdentityServer4.Shared.Configuration.Identity
{
    public class RegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
        public string ApiConfirmationUrl { get; set; }

        public string NewUserDefaultRole { get; set; }
    }
}
