using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Umbraco.Core.Configuration.Grid
{
    public interface IGridEditorConfig
    {
        string Name { get; }
        string Alias { get; }
        string View { get; }
        string Render { get; }
        string Icon { get; }
        bool Deprecated { get; }
        IDictionary<string, object> Config { get; }
    }
}
