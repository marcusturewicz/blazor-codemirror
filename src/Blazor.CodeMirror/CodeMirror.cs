using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.CodeMirror
{
    public class CodeMirror
    {
        private IJSRuntime _jsRuntime;

        public CodeMirror(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public Task<object> CreateAsync(object textArea, string initialCode)
        {
            // Implemented in cliboard.js
            return _jsRuntime.InvokeAsync<object>(
                "codemirror.create",
                textArea,
                initialCode);
        } 

    }
}
