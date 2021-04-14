//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NVIDIA.PhysX {

public partial class PxConvexMeshDesc {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxConvexMeshDesc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConvexMeshDesc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxConvexMeshDesc() {
    destroy();
  }

  public virtual void destroy() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativePINVOKE.delete_PxConvexMeshDesc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxBoundedData points {
    set {
      NativePINVOKE.PxConvexMeshDesc_points_set(swigCPtr, PxBoundedData.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxConvexMeshDesc_points_get(swigCPtr);
      PxBoundedData ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBoundedData(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxBoundedData polygons {
    set {
      NativePINVOKE.PxConvexMeshDesc_polygons_set(swigCPtr, PxBoundedData.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxConvexMeshDesc_polygons_get(swigCPtr);
      PxBoundedData ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBoundedData(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxBoundedData indices {
    set {
      NativePINVOKE.PxConvexMeshDesc_indices_set(swigCPtr, PxBoundedData.getCPtr(value));
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxConvexMeshDesc_indices_get(swigCPtr);
      PxBoundedData ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBoundedData(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxConvexFlag flags {
    set {
      NativePINVOKE.PxConvexMeshDesc_flags_set(swigCPtr, (int)value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      PxConvexFlag ret = (PxConvexFlag)NativePINVOKE.PxConvexMeshDesc_flags_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort vertexLimit {
    set {
      NativePINVOKE.PxConvexMeshDesc_vertexLimit_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = NativePINVOKE.PxConvexMeshDesc_vertexLimit_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort quantizedCount {
    set {
      NativePINVOKE.PxConvexMeshDesc_quantizedCount_set(swigCPtr, value);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = NativePINVOKE.PxConvexMeshDesc_quantizedCount_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxConvexMeshDesc() : this(NativePINVOKE.new_PxConvexMeshDesc(), true) {
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setToDefault() {
    NativePINVOKE.PxConvexMeshDesc_setToDefault(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = NativePINVOKE.PxConvexMeshDesc_isValid(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
