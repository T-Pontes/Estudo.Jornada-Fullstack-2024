using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        [JsonConstructor] //Para tornar este construtor como padrão para serialização Json no .NET
        public Response() => _code = Configuration.DefaultStatusCode;

        public Response(
            TData? data, 
            int code = Configuration.DefaultStatusCode, 
            string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }
        
        private int _code = Configuration.DefaultStatusCode;

        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore] //Para receber a informação sem exibir na tela 
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}
