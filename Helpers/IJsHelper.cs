using Microsoft.JSInterop;

namespace FrontendApp.Helpers
{
    public static class IJsHelper
    {
        public static async ValueTask ToastSucces(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("FonctionShowToastr", "success", message);
        }
        public static async ValueTask ToastError(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("FonctionShowToastr", "error", message);
        }
    }
}
