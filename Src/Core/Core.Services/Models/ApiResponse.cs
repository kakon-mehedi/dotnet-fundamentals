using System.Net;

namespace DotNetFundamentals.Core.Services.Shared.Models;

public class ApiResponse<TResponseData>
{
    public bool IsSuccess { get; set; } = true;
    
    public string Message { get; set; } = "Success";

    public int? StatusCode { get; set; } = 200;

    public int? TotalCount { get; set; } = 0;

    public TResponseData? Data { get; set; }
}