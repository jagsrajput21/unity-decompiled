﻿// Decompiled with JetBrains decompiler
// Type: JetBrains.Annotations.ImplicitUseTargetFlags
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;

namespace JetBrains.Annotations
{
  [Flags]
  public enum ImplicitUseTargetFlags
  {
    Default = 1,
    Itself = Default,
    Members = 2,
    WithMembers = Members | Itself,
  }
}
