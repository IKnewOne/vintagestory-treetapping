using System;
using Vintagestory.API.Common;

namespace TreeTapRedux;

public class TreeTapRedux : ModSystem {
    public static ILogger Logger { get; private set; }
    public static ICoreAPI Api { get; private set; }

    public override void StartPre(ICoreAPI api) {
        base.StartPre(api);
        Logger = Mod.Logger;
        Api = api;
    }

    public override void Start(ICoreAPI api) {
        base.Start(api);
        api.RegisterBlockBehaviorClass("AttachRestricted", typeof(BehaviorAttachRestricted));
    }


    public override void Dispose() {
        Logger = null;
        Api = null;
        base.Dispose();
    }
}
