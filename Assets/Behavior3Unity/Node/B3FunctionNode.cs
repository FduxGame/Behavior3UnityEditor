using System.Collections.Generic;
using GraphProcessor;

namespace B3Unity
{
    public enum FunctionNodeType
    {
        None,
        Sequence,
        Priority
    }

    [NodeMenuItem("FunctionNode")]
    public class B3FunctionNode : BaseNode
    {
        private FunctionNodeType functionNodeType;

        [Input(name = "Link")]
        public B3Link		InLink;

        [Output(name = "Link")]
        public B3Link		OutLink;

        public override string		name => functionNodeType.ToString();

        public void SetData(FunctionNodeType type)
        {
            functionNodeType = type;
        }
    }
}