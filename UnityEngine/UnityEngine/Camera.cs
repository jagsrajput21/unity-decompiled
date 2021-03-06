﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Camera
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A Camera is a device through which the player views the world.</para>
  /// </summary>
  [UsedByNativeCode]
  public sealed class Camera : Behaviour
  {
    /// <summary>
    ///   <para>Event that is fired before any camera starts culling.</para>
    /// </summary>
    public static Camera.CameraCallback onPreCull;
    /// <summary>
    ///   <para>Event that is fired before any camera starts rendering.</para>
    /// </summary>
    public static Camera.CameraCallback onPreRender;
    /// <summary>
    ///   <para>Event that is fired after any camera finishes rendering.</para>
    /// </summary>
    public static Camera.CameraCallback onPostRender;

    [Obsolete("use Camera.fieldOfView instead.")]
    public float fov
    {
      get
      {
        return this.fieldOfView;
      }
      set
      {
        this.fieldOfView = value;
      }
    }

    [Obsolete("use Camera.nearClipPlane instead.")]
    public float near
    {
      get
      {
        return this.nearClipPlane;
      }
      set
      {
        this.nearClipPlane = value;
      }
    }

    [Obsolete("use Camera.farClipPlane instead.")]
    public float far
    {
      get
      {
        return this.farClipPlane;
      }
      set
      {
        this.farClipPlane = value;
      }
    }

    /// <summary>
    ///   <para>The field of view of the camera in degrees.</para>
    /// </summary>
    public float fieldOfView { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The near clipping plane distance.</para>
    /// </summary>
    public float nearClipPlane { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The far clipping plane distance.</para>
    /// </summary>
    public float farClipPlane { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>The rendering path that should be used, if possible.
    /// 
    /// In some situations, it may not be possible to use the rendering path specified, in which case the renderer will automatically use a different path. For example, if the underlying gpu/platform does not support the requested one, or some other situation caused a fallback (for example, deferred rendering is not supported with orthographic projection cameras).
    /// 
    /// For this reason, we also provide the read-only property actualRenderingPath which allows you to discover which path is actually being used.</para>
    ///       </summary>
    public RenderingPath renderingPath { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>The rendering path that is currently being used (Read Only).
    /// 
    /// The actual rendering path might be different from the user-specified renderingPath if the underlying gpu/platform does not support the requested one, or some other situation caused a fallback (for example, deferred rendering is not supported with orthographic projection cameras).</para>
    ///       </summary>
    public RenderingPath actualRenderingPath { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>High dynamic range rendering.</para>
    /// </summary>
    public bool hdr { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Camera's half-size when in orthographic mode.</para>
    /// </summary>
    public float orthographicSize { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Is the camera orthographic (true) or perspective (false)?</para>
    /// </summary>
    public bool orthographic { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Opaque object sorting mode.</para>
    /// </summary>
    public OpaqueSortMode opaqueSortMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Transparent object sorting mode.</para>
    /// </summary>
    public TransparencySortMode transparencySortMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Camera's depth in the camera rendering order.</para>
    /// </summary>
    public float depth { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The aspect ratio (width divided by height).</para>
    /// </summary>
    public float aspect { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>This is used to render parts of the scene selectively.</para>
    /// </summary>
    public int cullingMask { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    internal static extern int PreviewCullingLayer { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Mask to select which layers can trigger events on the camera.</para>
    /// </summary>
    public int eventMask { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The color with which the screen will be cleared.</para>
    /// </summary>
    public Color backgroundColor
    {
      get
      {
        Color color;
        this.INTERNAL_get_backgroundColor(out color);
        return color;
      }
      set
      {
        this.INTERNAL_set_backgroundColor(ref value);
      }
    }

    /// <summary>
    ///   <para>Where on the screen is the camera rendered in normalized coordinates.</para>
    /// </summary>
    public Rect rect
    {
      get
      {
        Rect rect;
        this.INTERNAL_get_rect(out rect);
        return rect;
      }
      set
      {
        this.INTERNAL_set_rect(ref value);
      }
    }

    /// <summary>
    ///   <para>Where on the screen is the camera rendered in pixel coordinates.</para>
    /// </summary>
    public Rect pixelRect
    {
      get
      {
        Rect rect;
        this.INTERNAL_get_pixelRect(out rect);
        return rect;
      }
      set
      {
        this.INTERNAL_set_pixelRect(ref value);
      }
    }

    /// <summary>
    ///   <para>Destination render texture.</para>
    /// </summary>
    public RenderTexture targetTexture { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>How wide is the camera in pixels (Read Only).</para>
    /// </summary>
    public int pixelWidth { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>How tall is the camera in pixels (Read Only).</para>
    /// </summary>
    public int pixelHeight { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Matrix that transforms from camera space to world space (Read Only).</para>
    /// </summary>
    public Matrix4x4 cameraToWorldMatrix
    {
      get
      {
        Matrix4x4 matrix4x4;
        this.INTERNAL_get_cameraToWorldMatrix(out matrix4x4);
        return matrix4x4;
      }
    }

    /// <summary>
    ///   <para>Matrix that transforms from world to camera space.</para>
    /// </summary>
    public Matrix4x4 worldToCameraMatrix
    {
      get
      {
        Matrix4x4 matrix4x4;
        this.INTERNAL_get_worldToCameraMatrix(out matrix4x4);
        return matrix4x4;
      }
      set
      {
        this.INTERNAL_set_worldToCameraMatrix(ref value);
      }
    }

    /// <summary>
    ///   <para>Set a custom projection matrix.</para>
    /// </summary>
    public Matrix4x4 projectionMatrix
    {
      get
      {
        Matrix4x4 matrix4x4;
        this.INTERNAL_get_projectionMatrix(out matrix4x4);
        return matrix4x4;
      }
      set
      {
        this.INTERNAL_set_projectionMatrix(ref value);
      }
    }

    /// <summary>
    ///   <para>Get the world-space speed of the camera (Read Only).</para>
    /// </summary>
    public Vector3 velocity
    {
      get
      {
        Vector3 vector3;
        this.INTERNAL_get_velocity(out vector3);
        return vector3;
      }
    }

    /// <summary>
    ///   <para>How the camera clears the background.</para>
    /// </summary>
    public CameraClearFlags clearFlags { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Stereoscopic rendering.</para>
    /// </summary>
    public bool stereoEnabled { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Distance between the virtual eyes.</para>
    /// </summary>
    public float stereoSeparation { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Distance to a point where virtual eyes converge.</para>
    /// </summary>
    public float stereoConvergence { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Identifies what kind of camera this is.</para>
    /// </summary>
    public CameraType cameraType { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Render only once and use resulting image for both eyes.</para>
    /// </summary>
    public bool stereoMirrorMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the target display for this Camera.</para>
    /// </summary>
    public int targetDisplay { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The first enabled camera tagged "MainCamera" (Read Only).</para>
    /// </summary>
    public static extern Camera main { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The camera we are currently rendering with, for low-level render control only (Read Only).</para>
    /// </summary>
    public static extern Camera current { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns all enabled cameras in the scene.</para>
    /// </summary>
    public static extern Camera[] allCameras { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The number of cameras in the current scene.</para>
    /// </summary>
    public static extern int allCamerasCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Whether or not the Camera will use occlusion culling during rendering.</para>
    /// </summary>
    public bool useOcclusionCulling { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Per-layer culling distances.</para>
    /// </summary>
    public float[] layerCullDistances { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>How to perform per-layer culling for a Camera.</para>
    /// </summary>
    public bool layerCullSpherical { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>How and if camera generates a depth texture.</para>
    /// </summary>
    public DepthTextureMode depthTextureMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Should the camera clear the stencil buffer after the deferred light pass?</para>
    /// </summary>
    public bool clearStencilAfterLightingPass { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Number of command buffers set up on this camera (Read Only).</para>
    /// </summary>
    public int commandBufferCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Property isOrthoGraphic has been deprecated. Use orthographic (UnityUpgradable) -> orthographic", true)]
    public bool isOrthoGraphic
    {
      get
      {
        return false;
      }
      set
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Property mainCamera has been deprecated. Use Camera.main instead (UnityUpgradable) -> main", true)]
    public static Camera mainCamera
    {
      get
      {
        return (Camera) null;
      }
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal string[] GetHDRWarnings();

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_backgroundColor(out Color value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_backgroundColor(ref Color value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_rect(out Rect value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_rect(ref Rect value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_pixelRect(out Rect value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_pixelRect(ref Rect value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetTargetBuffersImpl(out RenderBuffer color, out RenderBuffer depth);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void SetTargetBuffersMRTImpl(RenderBuffer[] color, out RenderBuffer depth);

    /// <summary>
    ///   <para>Sets the Camera to render to the chosen buffers of one or more RenderTextures.</para>
    /// </summary>
    /// <param name="colorBuffer">The RenderBuffer(s) to which color information will be rendered.</param>
    /// <param name="depthBuffer">The RenderBuffer to which depth information will be rendered.</param>
    public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
    {
      this.SetTargetBuffersImpl(out colorBuffer, out depthBuffer);
    }

    /// <summary>
    ///   <para>Sets the Camera to render to the chosen buffers of one or more RenderTextures.</para>
    /// </summary>
    /// <param name="colorBuffer">The RenderBuffer(s) to which color information will be rendered.</param>
    /// <param name="depthBuffer">The RenderBuffer to which depth information will be rendered.</param>
    public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer)
    {
      this.SetTargetBuffersMRTImpl(colorBuffer, out depthBuffer);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_cameraToWorldMatrix(out Matrix4x4 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_worldToCameraMatrix(out Matrix4x4 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_worldToCameraMatrix(ref Matrix4x4 value);

    /// <summary>
    ///   <para>Make the rendering position reflect the camera's position in the scene.</para>
    /// </summary>
    public void ResetWorldToCameraMatrix()
    {
      Camera.INTERNAL_CALL_ResetWorldToCameraMatrix(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetWorldToCameraMatrix(Camera self);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_projectionMatrix(out Matrix4x4 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_projectionMatrix(ref Matrix4x4 value);

    /// <summary>
    ///   <para>Make the projection reflect normal camera's parameters.</para>
    /// </summary>
    public void ResetProjectionMatrix()
    {
      Camera.INTERNAL_CALL_ResetProjectionMatrix(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetProjectionMatrix(Camera self);

    /// <summary>
    ///   <para>Revert the aspect ratio to the screen's aspect ratio.</para>
    /// </summary>
    public void ResetAspect()
    {
      Camera.INTERNAL_CALL_ResetAspect(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetAspect(Camera self);

    /// <summary>
    ///   <para>Reset to the default field of view.</para>
    /// </summary>
    public void ResetFieldOfView()
    {
      Camera.INTERNAL_CALL_ResetFieldOfView(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetFieldOfView(Camera self);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_velocity(out Vector3 value);

    /// <summary>
    ///   <para>Define the view matrices for both stereo eye. Only work in 3D flat panel display.</para>
    /// </summary>
    /// <param name="leftMatrix">View matrix for the stereo left eye.</param>
    /// <param name="rightMatrix">View matrix for the stereo right eye.</param>
    public void SetStereoViewMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix)
    {
      Camera.INTERNAL_CALL_SetStereoViewMatrices(this, ref leftMatrix, ref rightMatrix);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetStereoViewMatrices(Camera self, ref Matrix4x4 leftMatrix, ref Matrix4x4 rightMatrix);

    /// <summary>
    ///   <para>Use the default view matrix for both stereo eye. Only work in 3D flat panel display.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void ResetStereoViewMatrices();

    /// <summary>
    ///   <para>Define the projection matrix for both stereo eye. Only work in 3D flat panel display.</para>
    /// </summary>
    /// <param name="leftMatrix">Projection matrix for the stereo left eye.</param>
    /// <param name="rightMatrix">Projection matrix for the stereo left eye.</param>
    public void SetStereoProjectionMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix)
    {
      Camera.INTERNAL_CALL_SetStereoProjectionMatrices(this, ref leftMatrix, ref rightMatrix);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetStereoProjectionMatrices(Camera self, ref Matrix4x4 leftMatrix, ref Matrix4x4 rightMatrix);

    /// <summary>
    ///   <para>Use the default projection matrix for both stereo eye. Only work in 3D flat panel display.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void ResetStereoProjectionMatrices();

    /// <summary>
    ///   <para>Transforms position from world space into screen space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 WorldToScreenPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_WorldToScreenPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_WorldToScreenPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Transforms position from world space into viewport space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 WorldToViewportPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_WorldToViewportPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_WorldToViewportPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Transforms position from viewport space into world space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 ViewportToWorldPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_ViewportToWorldPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ViewportToWorldPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Transforms position from screen space into world space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 ScreenToWorldPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_ScreenToWorldPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ScreenToWorldPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Transforms position from screen space into viewport space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 ScreenToViewportPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_ScreenToViewportPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ScreenToViewportPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Transforms position from viewport space into screen space.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 ViewportToScreenPoint(Vector3 position)
    {
      Vector3 vector3;
      Camera.INTERNAL_CALL_ViewportToScreenPoint(this, ref position, out vector3);
      return vector3;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ViewportToScreenPoint(Camera self, ref Vector3 position, out Vector3 value);

    /// <summary>
    ///   <para>Returns a ray going from camera through a viewport point.</para>
    /// </summary>
    /// <param name="position"></param>
    public Ray ViewportPointToRay(Vector3 position)
    {
      Ray ray;
      Camera.INTERNAL_CALL_ViewportPointToRay(this, ref position, out ray);
      return ray;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ViewportPointToRay(Camera self, ref Vector3 position, out Ray value);

    /// <summary>
    ///   <para>Returns a ray going from camera through a screen point.</para>
    /// </summary>
    /// <param name="position"></param>
    public Ray ScreenPointToRay(Vector3 position)
    {
      Ray ray;
      Camera.INTERNAL_CALL_ScreenPointToRay(this, ref position, out ray);
      return ray;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ScreenPointToRay(Camera self, ref Vector3 position, out Ray value);

    /// <summary>
    ///   <para>Fills an array of Camera with the current cameras in the scene, without allocating a new array.</para>
    /// </summary>
    /// <param name="cameras">An array to be filled up with cameras currently in the scene.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int GetAllCameras(Camera[] cameras);

    [RequiredByNativeCode]
    private static void FireOnPreCull(Camera cam)
    {
      if (Camera.onPreCull == null)
        return;
      Camera.onPreCull(cam);
    }

    [RequiredByNativeCode]
    private static void FireOnPreRender(Camera cam)
    {
      if (Camera.onPreRender == null)
        return;
      Camera.onPreRender(cam);
    }

    [RequiredByNativeCode]
    private static void FireOnPostRender(Camera cam)
    {
      if (Camera.onPostRender == null)
        return;
      Camera.onPostRender(cam);
    }

    /// <summary>
    ///   <para>Render the camera manually.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void Render();

    /// <summary>
    ///   <para>Render the camera with shader replacement.</para>
    /// </summary>
    /// <param name="shader"></param>
    /// <param name="replacementTag"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RenderWithShader(Shader shader, string replacementTag);

    /// <summary>
    ///   <para>Make the camera render with shader replacement.</para>
    /// </summary>
    /// <param name="shader"></param>
    /// <param name="replacementTag"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetReplacementShader(Shader shader, string replacementTag);

    /// <summary>
    ///   <para>Remove shader replacement from camera.</para>
    /// </summary>
    public void ResetReplacementShader()
    {
      Camera.INTERNAL_CALL_ResetReplacementShader(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetReplacementShader(Camera self);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RenderDontRestore();

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetupCurrent(Camera cur);

    [ExcludeFromDocs]
    public bool RenderToCubemap(Cubemap cubemap)
    {
      int faceMask = 63;
      return this.RenderToCubemap(cubemap, faceMask);
    }

    /// <summary>
    ///   <para>Render into a static cubemap from this camera.</para>
    /// </summary>
    /// <param name="cubemap">The cube map to render to.</param>
    /// <param name="faceMask">A bitmask which determines which of the six faces are rendered to.</param>
    /// <returns>
    ///   <para>False is rendering fails, else true.</para>
    /// </returns>
    public bool RenderToCubemap(Cubemap cubemap, [DefaultValue("63")] int faceMask)
    {
      return this.Internal_RenderToCubemapTexture(cubemap, faceMask);
    }

    [ExcludeFromDocs]
    public bool RenderToCubemap(RenderTexture cubemap)
    {
      int faceMask = 63;
      return this.RenderToCubemap(cubemap, faceMask);
    }

    /// <summary>
    ///   <para>Render into a cubemap from this camera.</para>
    /// </summary>
    /// <param name="faceMask">A bitfield indicating which cubemap faces should be rendered into.</param>
    /// <param name="cubemap">The texture to render to.</param>
    /// <returns>
    ///   <para>False is rendering fails, else true.</para>
    /// </returns>
    public bool RenderToCubemap(RenderTexture cubemap, [DefaultValue("63")] int faceMask)
    {
      return this.Internal_RenderToCubemapRT(cubemap, faceMask);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool Internal_RenderToCubemapRT(RenderTexture cubemap, int faceMask);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool Internal_RenderToCubemapTexture(Cubemap cubemap, int faceMask);

    /// <summary>
    ///   <para>Makes this camera's settings match other camera.</para>
    /// </summary>
    /// <param name="other"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void CopyFrom(Camera other);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal bool IsFiltered(GameObject go);

    /// <summary>
    ///   <para>Add a command buffer to be executed at a specified place.</para>
    /// </summary>
    /// <param name="evt">When to execute the command buffer during rendering.</param>
    /// <param name="buffer">The buffer to execute.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer);

    /// <summary>
    ///   <para>Remove command buffer from execution at a specified place.</para>
    /// </summary>
    /// <param name="evt">When to execute the command buffer during rendering.</param>
    /// <param name="buffer">The buffer to execute.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer);

    /// <summary>
    ///   <para>Remove command buffers from execution at a specified place.</para>
    /// </summary>
    /// <param name="evt">When to execute the command buffer during rendering.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RemoveCommandBuffers(CameraEvent evt);

    /// <summary>
    ///   <para>Remove all command buffers set on this camera.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RemoveAllCommandBuffers();

    /// <summary>
    ///   <para>Get command buffers to be executed at a specified place.</para>
    /// </summary>
    /// <param name="evt">When to execute the command buffer during rendering.</param>
    /// <returns>
    ///   <para>Array of command buffers.</para>
    /// </returns>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public CommandBuffer[] GetCommandBuffers(CameraEvent evt);

    internal GameObject RaycastTry(Ray ray, float distance, int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
      return Camera.INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, queryTriggerInteraction);
    }

    [ExcludeFromDocs]
    internal GameObject RaycastTry(Ray ray, float distance, int layerMask)
    {
      QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
      return Camera.INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, queryTriggerInteraction);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern GameObject INTERNAL_CALL_RaycastTry(Camera self, ref Ray ray, float distance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

    internal GameObject RaycastTry2D(Ray ray, float distance, int layerMask)
    {
      return Camera.INTERNAL_CALL_RaycastTry2D(this, ref ray, distance, layerMask);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern GameObject INTERNAL_CALL_RaycastTry2D(Camera self, ref Ray ray, float distance, int layerMask);

    /// <summary>
    ///   <para>Calculates and returns oblique near-plane projection matrix.</para>
    /// </summary>
    /// <param name="clipPlane">Vector4 that describes a clip plane.</param>
    /// <returns>
    ///   <para>Oblique near-plane projection matrix.</para>
    /// </returns>
    public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
    {
      Matrix4x4 matrix4x4;
      Camera.INTERNAL_CALL_CalculateObliqueMatrix(this, ref clipPlane, out matrix4x4);
      return matrix4x4;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_CalculateObliqueMatrix(Camera self, ref Vector4 clipPlane, out Matrix4x4 value);

    internal void OnlyUsedForTesting1()
    {
    }

    internal void OnlyUsedForTesting2()
    {
    }

    [Obsolete("Property GetScreenWidth() has been deprecated. Use Screen.width instead (UnityUpgradable) -> Screen.width", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetScreenWidth()
    {
      return 0.0f;
    }

    [Obsolete("Property GetScreenHeight() has been deprecated. Use Screen.height instead (UnityUpgradable) -> Screen.height", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float GetScreenHeight()
    {
      return 0.0f;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Camera.DoClear has been deprecated (UnityUpgradable).", true)]
    public void DoClear()
    {
    }

    /// <summary>
    ///   <para>Delegate type for camera callbacks.</para>
    /// </summary>
    /// <param name="cam"></param>
    public delegate void CameraCallback(Camera cam);
  }
}
