using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Simple.AuthServer.ViewModels.Authorization;

public class LogoutViewModel
{
    [BindNever]
    public string RequestId { get; set; }
}
