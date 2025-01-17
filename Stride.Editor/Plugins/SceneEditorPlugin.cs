﻿using Stride.Assets.Entities;
using Stride.Core;
using Stride.Core.Assets;
using Stride.Editor.Design;
using Stride.Editor.Design.SceneEditor;
using Stride.Editor.Presentation;
using Stride.Editor.Presentation.SceneEditor;

namespace Stride.Editor.Plugins
{
    public class SceneEditorPlugin : IEditorPlugin
    {
        public void RegisterPlugin(IServiceRegistry services)
        {
            var viewRegistry = services.GetSafeServiceAs<ViewRegistry>();
            viewRegistry.RegisterView<UnloadableEditor, UnloadableEditorView>();
            viewRegistry.RegisterView<SceneEditor, SceneEditorView>();

            var assetManager = services.GetSafeServiceAs<IAssetEditorRegistry>();
            assetManager.RegisterAssetEditor<Asset, UnloadableEditor>();
			assetManager.RegisterAssetEditor<SceneAsset, SceneEditor>();
		}

        public void UnregisterPlugin(IServiceRegistry services)
        {
            var viewRegistry = services.GetSafeServiceAs<ViewRegistry>();
            viewRegistry.UnregisterView<SceneEditor, SceneEditorView>();
        }
    }
}
