using System;
using System.Collections.Generic;
using System.Web;
using Mtime.Web;
using System.Xml;

namespace JD.MovieAPI
{
    public class XmlResult : ActionResult
    {
        private string _Xml;

        public XmlResult(string xml)
        {
            _Xml = xml;
        }

        public override void Execute(RequestContext rc)
        {
            XmlDocument dom = new XmlDocument();
            dom.LoadXml(_Xml);
            rc.Context.Response.Write(dom.OuterXml);
        }
    }
}