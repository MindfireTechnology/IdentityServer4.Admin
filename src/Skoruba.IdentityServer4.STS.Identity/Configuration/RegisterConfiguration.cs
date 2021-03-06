﻿namespace Skoruba.IdentityServer4.STS.Identity.Configuration
{
    public class RegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
        public string ApiConfirmationUrl { get; set; }

        public string NewUserDefaultRole { get; set; }

		public string EmailTemplatesBaseDirectory { get; set; }
	}
}
