namespace PhoneShop.Utilities.Models
{
    public class BaseResponseError
    {
        public string Code { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public BaseResponseError()
        {

        }

        public BaseResponseError(string code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
