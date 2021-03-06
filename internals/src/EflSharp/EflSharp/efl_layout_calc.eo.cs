#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Layout { 
/// <summary>This interface defines a common set of APIs used to trigger calculations with layout objects.
/// This defines all the APIs supported by legacy &quot;Edje&quot; object, known in EO API as Efl.Canvas.Layout.
/// 1.21</summary>
[CalcNativeInherit]
public interface Calc : 
   Efl.Eo.IWrapper, IDisposable
{
   /// <summary>Whether this object updates its size hints automatically.
/// 1.21</summary>
/// <returns>Whether or not update the size hints.
/// 1.21</returns>
bool GetCalcAutoUpdateHints();
   /// <summary>Enable or disable auto-update of size hints.
/// 1.21</summary>
/// <param name="update">Whether or not update the size hints.
/// 1.21</param>
/// <returns></returns>
 void SetCalcAutoUpdateHints( bool update);
   /// <summary>Calculates the minimum required size for a given layout object.
/// This call will trigger an internal recalculation of all parts of the object, in order to return its minimum required dimensions for width and height. The user might choose to impose those minimum sizes, making the resulting calculation to get to values greater or equal than <c>restricted</c> in both directions.
/// 
/// Note: At the end of this call, the object won&apos;t be automatically resized to the new dimensions, but just return the calculated sizes. The caller is the one up to change its geometry or not.
/// 
/// Warning: Be advised that invisible parts in the object will be taken into account in this calculation.
/// 1.21</summary>
/// <param name="restricted">The minimum size constraint as input, the returned size can not be lower than this (in both directions).
/// 1.21</param>
/// <returns>The minimum required size.
/// 1.21</returns>
Eina.Size2D CalcSizeMin( Eina.Size2D restricted);
   /// <summary>Calculates the geometry of the region, relative to a given layout object&apos;s area, occupied by all parts in the object.
/// This function gets the geometry of the rectangle equal to the area required to group all parts in obj&apos;s group/collection. The x and y coordinates are relative to the top left corner of the whole obj object&apos;s area. Parts placed out of the group&apos;s boundaries will also be taken in account, so that x and y may be negative.
/// 
/// Note: On failure, this function will make all non-<c>null</c> geometry pointers&apos; pointed variables be set to zero.
/// 1.21</summary>
/// <returns>The calculated region.
/// 1.21</returns>
Eina.Rect CalcPartsExtends();
   /// <summary>Freezes the layout object.
/// This function puts all changes on hold. Successive freezes will nest, requiring an equal number of thaws.
/// 
/// See also <see cref="Efl.Layout.Calc.ThawCalc"/>.
/// 1.21</summary>
/// <returns>The frozen state or 0 on error
/// 1.21</returns>
 int FreezeCalc();
   /// <summary>Thaws the layout object.
/// This function thaws (in other words &quot;unfreezes&quot;) the given layout object.
/// 
/// Note: If sucessive freezes were done, an equal number of thaws will be required.
/// 
/// See also <see cref="Efl.Layout.Calc.FreezeCalc"/>.
/// 1.21</summary>
/// <returns>The frozen state or 0 if the object is not frozen or on error.
/// 1.21</returns>
 int ThawCalc();
   /// <summary>Forces a Size/Geometry calculation.
/// Forces the object to recalculate its layout regardless of freeze/thaw. This API should be used carefully.
/// 
/// See also <see cref="Efl.Layout.Calc.FreezeCalc"/> and <see cref="Efl.Layout.Calc.ThawCalc"/>.
/// 1.21</summary>
/// <returns></returns>
 void CalcForce();
                        /// <summary>The layout was recalculated.
   /// 1.21</summary>
   event EventHandler RecalcEvt;
   /// <summary>A circular dependency between parts of the object was found.
   /// 1.21</summary>
   event EventHandler CircularDependencyEvt;
   /// <summary>Whether this object updates its size hints automatically.
/// By default edje doesn&apos;t set size hints on itself. If this property is set to <c>true</c>, size hints will be updated after recalculation. Be careful, as recalculation may happen often, enabling this property may have a considerable performance impact as other widgets will be notified of the size hints changes.
/// 
/// A layout recalculation can be triggered by <see cref="Efl.Layout.Calc.CalcSizeMin"/>, <see cref="Efl.Layout.Calc.CalcSizeMin"/>, <see cref="Efl.Layout.Calc.CalcPartsExtends"/> or even any other internal event.
/// 1.21</summary>
/// <value>Whether or not update the size hints.
/// 1.21</value>
   bool CalcAutoUpdateHints {
      get ;
      set ;
   }
}
/// <summary>This interface defines a common set of APIs used to trigger calculations with layout objects.
/// This defines all the APIs supported by legacy &quot;Edje&quot; object, known in EO API as Efl.Canvas.Layout.
/// 1.21</summary>
sealed public class CalcConcrete : 

Calc
   
{
   ///<summary>Pointer to the native class description.</summary>
   public System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (CalcConcrete))
            return Efl.Layout.CalcNativeInherit.GetEflClassStatic();
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
   [System.Runtime.InteropServices.DllImport(efl.Libs.Edje)] internal static extern System.IntPtr
      efl_layout_calc_interface_get();
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public CalcConcrete(System.IntPtr raw)
   {
      handle = raw;
      register_event_proxies();
   }
   ///<summary>Destructor.</summary>
   ~CalcConcrete()
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
   ///<summary>Casts obj into an instance of this type.</summary>
   public static CalcConcrete static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new CalcConcrete(obj.NativeHandle);
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
   private bool add_cpp_event_handler(string lib, string key, Efl.EventCb evt_delegate) {
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
   private bool remove_cpp_event_handler(string key, Efl.EventCb evt_delegate) {
      int event_count = 0;
      if (!event_cb_count.TryGetValue(key, out event_count))
         event_cb_count[key] = event_count;
      if (event_count == 1) {
         IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Edje, key);
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
private static object RecalcEvtKey = new object();
   /// <summary>The layout was recalculated.
   /// 1.21</summary>
   public event EventHandler RecalcEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_LAYOUT_EVENT_RECALC";
            if (add_cpp_event_handler(efl.Libs.Edje, key, this.evt_RecalcEvt_delegate)) {
               eventHandlers.AddHandler(RecalcEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_LAYOUT_EVENT_RECALC";
            if (remove_cpp_event_handler(key, this.evt_RecalcEvt_delegate)) { 
               eventHandlers.RemoveHandler(RecalcEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RecalcEvt.</summary>
   public void On_RecalcEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[RecalcEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RecalcEvt_delegate;
   private void on_RecalcEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_RecalcEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object CircularDependencyEvtKey = new object();
   /// <summary>A circular dependency between parts of the object was found.
   /// 1.21</summary>
   public event EventHandler CircularDependencyEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_LAYOUT_EVENT_CIRCULAR_DEPENDENCY";
            if (add_cpp_event_handler(efl.Libs.Edje, key, this.evt_CircularDependencyEvt_delegate)) {
               eventHandlers.AddHandler(CircularDependencyEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_LAYOUT_EVENT_CIRCULAR_DEPENDENCY";
            if (remove_cpp_event_handler(key, this.evt_CircularDependencyEvt_delegate)) { 
               eventHandlers.RemoveHandler(CircularDependencyEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event CircularDependencyEvt.</summary>
   public void On_CircularDependencyEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[CircularDependencyEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_CircularDependencyEvt_delegate;
   private void on_CircularDependencyEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_CircularDependencyEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

    void register_event_proxies()
   {
      evt_RecalcEvt_delegate = new Efl.EventCb(on_RecalcEvt_NativeCallback);
      evt_CircularDependencyEvt_delegate = new Efl.EventCb(on_CircularDependencyEvt_NativeCallback);
   }
   /// <summary>Whether this object updates its size hints automatically.
   /// 1.21</summary>
   /// <returns>Whether or not update the size hints.
   /// 1.21</returns>
   public bool GetCalcAutoUpdateHints() {
       var _ret_var = Efl.Layout.CalcNativeInherit.efl_layout_calc_auto_update_hints_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Enable or disable auto-update of size hints.
   /// 1.21</summary>
   /// <param name="update">Whether or not update the size hints.
   /// 1.21</param>
   /// <returns></returns>
   public  void SetCalcAutoUpdateHints( bool update) {
                         Efl.Layout.CalcNativeInherit.efl_layout_calc_auto_update_hints_set_ptr.Value.Delegate(this.NativeHandle, update);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Calculates the minimum required size for a given layout object.
   /// This call will trigger an internal recalculation of all parts of the object, in order to return its minimum required dimensions for width and height. The user might choose to impose those minimum sizes, making the resulting calculation to get to values greater or equal than <c>restricted</c> in both directions.
   /// 
   /// Note: At the end of this call, the object won&apos;t be automatically resized to the new dimensions, but just return the calculated sizes. The caller is the one up to change its geometry or not.
   /// 
   /// Warning: Be advised that invisible parts in the object will be taken into account in this calculation.
   /// 1.21</summary>
   /// <param name="restricted">The minimum size constraint as input, the returned size can not be lower than this (in both directions).
   /// 1.21</param>
   /// <returns>The minimum required size.
   /// 1.21</returns>
   public Eina.Size2D CalcSizeMin( Eina.Size2D restricted) {
       var _in_restricted = Eina.Size2D_StructConversion.ToInternal(restricted);
                  var _ret_var = Efl.Layout.CalcNativeInherit.efl_layout_calc_size_min_ptr.Value.Delegate(this.NativeHandle, _in_restricted);
      Eina.Error.RaiseIfUnhandledException();
                  return Eina.Size2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Calculates the geometry of the region, relative to a given layout object&apos;s area, occupied by all parts in the object.
   /// This function gets the geometry of the rectangle equal to the area required to group all parts in obj&apos;s group/collection. The x and y coordinates are relative to the top left corner of the whole obj object&apos;s area. Parts placed out of the group&apos;s boundaries will also be taken in account, so that x and y may be negative.
   /// 
   /// Note: On failure, this function will make all non-<c>null</c> geometry pointers&apos; pointed variables be set to zero.
   /// 1.21</summary>
   /// <returns>The calculated region.
   /// 1.21</returns>
   public Eina.Rect CalcPartsExtends() {
       var _ret_var = Efl.Layout.CalcNativeInherit.efl_layout_calc_parts_extends_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Rect_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Freezes the layout object.
   /// This function puts all changes on hold. Successive freezes will nest, requiring an equal number of thaws.
   /// 
   /// See also <see cref="Efl.Layout.Calc.ThawCalc"/>.
   /// 1.21</summary>
   /// <returns>The frozen state or 0 on error
   /// 1.21</returns>
   public  int FreezeCalc() {
       var _ret_var = Efl.Layout.CalcNativeInherit.efl_layout_calc_freeze_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Thaws the layout object.
   /// This function thaws (in other words &quot;unfreezes&quot;) the given layout object.
   /// 
   /// Note: If sucessive freezes were done, an equal number of thaws will be required.
   /// 
   /// See also <see cref="Efl.Layout.Calc.FreezeCalc"/>.
   /// 1.21</summary>
   /// <returns>The frozen state or 0 if the object is not frozen or on error.
   /// 1.21</returns>
   public  int ThawCalc() {
       var _ret_var = Efl.Layout.CalcNativeInherit.efl_layout_calc_thaw_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Forces a Size/Geometry calculation.
   /// Forces the object to recalculate its layout regardless of freeze/thaw. This API should be used carefully.
   /// 
   /// See also <see cref="Efl.Layout.Calc.FreezeCalc"/> and <see cref="Efl.Layout.Calc.ThawCalc"/>.
   /// 1.21</summary>
   /// <returns></returns>
   public  void CalcForce() {
       Efl.Layout.CalcNativeInherit.efl_layout_calc_force_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Whether this object updates its size hints automatically.
/// By default edje doesn&apos;t set size hints on itself. If this property is set to <c>true</c>, size hints will be updated after recalculation. Be careful, as recalculation may happen often, enabling this property may have a considerable performance impact as other widgets will be notified of the size hints changes.
/// 
/// A layout recalculation can be triggered by <see cref="Efl.Layout.Calc.CalcSizeMin"/>, <see cref="Efl.Layout.Calc.CalcSizeMin"/>, <see cref="Efl.Layout.Calc.CalcPartsExtends"/> or even any other internal event.
/// 1.21</summary>
/// <value>Whether or not update the size hints.
/// 1.21</value>
   public bool CalcAutoUpdateHints {
      get { return GetCalcAutoUpdateHints(); }
      set { SetCalcAutoUpdateHints( value); }
   }
}
public class CalcNativeInherit  : Efl.Eo.NativeClass{
   public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Edje);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_layout_calc_auto_update_hints_get_static_delegate == null)
      efl_layout_calc_auto_update_hints_get_static_delegate = new efl_layout_calc_auto_update_hints_get_delegate(calc_auto_update_hints_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_auto_update_hints_get"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_auto_update_hints_get_static_delegate)});
      if (efl_layout_calc_auto_update_hints_set_static_delegate == null)
      efl_layout_calc_auto_update_hints_set_static_delegate = new efl_layout_calc_auto_update_hints_set_delegate(calc_auto_update_hints_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_auto_update_hints_set"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_auto_update_hints_set_static_delegate)});
      if (efl_layout_calc_size_min_static_delegate == null)
      efl_layout_calc_size_min_static_delegate = new efl_layout_calc_size_min_delegate(calc_size_min);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_size_min"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_size_min_static_delegate)});
      if (efl_layout_calc_parts_extends_static_delegate == null)
      efl_layout_calc_parts_extends_static_delegate = new efl_layout_calc_parts_extends_delegate(calc_parts_extends);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_parts_extends"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_parts_extends_static_delegate)});
      if (efl_layout_calc_freeze_static_delegate == null)
      efl_layout_calc_freeze_static_delegate = new efl_layout_calc_freeze_delegate(calc_freeze);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_freeze"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_freeze_static_delegate)});
      if (efl_layout_calc_thaw_static_delegate == null)
      efl_layout_calc_thaw_static_delegate = new efl_layout_calc_thaw_delegate(calc_thaw);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_thaw"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_thaw_static_delegate)});
      if (efl_layout_calc_force_static_delegate == null)
      efl_layout_calc_force_static_delegate = new efl_layout_calc_force_delegate(calc_force);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_layout_calc_force"), func = Marshal.GetFunctionPointerForDelegate(efl_layout_calc_force_static_delegate)});
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Layout.CalcConcrete.efl_layout_calc_interface_get();
   }
   public static  IntPtr GetEflClassStatic()
   {
      return Efl.Layout.CalcConcrete.efl_layout_calc_interface_get();
   }


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_layout_calc_auto_update_hints_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_layout_calc_auto_update_hints_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_auto_update_hints_get_api_delegate> efl_layout_calc_auto_update_hints_get_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_auto_update_hints_get_api_delegate>(_Module, "efl_layout_calc_auto_update_hints_get");
    private static bool calc_auto_update_hints_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_layout_calc_auto_update_hints_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Calc)wrapper).GetCalcAutoUpdateHints();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_layout_calc_auto_update_hints_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_layout_calc_auto_update_hints_get_delegate efl_layout_calc_auto_update_hints_get_static_delegate;


    private delegate  void efl_layout_calc_auto_update_hints_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool update);


    public delegate  void efl_layout_calc_auto_update_hints_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool update);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_auto_update_hints_set_api_delegate> efl_layout_calc_auto_update_hints_set_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_auto_update_hints_set_api_delegate>(_Module, "efl_layout_calc_auto_update_hints_set");
    private static  void calc_auto_update_hints_set(System.IntPtr obj, System.IntPtr pd,  bool update)
   {
      Eina.Log.Debug("function efl_layout_calc_auto_update_hints_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Calc)wrapper).SetCalcAutoUpdateHints( update);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_layout_calc_auto_update_hints_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  update);
      }
   }
   private static efl_layout_calc_auto_update_hints_set_delegate efl_layout_calc_auto_update_hints_set_static_delegate;


    private delegate Eina.Size2D_StructInternal efl_layout_calc_size_min_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Size2D_StructInternal restricted);


    public delegate Eina.Size2D_StructInternal efl_layout_calc_size_min_api_delegate(System.IntPtr obj,   Eina.Size2D_StructInternal restricted);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_size_min_api_delegate> efl_layout_calc_size_min_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_size_min_api_delegate>(_Module, "efl_layout_calc_size_min");
    private static Eina.Size2D_StructInternal calc_size_min(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D_StructInternal restricted)
   {
      Eina.Log.Debug("function efl_layout_calc_size_min was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_restricted = Eina.Size2D_StructConversion.ToManaged(restricted);
                     Eina.Size2D _ret_var = default(Eina.Size2D);
         try {
            _ret_var = ((Calc)wrapper).CalcSizeMin( _in_restricted);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return Eina.Size2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_layout_calc_size_min_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  restricted);
      }
   }
   private static efl_layout_calc_size_min_delegate efl_layout_calc_size_min_static_delegate;


    private delegate Eina.Rect_StructInternal efl_layout_calc_parts_extends_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Rect_StructInternal efl_layout_calc_parts_extends_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_parts_extends_api_delegate> efl_layout_calc_parts_extends_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_parts_extends_api_delegate>(_Module, "efl_layout_calc_parts_extends");
    private static Eina.Rect_StructInternal calc_parts_extends(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_layout_calc_parts_extends was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Rect _ret_var = default(Eina.Rect);
         try {
            _ret_var = ((Calc)wrapper).CalcPartsExtends();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Rect_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_layout_calc_parts_extends_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_layout_calc_parts_extends_delegate efl_layout_calc_parts_extends_static_delegate;


    private delegate  int efl_layout_calc_freeze_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  int efl_layout_calc_freeze_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_freeze_api_delegate> efl_layout_calc_freeze_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_freeze_api_delegate>(_Module, "efl_layout_calc_freeze");
    private static  int calc_freeze(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_layout_calc_freeze was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   int _ret_var = default( int);
         try {
            _ret_var = ((Calc)wrapper).FreezeCalc();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_layout_calc_freeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_layout_calc_freeze_delegate efl_layout_calc_freeze_static_delegate;


    private delegate  int efl_layout_calc_thaw_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  int efl_layout_calc_thaw_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_thaw_api_delegate> efl_layout_calc_thaw_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_thaw_api_delegate>(_Module, "efl_layout_calc_thaw");
    private static  int calc_thaw(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_layout_calc_thaw was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   int _ret_var = default( int);
         try {
            _ret_var = ((Calc)wrapper).ThawCalc();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_layout_calc_thaw_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_layout_calc_thaw_delegate efl_layout_calc_thaw_static_delegate;


    private delegate  void efl_layout_calc_force_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_layout_calc_force_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_layout_calc_force_api_delegate> efl_layout_calc_force_ptr = new Efl.Eo.FunctionWrapper<efl_layout_calc_force_api_delegate>(_Module, "efl_layout_calc_force");
    private static  void calc_force(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_layout_calc_force was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Calc)wrapper).CalcForce();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_layout_calc_force_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_layout_calc_force_delegate efl_layout_calc_force_static_delegate;
}
} } 
