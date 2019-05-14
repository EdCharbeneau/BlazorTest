using Microsoft.JSInterop;

namespace BlazorTest
{
    public class JSInterop
    {
        public static void ShowModalDialog(IJSRuntime jsRuntime, string dialogId)
        {
            jsRuntime.InvokeAsync<object>("jsFunctions.showModalDialog", dialogId);
        }
    }
}
