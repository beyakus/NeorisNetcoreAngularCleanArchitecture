namespace NeorisNetcoreAngularCleanArchitecture.Core.CustomEntities
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public string Message {get; set;}
        public int Status {get; set; }
        public ApiResponse(T data)
        {
            this.Data = data;
            this.Status = 200;
            this.Message = "OK";
        }

        public Metadata metadata {get; set;}
    }
}