namespace Module5HW1.Dtos.Responses;

public class SingleResponse<T>
    where T : class
{
    public T Data { get; set; }

    public SupportDto Support { get; set; }
}