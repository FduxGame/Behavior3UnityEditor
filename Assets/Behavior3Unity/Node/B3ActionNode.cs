using GraphProcessor;

namespace B3Unity
{
    [NodeMenuItem("ActionNode")]
    public class B3ActionNode : BaseNode
    {
        [Input(name = "Link")]
        public B3Link		InLink;
    }
}