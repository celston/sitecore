using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using Sitecore.Diagnostics;

namespace Sitecore.GnosisToolkit.Library.Rules.Conditions
{
    public class QueryStringCondition<T> : StringOperatorCondition<T>
        where T : RuleContext
    {
        public string Key { get; set; }
        public string TargetValue { get; set; }

        protected string ActualValue
        {
            get
            {
                return HttpContext.Current.Request.QueryString[Key];
            }
        }

        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");

            if (String.IsNullOrWhiteSpace(Key) || String.IsNullOrWhiteSpace(TargetValue))
            {
                return false;
            }

            return TargetValue == ActualValue;
        }
    }
}
