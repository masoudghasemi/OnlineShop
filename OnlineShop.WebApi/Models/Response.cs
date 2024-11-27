namespace OnlineShop.WebApi.Models;

public class Response<TData>
{
    
    public TData Data { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public override string ToString()
    {
        return Message + Code + IsSuccess;
    }
}