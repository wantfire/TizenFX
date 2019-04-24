#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { 
/// <summary>Efl control interface</summary>
[IControlNativeInherit]
public interface IControl : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Control the priority of the object.</summary>
/// <returns>The priority of the object</returns>
int GetPriority();
    /// <summary>Control the priority of the object.</summary>
/// <param name="priority">The priority of the object</param>
/// <returns></returns>
void SetPriority( int priority);
    /// <summary>Controls whether the object is suspended or not.</summary>
/// <returns>Controls whether the object is suspended or not.</returns>
bool GetSuspend();
    /// <summary>Controls whether the object is suspended or not.</summary>
/// <param name="suspend">Controls whether the object is suspended or not.</param>
/// <returns></returns>
void SetSuspend( bool suspend);
                    /// <summary>Control the priority of the object.</summary>
/// <value>The priority of the object</value>
    int Priority {
        get ;
        set ;
    }
    /// <summary>Controls whether the object is suspended or not.</summary>
/// <value>Controls whether the object is suspended or not.</value>
    bool Suspend {
        get ;
        set ;
    }
}
/// <summary>Efl control interface</summary>
sealed public class IControlConcrete : 

IControl
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (IControlConcrete))
                return Efl.IControlNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle {
        get { return handle; }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_control_interface_get();
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    private IControlConcrete(System.IntPtr raw)
    {
        handle = raw;
        RegisterEventProxies();
    }
    ///<summary>Destructor.</summary>
    ~IControlConcrete()
    {
        Dispose(false);
    }
    ///<summary>Releases the underlying native instance.</summary>
    void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero) {
            Efl.Eo.Globals.efl_unref(handle);
            handle = System.IntPtr.Zero;
        }
    }
    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    ///<summary>Verifies if the given object is equal to this one.</summary>
    public override bool Equals(object obj)
    {
        var other = obj as Efl.Object;
        if (other == null)
            return false;
        return this.NativeHandle == other.NativeHandle;
    }
    ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }
    ///<summary>Turns the native pointer into a string representation.</summary>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }
    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
     void RegisterEventProxies()
    {
    }
    /// <summary>Control the priority of the object.</summary>
    /// <returns>The priority of the object</returns>
    public int GetPriority() {
         var _ret_var = Efl.IControlNativeInherit.efl_control_priority_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Control the priority of the object.</summary>
    /// <param name="priority">The priority of the object</param>
    /// <returns></returns>
    public void SetPriority( int priority) {
                                 Efl.IControlNativeInherit.efl_control_priority_set_ptr.Value.Delegate(this.NativeHandle, priority);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Controls whether the object is suspended or not.</summary>
    /// <returns>Controls whether the object is suspended or not.</returns>
    public bool GetSuspend() {
         var _ret_var = Efl.IControlNativeInherit.efl_control_suspend_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Controls whether the object is suspended or not.</summary>
    /// <param name="suspend">Controls whether the object is suspended or not.</param>
    /// <returns></returns>
    public void SetSuspend( bool suspend) {
                                 Efl.IControlNativeInherit.efl_control_suspend_set_ptr.Value.Delegate(this.NativeHandle, suspend);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Control the priority of the object.</summary>
/// <value>The priority of the object</value>
    public int Priority {
        get { return GetPriority(); }
        set { SetPriority( value); }
    }
    /// <summary>Controls whether the object is suspended or not.</summary>
/// <value>Controls whether the object is suspended or not.</value>
    public bool Suspend {
        get { return GetSuspend(); }
        set { SetSuspend( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.IControlConcrete.efl_control_interface_get();
    }
}
public class IControlNativeInherit  : Efl.Eo.NativeClass{
    public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Efl);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_control_priority_get_static_delegate == null)
            efl_control_priority_get_static_delegate = new efl_control_priority_get_delegate(priority_get);
        if (methods.FirstOrDefault(m => m.Name == "GetPriority") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_control_priority_get"), func = Marshal.GetFunctionPointerForDelegate(efl_control_priority_get_static_delegate)});
        if (efl_control_priority_set_static_delegate == null)
            efl_control_priority_set_static_delegate = new efl_control_priority_set_delegate(priority_set);
        if (methods.FirstOrDefault(m => m.Name == "SetPriority") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_control_priority_set"), func = Marshal.GetFunctionPointerForDelegate(efl_control_priority_set_static_delegate)});
        if (efl_control_suspend_get_static_delegate == null)
            efl_control_suspend_get_static_delegate = new efl_control_suspend_get_delegate(suspend_get);
        if (methods.FirstOrDefault(m => m.Name == "GetSuspend") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_control_suspend_get"), func = Marshal.GetFunctionPointerForDelegate(efl_control_suspend_get_static_delegate)});
        if (efl_control_suspend_set_static_delegate == null)
            efl_control_suspend_set_static_delegate = new efl_control_suspend_set_delegate(suspend_set);
        if (methods.FirstOrDefault(m => m.Name == "SetSuspend") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_control_suspend_set"), func = Marshal.GetFunctionPointerForDelegate(efl_control_suspend_set_static_delegate)});
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.IControlConcrete.efl_control_interface_get();
    }
    public static  IntPtr GetEflClassStatic()
    {
        return Efl.IControlConcrete.efl_control_interface_get();
    }


     private delegate int efl_control_priority_get_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate int efl_control_priority_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_control_priority_get_api_delegate> efl_control_priority_get_ptr = new Efl.Eo.FunctionWrapper<efl_control_priority_get_api_delegate>(_Module, "efl_control_priority_get");
     private static int priority_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_control_priority_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        int _ret_var = default(int);
            try {
                _ret_var = ((IControl)wrapper).GetPriority();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_control_priority_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_control_priority_get_delegate efl_control_priority_get_static_delegate;


     private delegate void efl_control_priority_set_delegate(System.IntPtr obj, System.IntPtr pd,   int priority);


     public delegate void efl_control_priority_set_api_delegate(System.IntPtr obj,   int priority);
     public static Efl.Eo.FunctionWrapper<efl_control_priority_set_api_delegate> efl_control_priority_set_ptr = new Efl.Eo.FunctionWrapper<efl_control_priority_set_api_delegate>(_Module, "efl_control_priority_set");
     private static void priority_set(System.IntPtr obj, System.IntPtr pd,  int priority)
    {
        Eina.Log.Debug("function efl_control_priority_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((IControl)wrapper).SetPriority( priority);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_control_priority_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  priority);
        }
    }
    private static efl_control_priority_set_delegate efl_control_priority_set_static_delegate;


     [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_control_suspend_get_delegate(System.IntPtr obj, System.IntPtr pd);


     [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_control_suspend_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_control_suspend_get_api_delegate> efl_control_suspend_get_ptr = new Efl.Eo.FunctionWrapper<efl_control_suspend_get_api_delegate>(_Module, "efl_control_suspend_get");
     private static bool suspend_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_control_suspend_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        bool _ret_var = default(bool);
            try {
                _ret_var = ((IControl)wrapper).GetSuspend();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_control_suspend_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_control_suspend_get_delegate efl_control_suspend_get_static_delegate;


     private delegate void efl_control_suspend_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool suspend);


     public delegate void efl_control_suspend_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool suspend);
     public static Efl.Eo.FunctionWrapper<efl_control_suspend_set_api_delegate> efl_control_suspend_set_ptr = new Efl.Eo.FunctionWrapper<efl_control_suspend_set_api_delegate>(_Module, "efl_control_suspend_set");
     private static void suspend_set(System.IntPtr obj, System.IntPtr pd,  bool suspend)
    {
        Eina.Log.Debug("function efl_control_suspend_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((IControl)wrapper).SetSuspend( suspend);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_control_suspend_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  suspend);
        }
    }
    private static efl_control_suspend_set_delegate efl_control_suspend_set_static_delegate;
}
} 
