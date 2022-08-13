using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Boot
{
    public class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
    where TLauncher : SceneLauncher<TLauncher, TView>
    where TView : BaseSceneView
    {
        public override string SceneName => "Gameplay";

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override IConnector[] GetSceneConnectors()
        {
            throw new System.NotImplementedException();
        }

        protected override IController[] GetSceneDependencies()
        {
            throw new System.NotImplementedException();
        }

        protected override ISplash GetSplash()
        {
            return SplashScreen.Instance;
        }

        protected override IEnumerator InitSceneObject()
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerator LaunchScene()
        {
            throw new System.NotImplementedException();
        }
    }

}
