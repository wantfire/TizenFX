#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>Elementary layout internal part class</summary>
[LayoutPartLegacyNativeInherit]
public class LayoutPartLegacy : Efl.Ui.LayoutPart, Efl.Eo.IWrapper,Efl.IContent,Efl.IText,Efl.ITextMarkup,Efl.Ui.IL10n
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (LayoutPartLegacy))
                return Efl.Ui.LayoutPartLegacyNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_layout_part_legacy_class_get();
    ///<summary>Creates a new instance.</summary>
    ///<param name="parent">Parent instance.</param>
    public LayoutPartLegacy(Efl.Object parent= null
            ) :
        base(efl_ui_layout_part_legacy_class_get(), typeof(LayoutPartLegacy), parent)
    {
        FinishInstantiation();
    }
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    protected LayoutPartLegacy(System.IntPtr raw) : base(raw)
    {
                RegisterEventProxies();
    }
    ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    protected LayoutPartLegacy(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
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
private static object ContentChangedEvtKey = new object();
    /// <summary>Sent after the content is set or unset using the current content object.
    /// (Since EFL 1.22)</summary>
    public event EventHandler<Efl.IContentContentChangedEvt_Args> ContentChangedEvt
    {
        add {
            lock (eventLock) {
                string key = "_EFL_CONTENT_EVENT_CONTENT_CHANGED";
                if (AddNativeEventHandler(efl.Libs.Efl, key, this.evt_ContentChangedEvt_delegate)) {
                    eventHandlers.AddHandler(ContentChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error adding proxy for event {key}");
            }
        }
        remove {
            lock (eventLock) {
                string key = "_EFL_CONTENT_EVENT_CONTENT_CHANGED";
                if (RemoveNativeEventHandler(key, this.evt_ContentChangedEvt_delegate)) { 
                    eventHandlers.RemoveHandler(ContentChangedEvtKey , value);
                } else
                    Eina.Log.Error($"Error removing proxy for event {key}");
            }
        }
    }
    ///<summary>Method to raise event ContentChangedEvt.</summary>
    public void On_ContentChangedEvt(Efl.IContentContentChangedEvt_Args e)
    {
        EventHandler<Efl.IContentContentChangedEvt_Args> evt;
        lock (eventLock) {
        evt = (EventHandler<Efl.IContentContentChangedEvt_Args>)eventHandlers[ContentChangedEvtKey];
        }
        evt?.Invoke(this, e);
    }
    Efl.EventCb evt_ContentChangedEvt_delegate;
    private void on_ContentChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event.NativeStruct evt)
    {
        Efl.IContentContentChangedEvt_Args args = new Efl.IContentContentChangedEvt_Args();
      args.arg = (Efl.Eo.Globals.CreateWrapperFor(evt.Info) as Efl.Gfx.IEntityConcrete);
        try {
            On_ContentChangedEvt(args);
        } catch (Exception e) {
            Eina.Log.Error(e.ToString());
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
    }

    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
    protected override void RegisterEventProxies()
    {
        base.RegisterEventProxies();
        evt_ContentChangedEvt_delegate = new Efl.EventCb(on_ContentChangedEvt_NativeCallback);
    }
    /// <summary>Swallowed sub-object contained in this object.
    /// (Since EFL 1.22)</summary>
    /// <returns>The object to swallow.</returns>
    virtual public Efl.Gfx.IEntity GetContent() {
         var _ret_var = Efl.IContentNativeInherit.efl_content_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Swallowed sub-object contained in this object.
    /// (Since EFL 1.22)</summary>
    /// <param name="content">The object to swallow.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    virtual public bool SetContent( Efl.Gfx.IEntity content) {
                                 var _ret_var = Efl.IContentNativeInherit.efl_content_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), content);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Unswallow the object in the current container and return it.
    /// (Since EFL 1.22)</summary>
    /// <returns>Unswallowed object</returns>
    virtual public Efl.Gfx.IEntity UnsetContent() {
         var _ret_var = Efl.IContentNativeInherit.efl_content_unset_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Retrieves the text string currently being displayed by the given text object.
    /// Do not free() the return value.
    /// 
    /// See also <see cref="Efl.IText.GetText"/>.
    /// (Since EFL 1.22)</summary>
    /// <returns>Text string to display on it.</returns>
    virtual public System.String GetText() {
         var _ret_var = Efl.ITextNativeInherit.efl_text_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Sets the text string to be displayed by the given text object.
    /// See also <see cref="Efl.IText.GetText"/>.
    /// (Since EFL 1.22)</summary>
    /// <param name="text">Text string to display on it.</param>
    /// <returns></returns>
    virtual public void SetText( System.String text) {
                                 Efl.ITextNativeInherit.efl_text_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), text);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Markup property</summary>
    /// <returns>The markup-text representation set to this text.</returns>
    virtual public System.String GetMarkup() {
         var _ret_var = Efl.ITextMarkupNativeInherit.efl_text_markup_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Markup property</summary>
    /// <param name="markup">The markup-text representation set to this text.</param>
    /// <returns></returns>
    virtual public void SetMarkup( System.String markup) {
                                 Efl.ITextMarkupNativeInherit.efl_text_markup_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), markup);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>A unique string to be translated.
    /// Often this will be a human-readable string (e.g. in English) but it can also be a unique string identifier that must then be translated to the current locale with <c>dgettext</c>() or any similar mechanism.
    /// 
    /// Setting this property will enable translation for this object or part.</summary>
    /// <param name="domain">A translation domain. If <c>null</c> this means the default domain is used.</param>
    /// <returns>This returns the untranslated value of <c>label</c>. The translated string can usually be retrieved with <see cref="Efl.IText.GetText"/>.</returns>
    virtual public System.String GetL10nText( out System.String domain) {
                                 var _ret_var = Efl.Ui.IL10nNativeInherit.efl_ui_l10n_text_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out domain);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Sets the new untranslated string and domain for this object.</summary>
    /// <param name="label">A unique (untranslated) string.</param>
    /// <param name="domain">A translation domain. If <c>null</c> this uses the default domain (eg. set by <c>textdomain</c>()).</param>
    /// <returns></returns>
    virtual public void SetL10nText( System.String label,  System.String domain) {
                                                         Efl.Ui.IL10nNativeInherit.efl_ui_l10n_text_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), label,  domain);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Requests this object to update its text strings for the current locale.
    /// Currently strings are translated with <c>dgettext</c>, so support for this function may depend on the platform. It is up to the application to provide its own translation data.
    /// 
    /// This function is a hook meant to be implemented by any object that supports translation. This can be called whenever a new object is created or when the current locale changes, for instance. This should only trigger further calls to <see cref="Efl.Ui.IL10n.UpdateTranslation"/> to children objects.</summary>
    /// <returns></returns>
    virtual public void UpdateTranslation() {
         Efl.Ui.IL10nNativeInherit.efl_ui_l10n_translation_update_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>Swallowed sub-object contained in this object.
/// (Since EFL 1.22)</summary>
/// <value>The object to swallow.</value>
    public Efl.Gfx.IEntity Content {
        get { return GetContent(); }
        set { SetContent( value); }
    }
    /// <summary>Markup property</summary>
/// <value>The markup-text representation set to this text.</value>
    public System.String Markup {
        get { return GetMarkup(); }
        set { SetMarkup( value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.LayoutPartLegacy.efl_ui_layout_part_legacy_class_get();
    }
}
public class LayoutPartLegacyNativeInherit : Efl.Ui.LayoutPartNativeInherit{
    public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_content_get_static_delegate == null)
            efl_content_get_static_delegate = new efl_content_get_delegate(content_get);
        if (methods.FirstOrDefault(m => m.Name == "GetContent") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_get"), func = Marshal.GetFunctionPointerForDelegate(efl_content_get_static_delegate)});
        if (efl_content_set_static_delegate == null)
            efl_content_set_static_delegate = new efl_content_set_delegate(content_set);
        if (methods.FirstOrDefault(m => m.Name == "SetContent") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_set"), func = Marshal.GetFunctionPointerForDelegate(efl_content_set_static_delegate)});
        if (efl_content_unset_static_delegate == null)
            efl_content_unset_static_delegate = new efl_content_unset_delegate(content_unset);
        if (methods.FirstOrDefault(m => m.Name == "UnsetContent") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_unset"), func = Marshal.GetFunctionPointerForDelegate(efl_content_unset_static_delegate)});
        if (efl_text_get_static_delegate == null)
            efl_text_get_static_delegate = new efl_text_get_delegate(text_get);
        if (methods.FirstOrDefault(m => m.Name == "GetText") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_get_static_delegate)});
        if (efl_text_set_static_delegate == null)
            efl_text_set_static_delegate = new efl_text_set_delegate(text_set);
        if (methods.FirstOrDefault(m => m.Name == "SetText") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_set_static_delegate)});
        if (efl_text_markup_get_static_delegate == null)
            efl_text_markup_get_static_delegate = new efl_text_markup_get_delegate(markup_get);
        if (methods.FirstOrDefault(m => m.Name == "GetMarkup") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_markup_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_markup_get_static_delegate)});
        if (efl_text_markup_set_static_delegate == null)
            efl_text_markup_set_static_delegate = new efl_text_markup_set_delegate(markup_set);
        if (methods.FirstOrDefault(m => m.Name == "SetMarkup") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_markup_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_markup_set_static_delegate)});
        if (efl_ui_l10n_text_get_static_delegate == null)
            efl_ui_l10n_text_get_static_delegate = new efl_ui_l10n_text_get_delegate(l10n_text_get);
        if (methods.FirstOrDefault(m => m.Name == "GetL10nText") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_l10n_text_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_l10n_text_get_static_delegate)});
        if (efl_ui_l10n_text_set_static_delegate == null)
            efl_ui_l10n_text_set_static_delegate = new efl_ui_l10n_text_set_delegate(l10n_text_set);
        if (methods.FirstOrDefault(m => m.Name == "SetL10nText") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_l10n_text_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_l10n_text_set_static_delegate)});
        if (efl_ui_l10n_translation_update_static_delegate == null)
            efl_ui_l10n_translation_update_static_delegate = new efl_ui_l10n_translation_update_delegate(translation_update);
        if (methods.FirstOrDefault(m => m.Name == "UpdateTranslation") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_l10n_translation_update"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_l10n_translation_update_static_delegate)});
        descs.AddRange(base.GetEoOps(type));
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.Ui.LayoutPartLegacy.efl_ui_layout_part_legacy_class_get();
    }
    public static new  IntPtr GetEflClassStatic()
    {
        return Efl.Ui.LayoutPartLegacy.efl_ui_layout_part_legacy_class_get();
    }


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.IEntity efl_content_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.IEntity efl_content_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_content_get_api_delegate> efl_content_get_ptr = new Efl.Eo.FunctionWrapper<efl_content_get_api_delegate>(_Module, "efl_content_get");
     private static Efl.Gfx.IEntity content_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_content_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Gfx.IEntity _ret_var = default(Efl.Gfx.IEntity);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).GetContent();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_content_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_content_get_delegate efl_content_get_static_delegate;


     [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_content_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity content);


     [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_content_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.IEntity content);
     public static Efl.Eo.FunctionWrapper<efl_content_set_api_delegate> efl_content_set_ptr = new Efl.Eo.FunctionWrapper<efl_content_set_api_delegate>(_Module, "efl_content_set");
     private static bool content_set(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.IEntity content)
    {
        Eina.Log.Debug("function efl_content_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                bool _ret_var = default(bool);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).SetContent( content);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var;
        } else {
            return efl_content_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  content);
        }
    }
    private static efl_content_set_delegate efl_content_set_static_delegate;


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.IEntity efl_content_unset_delegate(System.IntPtr obj, System.IntPtr pd);


    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.IEntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.IEntity efl_content_unset_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_content_unset_api_delegate> efl_content_unset_ptr = new Efl.Eo.FunctionWrapper<efl_content_unset_api_delegate>(_Module, "efl_content_unset");
     private static Efl.Gfx.IEntity content_unset(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_content_unset was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        Efl.Gfx.IEntity _ret_var = default(Efl.Gfx.IEntity);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).UnsetContent();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_content_unset_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_content_unset_delegate efl_content_unset_static_delegate;


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate System.String efl_text_get_delegate(System.IntPtr obj, System.IntPtr pd);


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate System.String efl_text_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_text_get_api_delegate> efl_text_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_get_api_delegate>(_Module, "efl_text_get");
     private static System.String text_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_text_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        System.String _ret_var = default(System.String);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).GetText();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_text_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_text_get_delegate efl_text_get_static_delegate;


     private delegate void efl_text_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String text);


     public delegate void efl_text_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String text);
     public static Efl.Eo.FunctionWrapper<efl_text_set_api_delegate> efl_text_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_set_api_delegate>(_Module, "efl_text_set");
     private static void text_set(System.IntPtr obj, System.IntPtr pd,  System.String text)
    {
        Eina.Log.Debug("function efl_text_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((LayoutPartLegacy)wrapper).SetText( text);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_text_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  text);
        }
    }
    private static efl_text_set_delegate efl_text_set_static_delegate;


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate System.String efl_text_markup_get_delegate(System.IntPtr obj, System.IntPtr pd);


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate System.String efl_text_markup_get_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_text_markup_get_api_delegate> efl_text_markup_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_markup_get_api_delegate>(_Module, "efl_text_markup_get");
     private static System.String markup_get(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_text_markup_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        System.String _ret_var = default(System.String);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).GetMarkup();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        return _ret_var;
        } else {
            return efl_text_markup_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_text_markup_get_delegate efl_text_markup_get_static_delegate;


     private delegate void efl_text_markup_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String markup);


     public delegate void efl_text_markup_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String markup);
     public static Efl.Eo.FunctionWrapper<efl_text_markup_set_api_delegate> efl_text_markup_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_markup_set_api_delegate>(_Module, "efl_text_markup_set");
     private static void markup_set(System.IntPtr obj, System.IntPtr pd,  System.String markup)
    {
        Eina.Log.Debug("function efl_text_markup_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                
            try {
                ((LayoutPartLegacy)wrapper).SetMarkup( markup);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                } else {
            efl_text_markup_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  markup);
        }
    }
    private static efl_text_markup_set_delegate efl_text_markup_set_static_delegate;


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate System.String efl_ui_l10n_text_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out System.String domain);


     [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate System.String efl_ui_l10n_text_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out System.String domain);
     public static Efl.Eo.FunctionWrapper<efl_ui_l10n_text_get_api_delegate> efl_ui_l10n_text_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_l10n_text_get_api_delegate>(_Module, "efl_ui_l10n_text_get");
     private static System.String l10n_text_get(System.IntPtr obj, System.IntPtr pd,  out System.String domain)
    {
        Eina.Log.Debug("function efl_ui_l10n_text_get was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                            System.String _out_domain = default(System.String);
                    System.String _ret_var = default(System.String);
            try {
                _ret_var = ((LayoutPartLegacy)wrapper).GetL10nText( out _out_domain);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
        domain = _out_domain;
                return _ret_var;
        } else {
            return efl_ui_l10n_text_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out domain);
        }
    }
    private static efl_ui_l10n_text_get_delegate efl_ui_l10n_text_get_static_delegate;


     private delegate void efl_ui_l10n_text_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String label,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String domain);


     public delegate void efl_ui_l10n_text_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String label,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  System.String domain);
     public static Efl.Eo.FunctionWrapper<efl_ui_l10n_text_set_api_delegate> efl_ui_l10n_text_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_l10n_text_set_api_delegate>(_Module, "efl_ui_l10n_text_set");
     private static void l10n_text_set(System.IntPtr obj, System.IntPtr pd,  System.String label,  System.String domain)
    {
        Eina.Log.Debug("function efl_ui_l10n_text_set was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                                        
            try {
                ((LayoutPartLegacy)wrapper).SetL10nText( label,  domain);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                                                } else {
            efl_ui_l10n_text_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  label,  domain);
        }
    }
    private static efl_ui_l10n_text_set_delegate efl_ui_l10n_text_set_static_delegate;


     private delegate void efl_ui_l10n_translation_update_delegate(System.IntPtr obj, System.IntPtr pd);


     public delegate void efl_ui_l10n_translation_update_api_delegate(System.IntPtr obj);
     public static Efl.Eo.FunctionWrapper<efl_ui_l10n_translation_update_api_delegate> efl_ui_l10n_translation_update_ptr = new Efl.Eo.FunctionWrapper<efl_ui_l10n_translation_update_api_delegate>(_Module, "efl_ui_l10n_translation_update");
     private static void translation_update(System.IntPtr obj, System.IntPtr pd)
    {
        Eina.Log.Debug("function efl_ui_l10n_translation_update was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                        
            try {
                ((LayoutPartLegacy)wrapper).UpdateTranslation();
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                } else {
            efl_ui_l10n_translation_update_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
        }
    }
    private static efl_ui_l10n_translation_update_delegate efl_ui_l10n_translation_update_static_delegate;
}
} } 
