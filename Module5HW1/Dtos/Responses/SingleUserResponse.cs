namespace Module5HW1.Dtos.Responses;

public class SingleUserResponse<T>
    where T : class
{
    public T Data { get; set; }
    public SupportDto Support { get; set; }
}