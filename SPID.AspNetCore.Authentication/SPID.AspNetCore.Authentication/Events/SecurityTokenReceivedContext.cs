﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using SPID.AspNetCore.Authentication.Models;
using SPID.AspNetCore.Authentication.Saml;

namespace SPID.AspNetCore.Authentication.Events
{
    public class SecurityTokenReceivedContext : RemoteAuthenticationContext<SpidOptions>
    {
        /// <summary>
        /// Creates a <see cref="SecurityTokenReceivedContext"/>
        /// </summary>
        public SecurityTokenReceivedContext(HttpContext context, AuthenticationScheme scheme, SpidOptions options, AuthenticationProperties properties)
            : base(context, scheme, options, properties)
        {
        }

        /// <summary>
        /// The <see cref="Response"/> received on this request.
        /// </summary>
        public ResponseType ProtocolMessage { get; set; }
    }
}
