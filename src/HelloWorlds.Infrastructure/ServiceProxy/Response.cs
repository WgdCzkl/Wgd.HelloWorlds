using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorlds.Infrastructure.ServiceProxy
{
    public class Response
    {
        public Response()
        {
        }
        public Response(bool isSuccess)
        {
            IsSuccess = isSuccess;
            if (!isSuccess)
            {
                ResultMsg = "请求失败";
            }
        }

        public bool IsSuccess { get; set; }


        string _resultMsg = string.Empty;
        public string ResultMsg
        {
            get
            {
                if (string.IsNullOrEmpty(_resultMsg))
                {
                    return "请求失败";
                }
                return _resultMsg;
            }
            set
            {
                _resultMsg = value;
            }
        }
    }


    public class Response<T> : Response
    {
        public Response()
        {
        }
        public Response(bool isSuccess, T data)
        {
            IsSuccess = isSuccess;
            if (!isSuccess)
            {
                ResultMsg = "请求失败";
            }
            Data = data;

        }

        public T Data { get; set; }
    }
}
