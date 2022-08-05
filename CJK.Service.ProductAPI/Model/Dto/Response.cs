using System.Collections.Generic;

namespace CJK.Service.ProductAPI.Model.Dto
{
    public class Response
    {
        public bool IsSuccess { get; set; } = true;
        public  object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}
