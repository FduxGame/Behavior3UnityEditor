using GraphProcessor;
using UnityEditor;
using UnityEngine;

namespace B3Unity
{
    public class B3GraphWindow : BaseGraphWindow
    {
        private B3Graph tmpGraph;

        [MenuItem("Window/Behavior3UnityEditor")]
        public static B3GraphWindow OpenWithTmpGraph()
        {
            var graphWindow = CreateWindow<B3GraphWindow>();

            // When the graph is opened from the window, we don't save the graph to disk
            graphWindow.tmpGraph = CreateInstance<B3Graph>();
            graphWindow.tmpGraph.hideFlags = HideFlags.HideAndDontSave;
            graphWindow.InitializeGraph(graphWindow.tmpGraph);

            graphWindow.Show();
            return graphWindow;
        }

        protected override void InitializeWindow(BaseGraph graph)
        {
            titleContent = new GUIContent("Default Graph");

            if (graphView == null)
                graphView = new BaseGraphView(this);

            rootView.Add(graphView);
        }
    }
}