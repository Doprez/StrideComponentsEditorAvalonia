using Stride.Assets.Entities;
using Stride.Core;
using Stride.Core.Assets;
using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride.Editor.Design.SceneEditor;
public class UnloadableEditor : IAssetEditor
{
	public Asset Asset { get; }

	public string AssetName { get; set; } = "";

	public UnloadableEditor(Asset asset, IServiceRegistry services)
	{
		Asset = asset;
	}
}
