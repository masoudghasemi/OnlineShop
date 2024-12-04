namespace ConsoleAppTest.CustomExceptions;

public class AppException:Exception
{

    public int _ErrorCode;
    public AppException(int ErrorCode)
    {
        _ErrorCode = ErrorCode;

    }
    
}