﻿using System.Collections.Generic;
using System.Net;

namespace Lob
{
    public interface IResponse
    {
        object Body { get; }

        IReadOnlyDictionary<string, string> Headers { get; }

        HttpStatusCode StatusCode { get; }

        string ContentType { get; }
    }
}