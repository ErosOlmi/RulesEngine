namespace RulesEngine
{
    public class DslCondition : AbstractCondition
    {
        public string DslStatement { get; set; }

        public override bool Evaluate(object context)
        {
            return EvaluatorAccessPoint.DslConditionEvaluator != null 
                && EvaluatorAccessPoint.DslConditionEvaluator.Evaluate(DslStatement, context);
        }
    }
}