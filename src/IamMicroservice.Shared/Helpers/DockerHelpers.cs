﻿using Microsoft.Extensions.Configuration;
using IamMicroservice.Shared.Configuration.Common;

namespace IamMicroservice.Shared.Helpers
{
    public class DockerHelpers
    {
        public static void UpdateCaCertificates()
        {
            "update-ca-certificates".Bash();
        }

        public static void ApplyDockerConfiguration(IConfiguration configuration)
        {
            var dockerConfiguration = configuration.GetSection(nameof(DockerConfiguration)).Get<DockerConfiguration>();

            if (dockerConfiguration != null && dockerConfiguration.UpdateCaCertificate)
            {
                UpdateCaCertificates();
            }
        }
    }
}





