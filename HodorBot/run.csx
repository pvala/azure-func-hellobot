﻿using System;
using System.Net;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string formDataStr = await req.Content.ReadAsStringAsync();
    string[] array = formDataStr.Split('&');

    if (formDataStr.ToLower().Contains("stark") || formDataStr.ToLower().Contains("hodor"))
    {
        return req.CreateResponse(HttpStatusCode.OK, new
        {
            text = $"Hodor hodor!"
        });
    }

    return req.CreateResponse(HttpStatusCode.OK, new
    {
        text = $""
    });
}
