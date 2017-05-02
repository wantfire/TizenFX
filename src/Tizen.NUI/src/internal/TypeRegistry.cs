//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

public class TypeRegistry : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TypeRegistry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.TypeRegistry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TypeRegistry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_TypeRegistry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static TypeRegistry Get() {
    TypeRegistry ret = new TypeRegistry(NDalicPINVOKE.TypeRegistry_Get(), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TypeRegistry() : this(NDalicPINVOKE.new_TypeRegistry__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypeRegistry(TypeRegistry handle) : this(NDalicPINVOKE.new_TypeRegistry__SWIG_1(TypeRegistry.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypeRegistry Assign(TypeRegistry rhs) {
    TypeRegistry ret = new TypeRegistry(NDalicPINVOKE.TypeRegistry_Assign(swigCPtr, TypeRegistry.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TypeInfo GetTypeInfo(string uniqueTypeName) {
    TypeInfo ret = new TypeInfo(NDalicPINVOKE.TypeRegistry_GetTypeInfo__SWIG_0(swigCPtr, uniqueTypeName), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal TypeInfo GetTypeInfo(SWIGTYPE_p_std__type_info registerType) {
    TypeInfo ret = new TypeInfo(NDalicPINVOKE.TypeRegistry_GetTypeInfo__SWIG_1(swigCPtr, SWIGTYPE_p_std__type_info.getCPtr(registerType)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetTypeNameCount() {
    uint ret = NDalicPINVOKE.TypeRegistry_GetTypeNameCount(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetTypeName(uint index) {
    string ret = NDalicPINVOKE.TypeRegistry_GetTypeName(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal TypeRegistry(SWIGTYPE_p_Dali__Internal__TypeRegistry typeRegistry) : this(NDalicPINVOKE.new_TypeRegistry__SWIG_2(SWIGTYPE_p_Dali__Internal__TypeRegistry.getCPtr(typeRegistry)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
