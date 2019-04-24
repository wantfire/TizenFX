#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>Efl UI draggable interface</summary>
[IDraggableNativeInherit]
public interface IDraggable : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
/// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
/// <returns>Turn on or off drop_target. Default is <c>false</c>.</returns>
bool GetDragTarget();
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
/// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
/// <param name="set">Turn on or off drop_target. Default is <c>false</c>.</param>
/// <returns></returns>
void SetDragTarget( bool set);
            /// <summary>Called when drag operation starts</summary>
    event EventHandler<Efl.Ui.IDraggableDragEvt_Args> DragEvt;
    /// <summary>Called when drag started</summary>
    event EventHandler DragStartEvt;
    /// <summary>Called when drag stopped</summary>
    event EventHandler<Efl.Ui.IDraggableDragStopEvt_Args> DragStopEvt;
    /// <summary>Called when drag operation ends</summary>
    event EventHandler DragEndEvt;
    /// <summary>Called when drag starts into up direction</summary>
    event EventHandler<Efl.Ui.IDraggableDragStartUpEvt_Args> DragStartUpEvt;
    /// <summary>Called when drag starts into down direction</summary>
    event EventHandler<Efl.Ui.IDraggableDragStartDownEvt_Args> DragStartDownEvt;
    /// <summary>Called when drag starts into right direction</summary>
    event EventHandler<Efl.Ui.IDraggableDragStartRightEvt_Args> DragStartRightEvt;
    /// <summary>Called when drag starts into left direction</summary>
    event EventHandler<Efl.Ui.IDraggableDragStartLeftEvt_Args> DragStartLeftEvt;
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
/// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
/// <value>Turn on or off drop_target. Default is <c>false</c>.</value>
    bool DragTarget {
        get ;
        set ;
    }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragEvt"/>.</summary>
public class IDraggableDragEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragStopEvt"/>.</summary>
public class IDraggableDragStopEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragStartUpEvt"/>.</summary>
public class IDraggableDragStartUpEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragStartDownEvt"/>.</summary>
public class IDraggableDragStartDownEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragStartRightEvt"/>.</summary>
public class IDraggableDragStartRightEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.IDraggable.DragStartLeftEvt"/>.</summary>
public class IDraggableDragStartLeftEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Object arg { get; set; }
}
/// <summary>Efl UI draggable interface</summary>
sealed public class IDraggableConcrete : 

IDraggable
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (IDraggableConcrete))
                return Efl.Ui.IDraggableNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    private EventHandlerList eventHandlers = new EventHandlerList();
    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle {
        get { return handle; }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_ui_draggable_interface_get();
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    private IDraggableConcrete(System.IntPtr raw)
    {
        handle = raw;
        RegisterEventProxies();
    }
    ///<summary>Destructor.</summary>
    ~IDraggableConcrete()
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
    private readonly object eventLock = new object();
    private Dictionary<string, int> event_cb_count = new Dictionary<string, int>();
    ///<summary>Adds a new event handler, registering it to the native event. For internal use only.</summary>
    ///<param name="lib">The name of the native library definining the event.</param>
    ///<param name="key">The name of the native event.</param>
    ///<param name="evt_delegate">The delegate to be called on event raising.</param>
    ///<returns>True if the delegate was successfully registered.</returns>
    private bool AddNativeEventHandler(string lib, string key, Efl.EventCb evt_delegate) {
        int event_count = 0;
        if (!event_cb_count.TryGetValue(key, out event_count))
            event_cb_count[key] = event_count;
        if (event_count == 0) {
            IntPtr desc = Efl.EventDescription.GetNative(lib, key);
            if (desc == IntPtr.Zero) {
                Eina.Log.Error($"Failed to get native event {key}");
                return false;
            }
             bool result = Efl.Eo.Globals.efl_event_callback_priority_add(handle, desc, 0, evt_delegate, System.IntPtr.Zero);
            if (!result) {
                Eina.Log.Error($"Failed to add event proxy for event {key}");
                return false;
            }
            Eina.Error.RaiseIfUnhandledException();
        } 
        event_cb_count[key]++;
        return true;
    }
    ///<summary>Removes the given event handler for the given event. For internal use only.</summary>
    ///<param name="key">The name of the native event.</param>
    ///<param name="evt_delegate">The delegate to be removed.</param>
    ///<returns>True if the delegate was successfully registered.</returns>
    private bool RemoveNativeEventHandler(string key, Efl.EventCb evt_delegate) {
        int event_count = 0;
        if (!event_cb_count.TryGetValue(key, out event_count))
            event_cb_count[key] = event_count;
        if (event_count == 1) {
            IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Efl, key);
            if (desc == IntPtr.Zero) {
                Eina.Log.Error($"Failed to get native event {key}");
                return false;
            }
            bool result = Efl.Eo.Globals.efl_event_callback_del(handle, desc, evt_delegate, System.IntPtr.Zero);
            if (!result) {
                Eina.Log.Error($"Failed to remove event proxy for event {key}");
                return false;
            }
            Eina.Error.RaiseIfUnhandledException();
        } else if (event_count == 0) {
            Eina.Log.Error($"Trying to remove proxy for event {key} when there is nothing registered.");
            return false;
        } 
        event_cb_count[key]--;
        return true;
    }
private static object DragEvtKey = new object();
    /// <summary>Called when drag operation starts</summary>
    public event EventHandler<Efl.Ui.IDraggableDragEvt_Args> DragEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragEvt_delegate)) {
                    eventHandlers.AddHandler(DragEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG";
                if (RemoveNativeEventHandler(key, this.evt_DragEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragEvt.</summary>
    public void On_DragEvt(Efl.Ui.IDraggableDragEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragEvt_Args>)eventHandlers[DragEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragEvt_delegate;
    private void on_DragEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragEvt_Args args = new Efl.Ui.IDraggableDragEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStartEvtKey = new object();
    /// <summary>Called when drag started</summary>
    public event EventHandler DragStartEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStartEvt_delegate)) {
                    eventHandlers.AddHandler(DragStartEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START";
                if (RemoveNativeEventHandler(key, this.evt_DragStartEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStartEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStartEvt.</summary>
    public void On_DragStartEvt(EventArgs e)
    {
        EventHandler evt;
        lock (eventLock) {
        evt = (EventHandler)eventHandlers[DragStartEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStartEvt_delegate;
    private void on_DragStartEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        EventArgs args = EventArgs.Empty;
        try {
            On_DragStartEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStopEvtKey = new object();
    /// <summary>Called when drag stopped</summary>
    public event EventHandler<Efl.Ui.IDraggableDragStopEvt_Args> DragStopEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_STOP";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStopEvt_delegate)) {
                    eventHandlers.AddHandler(DragStopEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_STOP";
                if (RemoveNativeEventHandler(key, this.evt_DragStopEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStopEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStopEvt.</summary>
    public void On_DragStopEvt(Efl.Ui.IDraggableDragStopEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragStopEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragStopEvt_Args>)eventHandlers[DragStopEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStopEvt_delegate;
    private void on_DragStopEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragStopEvt_Args args = new Efl.Ui.IDraggableDragStopEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragStopEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragEndEvtKey = new object();
    /// <summary>Called when drag operation ends</summary>
    public event EventHandler DragEndEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_END";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragEndEvt_delegate)) {
                    eventHandlers.AddHandler(DragEndEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_END";
                if (RemoveNativeEventHandler(key, this.evt_DragEndEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragEndEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragEndEvt.</summary>
    public void On_DragEndEvt(EventArgs e)
    {
        EventHandler evt;
        lock (eventLock) {
        evt = (EventHandler)eventHandlers[DragEndEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragEndEvt_delegate;
    private void on_DragEndEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        EventArgs args = EventArgs.Empty;
        try {
            On_DragEndEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStartUpEvtKey = new object();
    /// <summary>Called when drag starts into up direction</summary>
    public event EventHandler<Efl.Ui.IDraggableDragStartUpEvt_Args> DragStartUpEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_UP";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStartUpEvt_delegate)) {
                    eventHandlers.AddHandler(DragStartUpEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_UP";
                if (RemoveNativeEventHandler(key, this.evt_DragStartUpEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStartUpEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStartUpEvt.</summary>
    public void On_DragStartUpEvt(Efl.Ui.IDraggableDragStartUpEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragStartUpEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragStartUpEvt_Args>)eventHandlers[DragStartUpEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStartUpEvt_delegate;
    private void on_DragStartUpEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragStartUpEvt_Args args = new Efl.Ui.IDraggableDragStartUpEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragStartUpEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStartDownEvtKey = new object();
    /// <summary>Called when drag starts into down direction</summary>
    public event EventHandler<Efl.Ui.IDraggableDragStartDownEvt_Args> DragStartDownEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_DOWN";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStartDownEvt_delegate)) {
                    eventHandlers.AddHandler(DragStartDownEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_DOWN";
                if (RemoveNativeEventHandler(key, this.evt_DragStartDownEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStartDownEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStartDownEvt.</summary>
    public void On_DragStartDownEvt(Efl.Ui.IDraggableDragStartDownEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragStartDownEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragStartDownEvt_Args>)eventHandlers[DragStartDownEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStartDownEvt_delegate;
    private void on_DragStartDownEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragStartDownEvt_Args args = new Efl.Ui.IDraggableDragStartDownEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragStartDownEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStartRightEvtKey = new object();
    /// <summary>Called when drag starts into right direction</summary>
    public event EventHandler<Efl.Ui.IDraggableDragStartRightEvt_Args> DragStartRightEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_RIGHT";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStartRightEvt_delegate)) {
                    eventHandlers.AddHandler(DragStartRightEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_RIGHT";
                if (RemoveNativeEventHandler(key, this.evt_DragStartRightEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStartRightEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStartRightEvt.</summary>
    public void On_DragStartRightEvt(Efl.Ui.IDraggableDragStartRightEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragStartRightEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragStartRightEvt_Args>)eventHandlers[DragStartRightEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStartRightEvt_delegate;
    private void on_DragStartRightEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragStartRightEvt_Args args = new Efl.Ui.IDraggableDragStartRightEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragStartRightEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DragStartLeftEvtKey = new object();
    /// <summary>Called when drag starts into left direction</summary>
    public event EventHandler<Efl.Ui.IDraggableDragStartLeftEvt_Args> DragStartLeftEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_LEFT";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_DragStartLeftEvt_delegate)) {
                    eventHandlers.AddHandler(DragStartLeftEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_EVENT_DRAG_START_LEFT";
                if (RemoveNativeEventHandler(key, this.evt_DragStartLeftEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DragStartLeftEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DragStartLeftEvt.</summary>
    public void On_DragStartLeftEvt(Efl.Ui.IDraggableDragStartLeftEvt_Args e)
    {
        EventHandler<Efl.Ui.IDraggableDragStartLeftEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.IDraggableDragStartLeftEvt_Args>)eventHandlers[DragStartLeftEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DragStartLeftEvt_delegate;
    private void on_DragStartLeftEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.IDraggableDragStartLeftEvt_Args args = new Efl.Ui.IDraggableDragStartLeftEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Object);
        try {
            On_DragStartLeftEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
     void RegisterEventProxies()
    {
        evt_DragEvt_delegate = new Efl.EventCb(on_DragEvt_NativeCallback);
        evt_DragStartEvt_delegate = new Efl.EventCb(on_DragStartEvt_NativeCallback);
        evt_DragStopEvt_delegate = new Efl.EventCb(on_DragStopEvt_NativeCallback);
        evt_DragEndEvt_delegate = new Efl.EventCb(on_DragEndEvt_NativeCallback);
        evt_DragStartUpEvt_delegate = new Efl.EventCb(on_DragStartUpEvt_NativeCallback);
        evt_DragStartDownEvt_delegate = new Efl.EventCb(on_DragStartDownEvt_NativeCallback);
        evt_DragStartRightEvt_delegate = new Efl.EventCb(on_DragStartRightEvt_NativeCallback);
        evt_DragStartLeftEvt_delegate = new Efl.EventCb(on_DragStartLeftEvt_NativeCallback);
    }
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
    /// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
    /// <returns>Turn on or off drop_target. Default is <c>false</c>.</returns>
    public bool GetDragTarget() {
         var _ret_var = Efl.Ui.IDraggableNativeInherit.efl_ui_draggable_drag_target_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
    /// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
    /// <param name="set">Turn on or off drop_target. Default is <c>false</c>.</param>
    /// <returns></returns>
    public void SetDragTarget( bool set) {
                                 Efl.Ui.IDraggableNativeInherit.efl_ui_draggable_drag_target_set_ptr.Value.Delegate(this.NativeHandle, set);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Control whether the object&apos;s content is changed by drag and drop.
/// If <c>drag_target</c> is true the object can be the target of a dragging object. The content of this object can then be changed into dragging content. For example, if an object deals with image and <c>drag_target</c> is true, the user can drag the new image and drop it into said object. This object&apos;s image can then be changed into a new image.</summary>
/// <value>Turn on or off drop_target. Default is <c>false</c>.</value>
    public bool DragTarget {
        get { return GetDragTarget(); }
        set { SetDragTarget( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.IDraggableConcrete.efl_ui_draggable_interface_get();
    }
}
public class IDraggableNativeInherit  : Efl.Eo.NativeClass{
    public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Efl);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_ui_draggable_drag_target_get_static_delegate == null)
            efl_ui_draggable_drag_target_get_static_delegate = new efl_ui_draggable_drag_target_get_delegate(drag_target_get);
        if (methods.FirstOrDefault(m => m.Name == "GetDragTarget") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_draggable_drag_target_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_draggable_drag_target_get_static_delegate)});
        if (efl_ui_draggable_drag_target_set_static_delegate == null)
            efl_ui_draggable_drag_target_set_static_delegate = new efl_ui_draggable_drag_target_set_delegate(drag_target_set);
        if (methods.FirstOrDefault(m => m.Name == "SetDragTarget") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_draggable_drag_target_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_draggable_drag_target_set_static_delegate)});
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.Ui.IDraggableConcrete.efl_ui_draggable_interface_get();
    }
    public static  IntPtr GetEflClassStatic()
    {
        return Efl.Ui.IDraggableConcrete.efl_ui_draggable_interface_get();
    }


     [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_draggable_drag_target_get_delegate(System.IntPtr obj, System.IntPtr pd);


     [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_draggable_drag_target_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_draggable_drag_target_get_api_delegate> efl_ui_draggable_drag_target_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_draggable_drag_target_get_api_delegate>(_Module, "efl_ui_draggable_drag_target_get");
     private static bool drag_target_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_draggable_drag_target_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        bool _ret_var = default(bool);
            try {
                _ret_var = ((IDraggable)wrapper).GetDragTarget();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_draggable_drag_target_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_draggable_drag_target_get_delegate efl_ui_draggable_drag_target_get_static_delegate;


     private delegate void efl_ui_draggable_drag_target_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool set);


     public delegate void efl_ui_draggable_drag_target_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool set);
     public static Efl.Eo.FunctionWrapper<efl_ui_draggable_drag_target_set_api_delegate> efl_ui_draggable_drag_target_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_draggable_drag_target_set_api_delegate>(_Module, "efl_ui_draggable_drag_target_set");
     private static void drag_target_set(System.IntPtr obj, System.IntPtr pd,  bool set)
    {
        Eina.Log.Debug("function efl_ui_draggable_drag_target_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((IDraggable)wrapper).SetDragTarget( set);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_ui_draggable_drag_target_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  set);
        }
    }
    private static efl_ui_draggable_drag_target_set_delegate efl_ui_draggable_drag_target_set_static_delegate;
}
} } 
