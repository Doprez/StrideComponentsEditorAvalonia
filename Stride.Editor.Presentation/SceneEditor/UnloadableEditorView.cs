using Stride.Core;
using Stride.Editor.Design.SceneEditor;
using Virtual = Stride.Editor.Presentation.VirtualDom.Controls;

namespace Stride.Editor.Presentation.SceneEditor;
public class UnloadableEditorView : ViewBase<Design.SceneEditor.UnloadableEditor>
{
	public UnloadableEditorView(IServiceRegistry services) : base(services)
	{
	}

	public override IViewBuilder CreateView(UnloadableEditor viewModel)
	{
		

		return new Virtual.TextBlock
		{
			Text = "There is no registered Editor for this type"
		};
	}
}
