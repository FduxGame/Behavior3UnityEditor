using GraphProcessor;

namespace B3Unity
{
    [NodeMenuItem("Root")]
    public class B3RootNode : BaseNode
    {
        [Output(name = "Link")]
        public B3Link		OutLink;

        public override string		name => "Root";
    }
}