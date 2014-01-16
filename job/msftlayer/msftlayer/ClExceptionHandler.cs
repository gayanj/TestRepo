using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Msftlayer
{
    public class ClExceptionHandler
    {
        public void AddError(Exception exc, string _Url)
        {
            // Get URL
            string excUrl = "";
            string PageName = _Url;
            string _stack = "";
            string _inner = "";
            string _data = "";
            string _type = "";
            string _messege = "";
            string _source = "";

            if (HttpContext.Current.Request.Url != null)
            {
                excUrl = HttpContext.Current.Request.Url.ToString();
            }

            if (exc.StackTrace != null)
            {
                _stack = exc.StackTrace.ToString();
            }

            if (exc.InnerException != null)
            {
                _inner = exc.InnerException.ToString();
            }

            if (exc.Data != null)
            {
                _data = exc.Data.ToString();
            }

            if (exc.GetType() != null)
            {
                _type = exc.GetType().ToString();
            }

            if (exc.Message != null)
            {
                _messege = exc.Message.ToString();
            }

            if (exc.Source != null)
            {
                _source = exc.Source.ToString();
            }

            //save to db
            ClDebug _Cld = new ClDebug();
            _Cld.Insertdebuggcode("", PageName, _data, _type, _inner, _messege, _source, _stack, "", excUrl);

        }
    }
}
