using Stride.Assets.Entities;
using Stride.Editor.Design.Core.Hierarchy;
using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride.Editor.Design.SceneEditor;
public class UnloadableViewModel
{


	public EntityHierarchyAssetBase AssetSource { get; }

	public Scene GameSource { get; }

	public IAssetEditor Editor { get; }

	public UnloadableViewModel(EntityHierarchyAssetBase asset, IAssetEditor editor)
	{
		AssetSource = asset;
		Editor = editor;
	}
}
