namespace PhoneShop.Utilities.Models
{
    public class BaseResponse
    {
        public string Code { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string DataSource { get; set; } = string.Empty;

        public BaseResponseError? Error { get; set; } = new BaseResponseError();

        public BaseResponse()
        {

        }

        public BaseResponse(string code, string message, string dataSource, BaseResponseError? error = null)
        {
            this.Code = code;
            this.Message = message;
            this.DataSource = dataSource;
            this.Error = error;
        }

        public static BaseResponse Ok<T>(T data, string message = "", string dataSource = "")
           => new BaseResponse<T>(data, message, dataSource);

        public static BaseResponse Err(string code = "500", string message = "", string dataSource = "N/A", BaseResponseError? error = null)
            => new BaseResponse(code, message, dataSource, error);

    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        public BaseResponse(T data, string message = "", string dataSource = "")
            : base("200", message, dataSource)
        {
            this.Data = data;
        }
    }
}
