namespace AzureDataLake.ODataQuery
{
    public class ExprSubstring : Expr
    {
        public Expr Expression1;
        public Expr Expression2;

        public ExprSubstring(Expr expr1, Expr expr2)
        {
            this.Expression1 = expr1;
            this.Expression2 = expr2;
        }

        public override void ToExprString(ExpressionWriter writer)
        {
            this.WriteFunction2(writer, "substring", this.Expression1, this.Expression2);
        }
    }
}