using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public abstract class Expression
    {
        public abstract int Interpret();
    }

    public abstract class TerminalExpression : Expression
    {

    }

    public class Number : TerminalExpression
    {
        public int value;
        public Number(int value)
        {
            this.value = value;
        }

        public override int Interpret()
        {
            return value;
        }
    }

    public abstract class NonTerminalExpression : Expression
    {
        protected List<Expression> expressions;
        public NonTerminalExpression(List<Expression> expressions)
        {
            this.expressions = new List<Expression>(expressions);
        }
    }

    public class AdditionExpression : NonTerminalExpression
    {
        public AdditionExpression(List<Expression> expressions) : base(expressions)
        {
        }

        public override int Interpret()
        {
            int answer = 0;
            foreach (Expression e in expressions)
            {
                answer += e.Interpret();
            }
            return answer;
        }
    }

    public class SubtractExpression : NonTerminalExpression
    {
        public SubtractExpression(List<Expression> expressions) : base(expressions)
        {
        }

        public override int Interpret()
        {
            int answer = expressions[0].Interpret();

            for (int i = 1; i < expressions.Count; i++)
            {
                answer -= expressions[i].Interpret();
            }

            return answer;
        }
    }
}
