namespace Odws.Api.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public T Value { get; set; }
        public ServiceResponse(T value)
        {
            this.Value = value;
        }
        public ServiceResponse()
        {
            
        }
    }
}
