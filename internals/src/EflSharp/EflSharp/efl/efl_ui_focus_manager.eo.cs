#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { namespace Focus { 
/// <summary>Interface for managing focus objects
/// This interface is built in order to support movement of the focus property in a set of widgets. The movement of the focus property can happen in a tree manner, or a graph manner. The movement is also keeping track of the history of focused elements. The tree interpretation differentiates between logical and non-logical widgets, a logical widget cannot receive focus whereas a non-logical one can.
/// (Since EFL 1.22)</summary>
[IManagerNativeInherit]
public interface IManager : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// (Since EFL 1.22)</summary>
/// <returns>Currently focused element.</returns>
Efl.Ui.Focus.IObject GetManagerFocus();
    /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// (Since EFL 1.22)</summary>
/// <param name="focus">Currently focused element.</param>
/// <returns></returns>
void SetManagerFocus( Efl.Ui.Focus.IObject focus);
    /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// (Since EFL 1.22)</summary>
/// <returns>The redirect manager.</returns>
Efl.Ui.Focus.IManager GetRedirect();
    /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// (Since EFL 1.22)</summary>
/// <param name="redirect">The redirect manager.</param>
/// <returns></returns>
void SetRedirect( Efl.Ui.Focus.IManager redirect);
    /// <summary>The list of elements which are at the border of the graph.
/// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.IManager.Move"/>
/// (Since EFL 1.22)</summary>
/// <returns>An iterator over the border objects.</returns>
Eina.Iterator<Efl.Ui.Focus.IObject> GetBorderElements();
    /// <summary>Get all elements that are at the border of the viewport
/// Every element returned by this is located inside the viewport rectangle, but has a right, left, down or up neighbor outside the viewport.
/// (Since EFL 1.22)</summary>
/// <param name="viewport">The rectangle defining the viewport.</param>
/// <returns>The list of border objects.</returns>
Eina.Iterator<Efl.Ui.Focus.IObject> GetViewportElements( Eina.Rect viewport);
    /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// (Since EFL 1.22)</summary>
/// <returns>Will be registered into this manager object.</returns>
Efl.Ui.Focus.IObject GetRoot();
    /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// (Since EFL 1.22)</summary>
/// <param name="root">Will be registered into this manager object.</param>
/// <returns>If <c>true</c>, this is the root node</returns>
bool SetRoot( Efl.Ui.Focus.IObject root);
    /// <summary>Move the focus in the given direction.
/// This call flushes all changes. This means all changes between the last flush and now are computed.
/// (Since EFL 1.22)</summary>
/// <param name="direction">The direction to move to.</param>
/// <returns>The element which is now focused.</returns>
Efl.Ui.Focus.IObject Move( Efl.Ui.Focus.Direction direction);
    /// <summary>Return the object in the <c>direction</c> from <c>child</c>.
/// (Since EFL 1.22)</summary>
/// <param name="direction">Direction to move focus.</param>
/// <param name="child">The child to move from. Pass <c>null</c> to indicate the currently focused child.</param>
/// <param name="logical">Wether you want to have a logical node as result or a non-logical. Note, in a <see cref="Efl.Ui.Focus.IManager.Move"/> call no logical node will get focus.</param>
/// <returns>Object that would receive focus if moved in the given direction.</returns>
Efl.Ui.Focus.IObject MoveRequest( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject child,  bool logical);
    /// <summary>Return the widget in the direction next.
/// The returned widget is a child of <c>root</c>. It&apos;s guaranteed that child will not be prepared once again, so you can call this function inside a <see cref="Efl.Ui.Focus.IObject.SetupOrder"/> call.
/// (Since EFL 1.22)</summary>
/// <param name="root">Parent for returned child.</param>
/// <returns>Child of passed parameter.</returns>
Efl.Ui.Focus.IObject RequestSubchild( Efl.Ui.Focus.IObject root);
    /// <summary>This will fetch the data from a registered node.
/// Be aware this function will trigger a computation of all dirty nodes.
/// (Since EFL 1.22)</summary>
/// <param name="child">The child object to inspect.</param>
/// <returns>The list of relations starting from <c>child</c>.</returns>
Efl.Ui.Focus.Relations Fetch( Efl.Ui.Focus.IObject child);
    /// <summary>Return the last logical object.
/// The returned object is the last object that would be returned if you start at the root and move the direction into next.
/// (Since EFL 1.22)</summary>
/// <returns>Last object.</returns>
Efl.Ui.Focus.ManagerLogicalEndDetail LogicalEnd();
    /// <summary>Reset the history stack of this manager object. This means the uppermost element will be unfocused, and all other elements will be removed from the remembered list.
/// You should focus another element immediately after calling this, in order to always have a focused object.
/// (Since EFL 1.22)</summary>
/// <returns></returns>
void ResetHistory();
    /// <summary>Remove the uppermost history element, and focus the previous one.
/// If there is an element that was focused before, it will be used. Otherwise, the best fitting element from the registered elements will be focused.
/// (Since EFL 1.22)</summary>
/// <returns></returns>
void PopHistoryStack();
    /// <summary>Called when this manager is set as redirect.
/// In case that this is called as an result of a move call, <c>direction</c> and <c>entry</c> will be set to the direction of the move call, and the <c>entry</c> object will be set to the object that had this manager as redirect property.
/// (Since EFL 1.22)</summary>
/// <param name="direction">The direction in which this should be setup.</param>
/// <param name="entry">The object that caused this manager to be redirect.</param>
/// <returns></returns>
void SetupOnFirstTouch( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject entry);
    /// <summary>This disables the cache invalidation when an object is moved.
/// Even if an object is moved, the focus manager will not recalculate its relations. This can be used when you know that the set of widgets in the focus manager is moved the same way, so the relations between the widets in the set do not change and the complex calculations can be avoided. Use <see cref="Efl.Ui.Focus.IManager.DirtyLogicUnfreeze"/> to re-enable relationship calculation.
/// (Since EFL 1.22)</summary>
/// <returns></returns>
void FreezeDirtyLogic();
    /// <summary>This enables the cache invalidation when an object is moved.
/// This is the counterpart to <see cref="Efl.Ui.Focus.IManager.FreezeDirtyLogic"/>.
/// (Since EFL 1.22)</summary>
/// <returns></returns>
void DirtyLogicUnfreeze();
                                                                            /// <summary>Redirect object has changed, the old manager is passed as an event argument.
    /// (Since EFL 1.22)</summary>
    event EventHandler<Efl.Ui.Focus.IManagerRedirectChangedEvt_Args> RedirectChangedEvt;
    /// <summary>After this event, the manager object will calculate relations in the graph. Can be used to add / remove children in a lazy fashion.
    /// (Since EFL 1.22)</summary>
    event EventHandler FlushPreEvt;
    /// <summary>Cached relationship calculation results have been invalidated.
    /// (Since EFL 1.22)</summary>
    event EventHandler CoordsDirtyEvt;
    /// <summary>The manager_focus property has changed. The previously focused object is passed as an event argument.
    /// (Since EFL 1.22)</summary>
    event EventHandler<Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args> ManagerFocusChangedEvt;
    /// <summary>Called when this focus manager is frozen or thawed, even_info being <c>true</c> indicates that it is now frozen, <c>false</c> indicates that it is thawed.
    /// (Since EFL 1.22)</summary>
    event EventHandler<Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args> DirtyLogicFreezeChangedEvt;
    /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// (Since EFL 1.22)</summary>
/// <value>Currently focused element.</value>
    Efl.Ui.Focus.IObject ManagerFocus {
        get ;
        set ;
    }
    /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// (Since EFL 1.22)</summary>
/// <value>The redirect manager.</value>
    Efl.Ui.Focus.IManager Redirect {
        get ;
        set ;
    }
    /// <summary>The list of elements which are at the border of the graph.
/// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.IManager.Move"/>
/// (Since EFL 1.22)</summary>
/// <value>An iterator over the border objects.</value>
    Eina.Iterator<Efl.Ui.Focus.IObject> BorderElements {
        get ;
    }
    /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// (Since EFL 1.22)</summary>
/// <value>Will be registered into this manager object.</value>
    Efl.Ui.Focus.IObject Root {
        get ;
        set ;
    }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Focus.IManager.RedirectChangedEvt"/>.</summary>
public class IManagerRedirectChangedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.Focus.IManager arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Focus.IManager.ManagerFocusChangedEvt"/>.</summary>
public class IManagerManagerFocusChangedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.Focus.IObject arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Focus.IManager.DirtyLogicFreezeChangedEvt"/>.</summary>
public class IManagerDirtyLogicFreezeChangedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public bool arg { get; set; }
}
/// <summary>Interface for managing focus objects
/// This interface is built in order to support movement of the focus property in a set of widgets. The movement of the focus property can happen in a tree manner, or a graph manner. The movement is also keeping track of the history of focused elements. The tree interpretation differentiates between logical and non-logical widgets, a logical widget cannot receive focus whereas a non-logical one can.
/// (Since EFL 1.22)</summary>
sealed public class IManagerConcrete : 

IManager
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (IManagerConcrete))
                return Efl.Ui.Focus.IManagerNativeInherit.GetEflClassStatic();
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
    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_focus_manager_interface_get();
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    private IManagerConcrete(System.IntPtr raw)
    {
        handle = raw;
        RegisterEventProxies();
    }
    ///<summary>Destructor.</summary>
    ~IManagerConcrete()
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
            IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
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
private static object RedirectChangedEvtKey = new object();
    /// <summary>Redirect object has changed, the old manager is passed as an event argument.
    /// (Since EFL 1.22)</summary>
    public event EventHandler<Efl.Ui.Focus.IManagerRedirectChangedEvt_Args> RedirectChangedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
                if (AddNativeEventHandler(efl.Libs.Elementary, key, this.evt_RedirectChangedEvt_delegate)) {
                    eventHandlers.AddHandler(RedirectChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
                if (RemoveNativeEventHandler(key, this.evt_RedirectChangedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(RedirectChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event RedirectChangedEvt.</summary>
    public void On_RedirectChangedEvt(Efl.Ui.Focus.IManagerRedirectChangedEvt_Args e)
    {
        EventHandler<Efl.Ui.Focus.IManagerRedirectChangedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.Focus.IManagerRedirectChangedEvt_Args>)eventHandlers[RedirectChangedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_RedirectChangedEvt_delegate;
    private void on_RedirectChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.Focus.IManagerRedirectChangedEvt_Args args = new Efl.Ui.Focus.IManagerRedirectChangedEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Ui.Focus.IManagerConcrete);
        try {
            On_RedirectChangedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object FlushPreEvtKey = new object();
    /// <summary>After this event, the manager object will calculate relations in the graph. Can be used to add / remove children in a lazy fashion.
    /// (Since EFL 1.22)</summary>
    public event EventHandler FlushPreEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
                if (AddNativeEventHandler(efl.Libs.Elementary, key, this.evt_FlushPreEvt_delegate)) {
                    eventHandlers.AddHandler(FlushPreEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
                if (RemoveNativeEventHandler(key, this.evt_FlushPreEvt_delegate)) { 
                    eventHandlers.RemoveHandler(FlushPreEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event FlushPreEvt.</summary>
    public void On_FlushPreEvt(EventArgs e)
    {
        EventHandler evt;
        lock (eventLock) {
        evt = (EventHandler)eventHandlers[FlushPreEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_FlushPreEvt_delegate;
    private void on_FlushPreEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        EventArgs args = EventArgs.Empty;
        try {
            On_FlushPreEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object CoordsDirtyEvtKey = new object();
    /// <summary>Cached relationship calculation results have been invalidated.
    /// (Since EFL 1.22)</summary>
    public event EventHandler CoordsDirtyEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
                if (AddNativeEventHandler(efl.Libs.Elementary, key, this.evt_CoordsDirtyEvt_delegate)) {
                    eventHandlers.AddHandler(CoordsDirtyEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
                if (RemoveNativeEventHandler(key, this.evt_CoordsDirtyEvt_delegate)) { 
                    eventHandlers.RemoveHandler(CoordsDirtyEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event CoordsDirtyEvt.</summary>
    public void On_CoordsDirtyEvt(EventArgs e)
    {
        EventHandler evt;
        lock (eventLock) {
        evt = (EventHandler)eventHandlers[CoordsDirtyEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_CoordsDirtyEvt_delegate;
    private void on_CoordsDirtyEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        EventArgs args = EventArgs.Empty;
        try {
            On_CoordsDirtyEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object ManagerFocusChangedEvtKey = new object();
    /// <summary>The manager_focus property has changed. The previously focused object is passed as an event argument.
    /// (Since EFL 1.22)</summary>
    public event EventHandler<Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args> ManagerFocusChangedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
                if (AddNativeEventHandler(efl.Libs.Elementary, key, this.evt_ManagerFocusChangedEvt_delegate)) {
                    eventHandlers.AddHandler(ManagerFocusChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
                if (RemoveNativeEventHandler(key, this.evt_ManagerFocusChangedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(ManagerFocusChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event ManagerFocusChangedEvt.</summary>
    public void On_ManagerFocusChangedEvt(Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args e)
    {
        EventHandler<Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args>)eventHandlers[ManagerFocusChangedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_ManagerFocusChangedEvt_delegate;
    private void on_ManagerFocusChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args args = new Efl.Ui.Focus.IManagerManagerFocusChangedEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Ui.Focus.IObjectConcrete);
        try {
            On_ManagerFocusChangedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

private static object DirtyLogicFreezeChangedEvtKey = new object();
    /// <summary>Called when this focus manager is frozen or thawed, even_info being <c>true</c> indicates that it is now frozen, <c>false</c> indicates that it is thawed.
    /// (Since EFL 1.22)</summary>
    public event EventHandler<Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args> DirtyLogicFreezeChangedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
                if (AddNativeEventHandler(efl.Libs.Elementary, key, this.evt_DirtyLogicFreezeChangedEvt_delegate)) {
                    eventHandlers.AddHandler(DirtyLogicFreezeChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
                if (RemoveNativeEventHandler(key, this.evt_DirtyLogicFreezeChangedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(DirtyLogicFreezeChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event DirtyLogicFreezeChangedEvt.</summary>
    public void On_DirtyLogicFreezeChangedEvt(Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args e)
    {
        EventHandler<Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args>)eventHandlers[DirtyLogicFreezeChangedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_DirtyLogicFreezeChangedEvt_delegate;
    private void on_DirtyLogicFreezeChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args args = new Efl.Ui.Focus.IManagerDirtyLogicFreezeChangedEvt_Args();
      args.arg = evt.Info != IntPtr.Zero;
        try {
            On_DirtyLogicFreezeChangedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
     void RegisterEventProxies()
    {
        evt_RedirectChangedEvt_delegate = new Efl.EventCb(on_RedirectChangedEvt_NativeCallback);
        evt_FlushPreEvt_delegate = new Efl.EventCb(on_FlushPreEvt_NativeCallback);
        evt_CoordsDirtyEvt_delegate = new Efl.EventCb(on_CoordsDirtyEvt_NativeCallback);
        evt_ManagerFocusChangedEvt_delegate = new Efl.EventCb(on_ManagerFocusChangedEvt_NativeCallback);
        evt_DirtyLogicFreezeChangedEvt_delegate = new Efl.EventCb(on_DirtyLogicFreezeChangedEvt_NativeCallback);
    }
    /// <summary>The element which is currently focused by this manager
    /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
    /// (Since EFL 1.22)</summary>
    /// <returns>Currently focused element.</returns>
    public Efl.Ui.Focus.IObject GetManagerFocus() {
         var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_focus_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The element which is currently focused by this manager
    /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
    /// (Since EFL 1.22)</summary>
    /// <param name="focus">Currently focused element.</param>
    /// <returns></returns>
    public void SetManagerFocus( Efl.Ui.Focus.IObject focus) {
                                 Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_focus_set_ptr.Value.Delegate(this.NativeHandle, focus);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Add another manager to serve the move requests.
    /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
    /// (Since EFL 1.22)</summary>
    /// <returns>The redirect manager.</returns>
    public Efl.Ui.Focus.IManager GetRedirect() {
         var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_redirect_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Add another manager to serve the move requests.
    /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
    /// (Since EFL 1.22)</summary>
    /// <param name="redirect">The redirect manager.</param>
    /// <returns></returns>
    public void SetRedirect( Efl.Ui.Focus.IManager redirect) {
                                 Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_redirect_set_ptr.Value.Delegate(this.NativeHandle, redirect);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The list of elements which are at the border of the graph.
    /// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.IManager.Move"/>
    /// (Since EFL 1.22)</summary>
    /// <returns>An iterator over the border objects.</returns>
    public Eina.Iterator<Efl.Ui.Focus.IObject> GetBorderElements() {
         var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return new Eina.Iterator<Efl.Ui.Focus.IObject>(_ret_var, false, false);
 }
    /// <summary>Get all elements that are at the border of the viewport
    /// Every element returned by this is located inside the viewport rectangle, but has a right, left, down or up neighbor outside the viewport.
    /// (Since EFL 1.22)</summary>
    /// <param name="viewport">The rectangle defining the viewport.</param>
    /// <returns>The list of border objects.</returns>
    public Eina.Iterator<Efl.Ui.Focus.IObject> GetViewportElements( Eina.Rect viewport) {
         Eina.Rect.NativeStruct _in_viewport = viewport;
                        var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate(this.NativeHandle, _in_viewport);
        Eina.Error.RaiseIfUnhandledException();
                        return new Eina.Iterator<Efl.Ui.Focus.IObject>(_ret_var, false, false);
 }
    /// <summary>Root node for all logical subtrees.
    /// This property can only be set once.
    /// (Since EFL 1.22)</summary>
    /// <returns>Will be registered into this manager object.</returns>
    public Efl.Ui.Focus.IObject GetRoot() {
         var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_root_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Root node for all logical subtrees.
    /// This property can only be set once.
    /// (Since EFL 1.22)</summary>
    /// <param name="root">Will be registered into this manager object.</param>
    /// <returns>If <c>true</c>, this is the root node</returns>
    public bool SetRoot( Efl.Ui.Focus.IObject root) {
                                 var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_root_set_ptr.Value.Delegate(this.NativeHandle, root);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Move the focus in the given direction.
    /// This call flushes all changes. This means all changes between the last flush and now are computed.
    /// (Since EFL 1.22)</summary>
    /// <param name="direction">The direction to move to.</param>
    /// <returns>The element which is now focused.</returns>
    public Efl.Ui.Focus.IObject Move( Efl.Ui.Focus.Direction direction) {
                                 var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_move_ptr.Value.Delegate(this.NativeHandle, direction);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Return the object in the <c>direction</c> from <c>child</c>.
    /// (Since EFL 1.22)</summary>
    /// <param name="direction">Direction to move focus.</param>
    /// <param name="child">The child to move from. Pass <c>null</c> to indicate the currently focused child.</param>
    /// <param name="logical">Wether you want to have a logical node as result or a non-logical. Note, in a <see cref="Efl.Ui.Focus.IManager.Move"/> call no logical node will get focus.</param>
    /// <returns>Object that would receive focus if moved in the given direction.</returns>
    public Efl.Ui.Focus.IObject MoveRequest( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject child,  bool logical) {
                                                                                 var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_request_move_ptr.Value.Delegate(this.NativeHandle, direction,  child,  logical);
        Eina.Error.RaiseIfUnhandledException();
                                                        return _ret_var;
 }
    /// <summary>Return the widget in the direction next.
    /// The returned widget is a child of <c>root</c>. It&apos;s guaranteed that child will not be prepared once again, so you can call this function inside a <see cref="Efl.Ui.Focus.IObject.SetupOrder"/> call.
    /// (Since EFL 1.22)</summary>
    /// <param name="root">Parent for returned child.</param>
    /// <returns>Child of passed parameter.</returns>
    public Efl.Ui.Focus.IObject RequestSubchild( Efl.Ui.Focus.IObject root) {
                                 var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_request_subchild_ptr.Value.Delegate(this.NativeHandle, root);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>This will fetch the data from a registered node.
    /// Be aware this function will trigger a computation of all dirty nodes.
    /// (Since EFL 1.22)</summary>
    /// <param name="child">The child object to inspect.</param>
    /// <returns>The list of relations starting from <c>child</c>.</returns>
    public Efl.Ui.Focus.Relations Fetch( Efl.Ui.Focus.IObject child) {
                                 var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_fetch_ptr.Value.Delegate(this.NativeHandle, child);
        Eina.Error.RaiseIfUnhandledException();
                        var __ret_tmp = Eina.PrimitiveConversion.PointerToManaged<Efl.Ui.Focus.Relations>(_ret_var);
        Marshal.FreeHGlobal(_ret_var);
        return __ret_tmp;
 }
    /// <summary>Return the last logical object.
    /// The returned object is the last object that would be returned if you start at the root and move the direction into next.
    /// (Since EFL 1.22)</summary>
    /// <returns>Last object.</returns>
    public Efl.Ui.Focus.ManagerLogicalEndDetail LogicalEnd() {
         var _ret_var = Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_logical_end_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Reset the history stack of this manager object. This means the uppermost element will be unfocused, and all other elements will be removed from the remembered list.
    /// You should focus another element immediately after calling this, in order to always have a focused object.
    /// (Since EFL 1.22)</summary>
    /// <returns></returns>
    public void ResetHistory() {
         Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_reset_history_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>Remove the uppermost history element, and focus the previous one.
    /// If there is an element that was focused before, it will be used. Otherwise, the best fitting element from the registered elements will be focused.
    /// (Since EFL 1.22)</summary>
    /// <returns></returns>
    public void PopHistoryStack() {
         Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>Called when this manager is set as redirect.
    /// In case that this is called as an result of a move call, <c>direction</c> and <c>entry</c> will be set to the direction of the move call, and the <c>entry</c> object will be set to the object that had this manager as redirect property.
    /// (Since EFL 1.22)</summary>
    /// <param name="direction">The direction in which this should be setup.</param>
    /// <param name="entry">The object that caused this manager to be redirect.</param>
    /// <returns></returns>
    public void SetupOnFirstTouch( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject entry) {
                                                         Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate(this.NativeHandle, direction,  entry);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>This disables the cache invalidation when an object is moved.
    /// Even if an object is moved, the focus manager will not recalculate its relations. This can be used when you know that the set of widgets in the focus manager is moved the same way, so the relations between the widets in the set do not change and the complex calculations can be avoided. Use <see cref="Efl.Ui.Focus.IManager.DirtyLogicUnfreeze"/> to re-enable relationship calculation.
    /// (Since EFL 1.22)</summary>
    /// <returns></returns>
    public void FreezeDirtyLogic() {
         Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>This enables the cache invalidation when an object is moved.
    /// This is the counterpart to <see cref="Efl.Ui.Focus.IManager.FreezeDirtyLogic"/>.
    /// (Since EFL 1.22)</summary>
    /// <returns></returns>
    public void DirtyLogicUnfreeze() {
         Efl.Ui.Focus.IManagerNativeInherit.efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// (Since EFL 1.22)</summary>
/// <value>Currently focused element.</value>
    public Efl.Ui.Focus.IObject ManagerFocus {
        get { return GetManagerFocus(); }
        set { SetManagerFocus( value); }
    }
    /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// (Since EFL 1.22)</summary>
/// <value>The redirect manager.</value>
    public Efl.Ui.Focus.IManager Redirect {
        get { return GetRedirect(); }
        set { SetRedirect( value); }
    }
    /// <summary>The list of elements which are at the border of the graph.
/// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.IManager.Move"/>
/// (Since EFL 1.22)</summary>
/// <value>An iterator over the border objects.</value>
    public Eina.Iterator<Efl.Ui.Focus.IObject> BorderElements {
        get { return GetBorderElements(); }
    }
    /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// (Since EFL 1.22)</summary>
/// <value>Will be registered into this manager object.</value>
    public Efl.Ui.Focus.IObject Root {
        get { return GetRoot(); }
        set { SetRoot( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.Focus.IManagerConcrete.efl_ui_focus_manager_interface_get();
    }
}
public class IManagerNativeInherit  : Efl.Eo.NativeClass{
    public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_ui_focus_manager_focus_get_static_delegate == null)
            efl_ui_focus_manager_focus_get_static_delegate = new efl_ui_focus_manager_focus_get_delegate(manager_focus_get);
        if (methods.FirstOrDefault(m => m.Name == "GetManagerFocus") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_get_static_delegate)});
        if (efl_ui_focus_manager_focus_set_static_delegate == null)
            efl_ui_focus_manager_focus_set_static_delegate = new efl_ui_focus_manager_focus_set_delegate(manager_focus_set);
        if (methods.FirstOrDefault(m => m.Name == "SetManagerFocus") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_set_static_delegate)});
        if (efl_ui_focus_manager_redirect_get_static_delegate == null)
            efl_ui_focus_manager_redirect_get_static_delegate = new efl_ui_focus_manager_redirect_get_delegate(redirect_get);
        if (methods.FirstOrDefault(m => m.Name == "GetRedirect") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_get_static_delegate)});
        if (efl_ui_focus_manager_redirect_set_static_delegate == null)
            efl_ui_focus_manager_redirect_set_static_delegate = new efl_ui_focus_manager_redirect_set_delegate(redirect_set);
        if (methods.FirstOrDefault(m => m.Name == "SetRedirect") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_set_static_delegate)});
        if (efl_ui_focus_manager_border_elements_get_static_delegate == null)
            efl_ui_focus_manager_border_elements_get_static_delegate = new efl_ui_focus_manager_border_elements_get_delegate(border_elements_get);
        if (methods.FirstOrDefault(m => m.Name == "GetBorderElements") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_border_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_border_elements_get_static_delegate)});
        if (efl_ui_focus_manager_viewport_elements_get_static_delegate == null)
            efl_ui_focus_manager_viewport_elements_get_static_delegate = new efl_ui_focus_manager_viewport_elements_get_delegate(viewport_elements_get);
        if (methods.FirstOrDefault(m => m.Name == "GetViewportElements") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_viewport_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_viewport_elements_get_static_delegate)});
        if (efl_ui_focus_manager_root_get_static_delegate == null)
            efl_ui_focus_manager_root_get_static_delegate = new efl_ui_focus_manager_root_get_delegate(root_get);
        if (methods.FirstOrDefault(m => m.Name == "GetRoot") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_get_static_delegate)});
        if (efl_ui_focus_manager_root_set_static_delegate == null)
            efl_ui_focus_manager_root_set_static_delegate = new efl_ui_focus_manager_root_set_delegate(root_set);
        if (methods.FirstOrDefault(m => m.Name == "SetRoot") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_set_static_delegate)});
        if (efl_ui_focus_manager_move_static_delegate == null)
            efl_ui_focus_manager_move_static_delegate = new efl_ui_focus_manager_move_delegate(move);
        if (methods.FirstOrDefault(m => m.Name == "Move") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_move_static_delegate)});
        if (efl_ui_focus_manager_request_move_static_delegate == null)
            efl_ui_focus_manager_request_move_static_delegate = new efl_ui_focus_manager_request_move_delegate(request_move);
        if (methods.FirstOrDefault(m => m.Name == "MoveRequest") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_move_static_delegate)});
        if (efl_ui_focus_manager_request_subchild_static_delegate == null)
            efl_ui_focus_manager_request_subchild_static_delegate = new efl_ui_focus_manager_request_subchild_delegate(request_subchild);
        if (methods.FirstOrDefault(m => m.Name == "RequestSubchild") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_subchild"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_subchild_static_delegate)});
        if (efl_ui_focus_manager_fetch_static_delegate == null)
            efl_ui_focus_manager_fetch_static_delegate = new efl_ui_focus_manager_fetch_delegate(fetch);
        if (methods.FirstOrDefault(m => m.Name == "Fetch") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_fetch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_fetch_static_delegate)});
        if (efl_ui_focus_manager_logical_end_static_delegate == null)
            efl_ui_focus_manager_logical_end_static_delegate = new efl_ui_focus_manager_logical_end_delegate(logical_end);
        if (methods.FirstOrDefault(m => m.Name == "LogicalEnd") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_logical_end"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_logical_end_static_delegate)});
        if (efl_ui_focus_manager_reset_history_static_delegate == null)
            efl_ui_focus_manager_reset_history_static_delegate = new efl_ui_focus_manager_reset_history_delegate(reset_history);
        if (methods.FirstOrDefault(m => m.Name == "ResetHistory") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_reset_history"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_reset_history_static_delegate)});
        if (efl_ui_focus_manager_pop_history_stack_static_delegate == null)
            efl_ui_focus_manager_pop_history_stack_static_delegate = new efl_ui_focus_manager_pop_history_stack_delegate(pop_history_stack);
        if (methods.FirstOrDefault(m => m.Name == "PopHistoryStack") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_pop_history_stack"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_pop_history_stack_static_delegate)});
        if (efl_ui_focus_manager_setup_on_first_touch_static_delegate == null)
            efl_ui_focus_manager_setup_on_first_touch_static_delegate = new efl_ui_focus_manager_setup_on_first_touch_delegate(setup_on_first_touch);
        if (methods.FirstOrDefault(m => m.Name == "SetupOnFirstTouch") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_setup_on_first_touch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_setup_on_first_touch_static_delegate)});
        if (efl_ui_focus_manager_dirty_logic_freeze_static_delegate == null)
            efl_ui_focus_manager_dirty_logic_freeze_static_delegate = new efl_ui_focus_manager_dirty_logic_freeze_delegate(dirty_logic_freeze);
        if (methods.FirstOrDefault(m => m.Name == "FreezeDirtyLogic") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_freeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_freeze_static_delegate)});
        if (efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate == null)
            efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate = new efl_ui_focus_manager_dirty_logic_unfreeze_delegate(dirty_logic_unfreeze);
        if (methods.FirstOrDefault(m => m.Name == "DirtyLogicUnfreeze") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_unfreeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate)});
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.Ui.Focus.IManagerConcrete.efl_ui_focus_manager_interface_get();
    }
    public static  IntPtr GetEflClassStatic()
    {
        return Efl.Ui.Focus.IManagerConcrete.efl_ui_focus_manager_interface_get();
    }


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_focus_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_focus_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate> efl_ui_focus_manager_focus_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate>(_Module, "efl_ui_focus_manager_focus_get");
     private static Efl.Ui.Focus.IObject manager_focus_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_focus_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Ui.Focus.IObject _ret_var = default(Efl.Ui.Focus.IObject);
            try {
                _ret_var = ((IManager)wrapper).GetManagerFocus();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_focus_manager_focus_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_focus_get_delegate efl_ui_focus_manager_focus_get_static_delegate;


     private delegate void efl_ui_focus_manager_focus_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject focus);


     public delegate void efl_ui_focus_manager_focus_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject focus);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate> efl_ui_focus_manager_focus_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate>(_Module, "efl_ui_focus_manager_focus_set");
     private static void manager_focus_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.IObject focus)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_focus_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((IManager)wrapper).SetManagerFocus( focus);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_ui_focus_manager_focus_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  focus);
        }
    }
    private static efl_ui_focus_manager_focus_set_delegate efl_ui_focus_manager_focus_set_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IManagerConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IManager efl_ui_focus_manager_redirect_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IManagerConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IManager efl_ui_focus_manager_redirect_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate> efl_ui_focus_manager_redirect_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate>(_Module, "efl_ui_focus_manager_redirect_get");
     private static Efl.Ui.Focus.IManager redirect_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_redirect_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Ui.Focus.IManager _ret_var = default(Efl.Ui.Focus.IManager);
            try {
                _ret_var = ((IManager)wrapper).GetRedirect();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_focus_manager_redirect_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_redirect_get_delegate efl_ui_focus_manager_redirect_get_static_delegate;


     private delegate void efl_ui_focus_manager_redirect_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IManager redirect);


     public delegate void efl_ui_focus_manager_redirect_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IManager redirect);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate> efl_ui_focus_manager_redirect_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate>(_Module, "efl_ui_focus_manager_redirect_set");
     private static void redirect_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.IManager redirect)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_redirect_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((IManager)wrapper).SetRedirect( redirect);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_ui_focus_manager_redirect_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  redirect);
        }
    }
    private static efl_ui_focus_manager_redirect_set_delegate efl_ui_focus_manager_redirect_set_static_delegate;


     private delegate System.IntPtr efl_ui_focus_manager_border_elements_get_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate System.IntPtr efl_ui_focus_manager_border_elements_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate> efl_ui_focus_manager_border_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_border_elements_get");
     private static System.IntPtr border_elements_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_border_elements_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Eina.Iterator<Efl.Ui.Focus.IObject> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.IObject>);
            try {
                _ret_var = ((IManager)wrapper).GetBorderElements();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var.Handle;
        } else {
            return efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_border_elements_get_delegate efl_ui_focus_manager_border_elements_get_static_delegate;


     private delegate System.IntPtr efl_ui_focus_manager_viewport_elements_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect.NativeStruct viewport);


     public delegate System.IntPtr efl_ui_focus_manager_viewport_elements_get_api_delegate(System.IntPtr obj,   Eina.Rect.NativeStruct viewport);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate> efl_ui_focus_manager_viewport_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_viewport_elements_get");
     private static System.IntPtr viewport_elements_get(System.IntPtr obj, System.IntPtr pd,  Eina.Rect.NativeStruct viewport)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_viewport_elements_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                    Eina.Rect _in_viewport = viewport;
                            Eina.Iterator<Efl.Ui.Focus.IObject> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.IObject>);
            try {
                _ret_var = ((IManager)wrapper).GetViewportElements( _in_viewport);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var.Handle;
        } else {
            return efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  viewport);
        }
    }
    private static efl_ui_focus_manager_viewport_elements_get_delegate efl_ui_focus_manager_viewport_elements_get_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_root_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_root_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate> efl_ui_focus_manager_root_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate>(_Module, "efl_ui_focus_manager_root_get");
     private static Efl.Ui.Focus.IObject root_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_root_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Ui.Focus.IObject _ret_var = default(Efl.Ui.Focus.IObject);
            try {
                _ret_var = ((IManager)wrapper).GetRoot();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_focus_manager_root_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_root_get_delegate efl_ui_focus_manager_root_get_static_delegate;


     [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_focus_manager_root_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject root);


     [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_focus_manager_root_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject root);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate> efl_ui_focus_manager_root_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate>(_Module, "efl_ui_focus_manager_root_set");
     private static bool root_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.IObject root)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_root_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                bool _ret_var = default(bool);
            try {
                _ret_var = ((IManager)wrapper).SetRoot( root);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var;
        } else {
            return efl_ui_focus_manager_root_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
        }
    }
    private static efl_ui_focus_manager_root_set_delegate efl_ui_focus_manager_root_set_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate> efl_ui_focus_manager_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate>(_Module, "efl_ui_focus_manager_move");
     private static Efl.Ui.Focus.IObject move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_move was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                Efl.Ui.Focus.IObject _ret_var = default(Efl.Ui.Focus.IObject);
            try {
                _ret_var = ((IManager)wrapper).Move( direction);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var;
        } else {
            return efl_ui_focus_manager_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction);
        }
    }
    private static efl_ui_focus_manager_move_delegate efl_ui_focus_manager_move_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_request_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject child,  [MarshalAs(UnmanagedType.U1)]  bool logical);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_request_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject child,  [MarshalAs(UnmanagedType.U1)]  bool logical);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate> efl_ui_focus_manager_request_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate>(_Module, "efl_ui_focus_manager_request_move");
     private static Efl.Ui.Focus.IObject request_move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject child,  bool logical)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_request_move was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                                                Efl.Ui.Focus.IObject _ret_var = default(Efl.Ui.Focus.IObject);
            try {
                _ret_var = ((IManager)wrapper).MoveRequest( direction,  child,  logical);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                                        return _ret_var;
        } else {
            return efl_ui_focus_manager_request_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  child,  logical);
        }
    }
    private static efl_ui_focus_manager_request_move_delegate efl_ui_focus_manager_request_move_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_request_subchild_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject root);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.IObject efl_ui_focus_manager_request_subchild_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject root);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate> efl_ui_focus_manager_request_subchild_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate>(_Module, "efl_ui_focus_manager_request_subchild");
     private static Efl.Ui.Focus.IObject request_subchild(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.IObject root)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_request_subchild was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                Efl.Ui.Focus.IObject _ret_var = default(Efl.Ui.Focus.IObject);
            try {
                _ret_var = ((IManager)wrapper).RequestSubchild( root);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var;
        } else {
            return efl_ui_focus_manager_request_subchild_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
        }
    }
    private static efl_ui_focus_manager_request_subchild_delegate efl_ui_focus_manager_request_subchild_static_delegate;


     private delegate System.IntPtr efl_ui_focus_manager_fetch_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject child);


     public delegate System.IntPtr efl_ui_focus_manager_fetch_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject child);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate> efl_ui_focus_manager_fetch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate>(_Module, "efl_ui_focus_manager_fetch");
     private static System.IntPtr fetch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.IObject child)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_fetch was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                Efl.Ui.Focus.Relations _ret_var = default(Efl.Ui.Focus.Relations);
            try {
                _ret_var = ((IManager)wrapper).Fetch( child);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return Eina.PrimitiveConversion.ManagedToPointerAlloc(_ret_var);
        } else {
            return efl_ui_focus_manager_fetch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  child);
        }
    }
    private static efl_ui_focus_manager_fetch_delegate efl_ui_focus_manager_fetch_static_delegate;


     private delegate Efl.Ui.Focus.ManagerLogicalEndDetail.NativeStruct efl_ui_focus_manager_logical_end_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate Efl.Ui.Focus.ManagerLogicalEndDetail.NativeStruct efl_ui_focus_manager_logical_end_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate> efl_ui_focus_manager_logical_end_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate>(_Module, "efl_ui_focus_manager_logical_end");
     private static Efl.Ui.Focus.ManagerLogicalEndDetail.NativeStruct logical_end(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_logical_end was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Ui.Focus.ManagerLogicalEndDetail _ret_var = default(Efl.Ui.Focus.ManagerLogicalEndDetail);
            try {
                _ret_var = ((IManager)wrapper).LogicalEnd();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_ui_focus_manager_logical_end_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_logical_end_delegate efl_ui_focus_manager_logical_end_static_delegate;


     private delegate void efl_ui_focus_manager_reset_history_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate void efl_ui_focus_manager_reset_history_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate> efl_ui_focus_manager_reset_history_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate>(_Module, "efl_ui_focus_manager_reset_history");
     private static void reset_history(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_reset_history was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        
            try {
                ((IManager)wrapper).ResetHistory();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                } else {
            efl_ui_focus_manager_reset_history_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_reset_history_delegate efl_ui_focus_manager_reset_history_static_delegate;


     private delegate void efl_ui_focus_manager_pop_history_stack_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate void efl_ui_focus_manager_pop_history_stack_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate> efl_ui_focus_manager_pop_history_stack_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate>(_Module, "efl_ui_focus_manager_pop_history_stack");
     private static void pop_history_stack(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_pop_history_stack was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        
            try {
                ((IManager)wrapper).PopHistoryStack();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                } else {
            efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_pop_history_stack_delegate efl_ui_focus_manager_pop_history_stack_static_delegate;


     private delegate void efl_ui_focus_manager_setup_on_first_touch_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject entry);


     public delegate void efl_ui_focus_manager_setup_on_first_touch_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.IObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.IObject entry);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate> efl_ui_focus_manager_setup_on_first_touch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate>(_Module, "efl_ui_focus_manager_setup_on_first_touch");
     private static void setup_on_first_touch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.IObject entry)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_setup_on_first_touch was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                        
            try {
                ((IManager)wrapper).SetupOnFirstTouch( direction,  entry);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                                } else {
            efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  entry);
        }
    }
    private static efl_ui_focus_manager_setup_on_first_touch_delegate efl_ui_focus_manager_setup_on_first_touch_static_delegate;


     private delegate void efl_ui_focus_manager_dirty_logic_freeze_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate void efl_ui_focus_manager_dirty_logic_freeze_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate> efl_ui_focus_manager_dirty_logic_freeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_freeze");
     private static void dirty_logic_freeze(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_freeze was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        
            try {
                ((IManager)wrapper).FreezeDirtyLogic();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                } else {
            efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_dirty_logic_freeze_delegate efl_ui_focus_manager_dirty_logic_freeze_static_delegate;


     private delegate void efl_ui_focus_manager_dirty_logic_unfreeze_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate void efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate> efl_ui_focus_manager_dirty_logic_unfreeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_unfreeze");
     private static void dirty_logic_unfreeze(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_unfreeze was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        
            try {
                ((IManager)wrapper).DirtyLogicUnfreeze();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                } else {
            efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_focus_manager_dirty_logic_unfreeze_delegate efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate;
}
} } } 
namespace Efl { namespace Ui { namespace Focus { 
/// <summary>Structure holding the graph of relations between focusable objects.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Relations
{
    /// <summary>List of objects on the right side</summary>
    public Eina.List<Efl.Ui.Focus.IObject> Right;
    /// <summary>[List of objects on the left side</summary>
    public Eina.List<Efl.Ui.Focus.IObject> Left;
    /// <summary>[List of objects above</summary>
    public Eina.List<Efl.Ui.Focus.IObject> Top;
    /// <summary>[List of objects below</summary>
    public Eina.List<Efl.Ui.Focus.IObject> Down;
    /// <summary>[Next object</summary>
    public Efl.Ui.Focus.IObject Next;
    /// <summary>Previous object</summary>
    public Efl.Ui.Focus.IObject Prev;
    /// <summary>Parent object</summary>
    public Efl.Ui.Focus.IObject Parent;
    /// <summary>Redirect manager</summary>
    public Efl.Ui.Focus.IManager Redirect;
    /// <summary>The node where this is the information from</summary>
    public Efl.Ui.Focus.IObject Node;
    /// <summary><c>true</c> if this node is only logical</summary>
    public bool Logical;
    /// <summary>The position in the history stack</summary>
    public int Position_in_history;
    ///<summary>Constructor for Relations.</summary>
    public Relations(
        Eina.List<Efl.Ui.Focus.IObject> Right=default(Eina.List<Efl.Ui.Focus.IObject>),
        Eina.List<Efl.Ui.Focus.IObject> Left=default(Eina.List<Efl.Ui.Focus.IObject>),
        Eina.List<Efl.Ui.Focus.IObject> Top=default(Eina.List<Efl.Ui.Focus.IObject>),
        Eina.List<Efl.Ui.Focus.IObject> Down=default(Eina.List<Efl.Ui.Focus.IObject>),
        Efl.Ui.Focus.IObject Next=default(Efl.Ui.Focus.IObject),
        Efl.Ui.Focus.IObject Prev=default(Efl.Ui.Focus.IObject),
        Efl.Ui.Focus.IObject Parent=default(Efl.Ui.Focus.IObject),
        Efl.Ui.Focus.IManager Redirect=default(Efl.Ui.Focus.IManager),
        Efl.Ui.Focus.IObject Node=default(Efl.Ui.Focus.IObject),
        bool Logical=default(bool),
        int Position_in_history=default(int)    )
    {
        this.Right = Right;
        this.Left = Left;
        this.Top = Top;
        this.Down = Down;
        this.Next = Next;
        this.Prev = Prev;
        this.Parent = Parent;
        this.Redirect = Redirect;
        this.Node = Node;
        this.Logical = Logical;
        this.Position_in_history = Position_in_history;
    }

    public static implicit operator Relations(IntPtr ptr)
    {
        var tmp = (Relations.NativeStruct)Marshal.PtrToStructure(ptr, typeof(Relations.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct Relations.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        
        public System.IntPtr Right;
        
        public System.IntPtr Left;
        
        public System.IntPtr Top;
        
        public System.IntPtr Down;
        ///<summary>Internal wrapper for field Next</summary>
        public System.IntPtr Next;
        ///<summary>Internal wrapper for field Prev</summary>
        public System.IntPtr Prev;
        ///<summary>Internal wrapper for field Parent</summary>
        public System.IntPtr Parent;
        ///<summary>Internal wrapper for field Redirect</summary>
        public System.IntPtr Redirect;
        ///<summary>Internal wrapper for field Node</summary>
        public System.IntPtr Node;
        ///<summary>Internal wrapper for field Logical</summary>
        public System.Byte Logical;
        
        public int Position_in_history;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator Relations.NativeStruct(Relations _external_struct)
        {
            var _internal_struct = new Relations.NativeStruct();
            _internal_struct.Right = _external_struct.Right.Handle;
            _internal_struct.Left = _external_struct.Left.Handle;
            _internal_struct.Top = _external_struct.Top.Handle;
            _internal_struct.Down = _external_struct.Down.Handle;
            _internal_struct.Next = _external_struct.Next?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Prev = _external_struct.Prev?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Parent = _external_struct.Parent?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Redirect = _external_struct.Redirect?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Node = _external_struct.Node?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Logical = _external_struct.Logical ? (byte)1 : (byte)0;
            _internal_struct.Position_in_history = _external_struct.Position_in_history;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator Relations(Relations.NativeStruct _internal_struct)
        {
            var _external_struct = new Relations();
            _external_struct.Right = new Eina.List<Efl.Ui.Focus.IObject>(_internal_struct.Right, false, false);
            _external_struct.Left = new Eina.List<Efl.Ui.Focus.IObject>(_internal_struct.Left, false, false);
            _external_struct.Top = new Eina.List<Efl.Ui.Focus.IObject>(_internal_struct.Top, false, false);
            _external_struct.Down = new Eina.List<Efl.Ui.Focus.IObject>(_internal_struct.Down, false, false);

            _external_struct.Next = (Efl.Ui.Focus.IObjectConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Next);

            _external_struct.Prev = (Efl.Ui.Focus.IObjectConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Prev);

            _external_struct.Parent = (Efl.Ui.Focus.IObjectConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Parent);

            _external_struct.Redirect = (Efl.Ui.Focus.IManagerConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Redirect);

            _external_struct.Node = (Efl.Ui.Focus.IObjectConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Node);
            _external_struct.Logical = _internal_struct.Logical != 0;
            _external_struct.Position_in_history = _internal_struct.Position_in_history;
            return _external_struct;
        }

    }

}

} } } 
namespace Efl { namespace Ui { namespace Focus { 
/// <summary>Structure holding the focus object with extra information on logical end
/// (Since EFL 1.22)</summary>
[StructLayout(LayoutKind.Sequential)]
public struct ManagerLogicalEndDetail
{
    /// <summary><c>true</c> if element is registered as regular element in the <see cref="Efl.Ui.Focus.IManager"/> obejct, <c>false</c> otherwise</summary>
    public bool Is_regular_end;
    /// <summary>The last element of the logical chain in the <see cref="Efl.Ui.Focus.IManager"/></summary>
    public Efl.Ui.Focus.IObject Element;
    ///<summary>Constructor for ManagerLogicalEndDetail.</summary>
    public ManagerLogicalEndDetail(
        bool Is_regular_end=default(bool),
        Efl.Ui.Focus.IObject Element=default(Efl.Ui.Focus.IObject)    )
    {
        this.Is_regular_end = Is_regular_end;
        this.Element = Element;
    }

    public static implicit operator ManagerLogicalEndDetail(IntPtr ptr)
    {
        var tmp = (ManagerLogicalEndDetail.NativeStruct)Marshal.PtrToStructure(ptr, typeof(ManagerLogicalEndDetail.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct ManagerLogicalEndDetail.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Is_regular_end</summary>
        public System.Byte Is_regular_end;
        ///<summary>Internal wrapper for field Element</summary>
        public System.IntPtr Element;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator ManagerLogicalEndDetail.NativeStruct(ManagerLogicalEndDetail _external_struct)
        {
            var _internal_struct = new ManagerLogicalEndDetail.NativeStruct();
            _internal_struct.Is_regular_end = _external_struct.Is_regular_end ? (byte)1 : (byte)0;
            _internal_struct.Element = _external_struct.Element?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator ManagerLogicalEndDetail(ManagerLogicalEndDetail.NativeStruct _internal_struct)
        {
            var _external_struct = new ManagerLogicalEndDetail();
            _external_struct.Is_regular_end = _internal_struct.Is_regular_end != 0;

            _external_struct.Element = (Efl.Ui.Focus.IObjectConcrete) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Element);
            return _external_struct;
        }

    }

}

} } } 
