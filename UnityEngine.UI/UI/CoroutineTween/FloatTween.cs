﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.CoroutineTween.FloatTween
// Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2216A18B-AF52-44A5-85A0-A1CAA19C1090
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.UI.dll

using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
  internal struct FloatTween : ITweenValue
  {
    private FloatTween.FloatTweenCallback m_Target;
    private float m_StartValue;
    private float m_TargetValue;
    private float m_Duration;
    private bool m_IgnoreTimeScale;

    public float startValue
    {
      get
      {
        return this.m_StartValue;
      }
      set
      {
        this.m_StartValue = value;
      }
    }

    public float targetValue
    {
      get
      {
        return this.m_TargetValue;
      }
      set
      {
        this.m_TargetValue = value;
      }
    }

    public float duration
    {
      get
      {
        return this.m_Duration;
      }
      set
      {
        this.m_Duration = value;
      }
    }

    public bool ignoreTimeScale
    {
      get
      {
        return this.m_IgnoreTimeScale;
      }
      set
      {
        this.m_IgnoreTimeScale = value;
      }
    }

    public void TweenValue(float floatPercentage)
    {
      if (!this.ValidTarget())
        return;
      this.m_Target.Invoke(Mathf.Lerp(this.m_StartValue, this.m_TargetValue, floatPercentage));
    }

    public void AddOnChangedCallback(UnityAction<float> callback)
    {
      if (this.m_Target == null)
        this.m_Target = new FloatTween.FloatTweenCallback();
      this.m_Target.AddListener(callback);
    }

    public bool GetIgnoreTimescale()
    {
      return this.m_IgnoreTimeScale;
    }

    public float GetDuration()
    {
      return this.m_Duration;
    }

    public bool ValidTarget()
    {
      return this.m_Target != null;
    }

    public class FloatTweenCallback : UnityEvent<float>
    {
    }
  }
}
