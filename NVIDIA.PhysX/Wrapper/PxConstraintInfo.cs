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

public partial struct PxConstraintInfo {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwn;

  internal PxConstraintInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConstraintInfo obj) {
    return obj.swigCPtr;
  }

  public PxConstraint constraint {
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxConstraintInfo_constraint_get(swigCPtr);
      PxConstraint ret = (cPtr == global::System.IntPtr.Zero) ? null : PxConstraint.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint type {
    get {
      uint ret = NativePINVOKE.PxConstraintInfo_type_get(swigCPtr);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxJoint joint {
    get {
      global::System.IntPtr cPtr = NativePINVOKE.PxConstraintInfo_joint_get(swigCPtr);
      PxJoint ret = (cPtr == global::System.IntPtr.Zero) ? null : PxJoint.getWrapper(cPtr, false);
      if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
