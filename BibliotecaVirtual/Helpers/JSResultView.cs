using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Helpers
{
    public class JSResultView
    {
        public JSResultView(String messageResult, Object result)
        {
            this.MessageResult = messageResult;
            this.Result = result;
        }

        public JSResultView(String messageResult, Object result, Int32 status)
        {
            this.MessageResult = messageResult;
            this.Result = result;
            this.Status = status;
        }

        public JSResultView(String messageResult)
        {
            this.MessageResult = messageResult;
        }

        public String MessageResult { get; set; }
        public Object Result { get; set; }
        public Int32 Status { get; set; }
    }
}