﻿using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blazor.TypeScriptProxy.Contract
{
    [JsonConverter(typeof(ISyntaxTokenConverter))]
    public interface ISyntaxToken
    {
        SyntaxKind Kind { get; }
    }
}
