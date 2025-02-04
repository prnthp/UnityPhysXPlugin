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

public partial class PxConvexMesh : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxConvexMesh(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxConvexMesh_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConvexMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxConvexMesh getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxConvexMesh)) {
          wrapper = new PxConvexMesh(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxConvexMesh;
  }

  public uint getNbVertices() {
    uint ret = NativePINVOKE.PxConvexMesh_getNbVertices(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxVec3  getVertex(uint index) {
        global::System.IntPtr ptr = NativePINVOKE.PxConvexMesh_getVertex(swigCPtr, index);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public byte getIndex(uint index) {
    byte ret = NativePINVOKE.PxConvexMesh_getIndex(swigCPtr, index);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNbPolygons() {
    uint ret = NativePINVOKE.PxConvexMesh_getNbPolygons(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getPolygonData(uint index,  out PxHullPolygon  data) {
    bool ret = NativePINVOKE.PxConvexMesh_getPolygonData(swigCPtr, index,  out data );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getReferenceCount() {
    uint ret = NativePINVOKE.PxConvexMesh_getReferenceCount(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void acquireReference() {
    NativePINVOKE.PxConvexMesh_acquireReference(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getMassInformation(out float mass,  out PxMat33  localInertia,  out PxVec3  localCenterOfMass) {
    NativePINVOKE.PxConvexMesh_getMassInformation(swigCPtr, out mass,  out localInertia ,  out localCenterOfMass );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMass() {
    float ret = NativePINVOKE.PxConvexMesh_getMass(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxMat33  getLocalInertia() {
        global::System.IntPtr ptr = NativePINVOKE.PxConvexMesh_getLocalInertia(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMat33 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMat33>(ptr);
        PxMat33 ret; unsafe { ret = *(PxMat33*)ptr; }
        return ret;
    }

  public  PxVec3  getLocalCenterOfMass() {
        global::System.IntPtr ptr = NativePINVOKE.PxConvexMesh_getLocalCenterOfMass(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxBounds3  getLocalBounds() {
        global::System.IntPtr ptr = NativePINVOKE.PxConvexMesh_getLocalBounds(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxBounds3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxBounds3>(ptr);
        PxBounds3 ret; unsafe { ret = *(PxBounds3*)ptr; }
        return ret;
    }

  public bool isGpuCompatible() {
    bool ret = NativePINVOKE.PxConvexMesh_isGpuCompatible(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
