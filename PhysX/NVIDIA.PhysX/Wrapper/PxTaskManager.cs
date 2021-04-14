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

public partial class PxTaskManager {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;
  public object userData;

  internal PxTaskManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxTaskManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static PxTaskManager getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxTaskManager)) {
          wrapper = new PxTaskManager(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxTaskManager;
  }

  ~PxTaskManager() {
    WrapperCache.remove(swigCPtr.Handle, this);
  }

  public void setCpuDispatcher(PxCpuDispatcher ref_) {
    NativePINVOKE.PxTaskManager_setCpuDispatcher(swigCPtr, PxCpuDispatcher.getCPtr(ref_));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxCpuDispatcher getCpuDispatcher() {
    global::System.IntPtr cPtr = NativePINVOKE.PxTaskManager_getCpuDispatcher(swigCPtr);
    PxCpuDispatcher ret = (cPtr == global::System.IntPtr.Zero) ? null : PxCpuDispatcher.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resetDependencies() {
    NativePINVOKE.PxTaskManager_resetDependencies(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void startSimulation() {
    NativePINVOKE.PxTaskManager_startSimulation(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void stopSimulation() {
    NativePINVOKE.PxTaskManager_stopSimulation(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void taskCompleted(PxTask task) {
    NativePINVOKE.PxTaskManager_taskCompleted(swigCPtr, PxTask.getCPtr(task));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNamedTask(string name) {
    uint ret = NativePINVOKE.PxTaskManager_getNamedTask(swigCPtr, name);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint submitNamedTask(PxTask task, string name, PxTaskType type) {
    uint ret = NativePINVOKE.PxTaskManager_submitNamedTask__SWIG_0(swigCPtr, PxTask.getCPtr(task), name, (int)type);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint submitNamedTask(PxTask task, string name) {
    uint ret = NativePINVOKE.PxTaskManager_submitNamedTask__SWIG_1(swigCPtr, PxTask.getCPtr(task), name);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint submitUnnamedTask(PxTask task, PxTaskType type) {
    uint ret = NativePINVOKE.PxTaskManager_submitUnnamedTask__SWIG_0(swigCPtr, PxTask.getCPtr(task), (int)type);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint submitUnnamedTask(PxTask task) {
    uint ret = NativePINVOKE.PxTaskManager_submitUnnamedTask__SWIG_1(swigCPtr, PxTask.getCPtr(task));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxTask getTaskFromID(uint id) {
    global::System.IntPtr cPtr = NativePINVOKE.PxTaskManager_getTaskFromID(swigCPtr, id);
    PxTask ret = (cPtr == global::System.IntPtr.Zero) ? null : PxTask.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void release() {
    NativePINVOKE.PxTaskManager_release(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public static PxTaskManager createTaskManager(PxErrorCallback errorCallback, PxCpuDispatcher arg1) {
    global::System.IntPtr cPtr = NativePINVOKE.PxTaskManager_createTaskManager__SWIG_0(PxErrorCallback.getCPtr(errorCallback), PxCpuDispatcher.getCPtr(arg1));
    PxTaskManager ret = (cPtr == global::System.IntPtr.Zero) ? null : PxTaskManager.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxTaskManager createTaskManager(PxErrorCallback errorCallback) {
    global::System.IntPtr cPtr = NativePINVOKE.PxTaskManager_createTaskManager__SWIG_1(PxErrorCallback.getCPtr(errorCallback));
    PxTaskManager ret = (cPtr == global::System.IntPtr.Zero) ? null : PxTaskManager.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
