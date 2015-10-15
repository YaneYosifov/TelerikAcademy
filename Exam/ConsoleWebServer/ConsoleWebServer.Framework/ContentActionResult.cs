﻿namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;
    using System.Net;

    public class ContentActionResult : IActionResult
    {
        public readonly object Model;

        public ContentActionResult(HttpRq request, object model)
        {
            this.Model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRq Request { get; private set; }

        public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(
            this.Request.ProtocolVersion,
            HttpStatusCode.OK,
            this.Model.ToString(),
                "text/plain; charset=utf-8");
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}