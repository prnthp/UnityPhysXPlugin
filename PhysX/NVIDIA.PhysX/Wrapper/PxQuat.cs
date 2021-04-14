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

[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
public partial struct PxQuat {

  public float x,y,z,w;

  internal global::System.IntPtr swigCPtr {
    get { unsafe { fixed(PxQuat* p = &this) return (global::System.IntPtr)p; } }
  }

  internal PxQuat(global::System.IntPtr ptr, bool unused) {
      //this = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxQuat>(ptr);
      unsafe { this = *(PxQuat*)ptr; }
  }
    
  public PxQuat(float r) : this(NativePINVOKE.new_PxQuat__SWIG_0(r), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxQuat(float x, float y, float z, float w) : this(NativePINVOKE.new_PxQuat__SWIG_1(x, y, z, w), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxQuat(float angleRadians,  PxVec3  unitAxis) : this(NativePINVOKE.new_PxQuat__SWIG_2(angleRadians,  unitAxis.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public PxQuat( PxMat33  m) : this(NativePINVOKE.new_PxQuat__SWIG_3( m.swigCPtr ), true) { 
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve(); }
  public bool isIdentity() {
    bool ret = NativePINVOKE.PxQuat_isIdentity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isFinite() {
    bool ret = NativePINVOKE.PxQuat_isFinite(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isUnit() {
    bool ret = NativePINVOKE.PxQuat_isUnit(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isSane() {
    bool ret = NativePINVOKE.PxQuat_isSane(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getAngle() {
    float ret = NativePINVOKE.PxQuat_getAngle__SWIG_0(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getAngle( PxQuat  q) {
    float ret = NativePINVOKE.PxQuat_getAngle__SWIG_1(swigCPtr,  q.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float magnitudeSquared() {
    float ret = NativePINVOKE.PxQuat_magnitudeSquared(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float dot( PxQuat  v) {
    float ret = NativePINVOKE.PxQuat_dot(swigCPtr,  v.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxQuat  getNormalized() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getNormalized(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxQuat ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxQuat>(ptr);
        PxQuat ret; unsafe { ret = *(PxQuat*)ptr; }
        return ret;
    }

  public float magnitude() {
    float ret = NativePINVOKE.PxQuat_magnitude(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float normalize() {
    float ret = NativePINVOKE.PxQuat_normalize(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxQuat  getConjugate() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getConjugate(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxQuat ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxQuat>(ptr);
        PxQuat ret; unsafe { ret = *(PxQuat*)ptr; }
        return ret;
    }

  public  PxVec3  getImaginaryPart() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getImaginaryPart(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getBasisVector0() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getBasisVector0(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getBasisVector1() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getBasisVector1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getBasisVector2() {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_getBasisVector2(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  rotate( PxVec3  v) {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_rotate(swigCPtr,  v.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  rotateInv( PxVec3  v) {
        global::System.IntPtr ptr = NativePINVOKE.PxQuat_rotateInv(swigCPtr,  v.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

}

}
