using CefNet;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGTkDemo
{
    public class SourceVisitor : CefStringVisitor
    {
        public Action<string> GetHtmlAction;

        public SourceVisitor(Action<string> getHtmlAction)
        {
            this.GetHtmlAction = getHtmlAction;
        }

        protected override void Visit(string html)
        {
            GetHtmlAction?.Invoke(html);
        }
    }
}
