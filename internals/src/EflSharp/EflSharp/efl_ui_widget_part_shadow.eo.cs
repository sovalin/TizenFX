#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>A drop-shadow or glow effect around any widget.
/// A simple drop-shadow effect can be applied to any widget by setting the color and blur radius on this part.
/// 
/// For instance, a blue glow can be achieved with: obj.shadow().color_set(0, 128, 255, 255); obj.shadow().grow_set(2); obj.shadow().radius_set(3, 3);
/// 
/// As another example, here&apos;s a black drop-shadow: obj.shadow().color_set(0, 0, 0, 255); obj.shadow().grow_set(1); obj.shadow().radius_set(5, 5); obj.shadow().offset_set(5, 5);
/// 
/// It is also possible to manually specify which <see cref="Efl.Gfx.Filter"/> program to use.</summary>
[WidgetPartShadowNativeInherit]
public class WidgetPartShadow : Efl.Ui.WidgetPart, Efl.Eo.IWrapper,Efl.Gfx.Blur,Efl.Gfx.Color,Efl.Gfx.Filter
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Ui.WidgetPartShadowNativeInherit nativeInherit = new Efl.Ui.WidgetPartShadowNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (WidgetPartShadow))
            return Efl.Ui.WidgetPartShadowNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      efl_ui_widget_part_shadow_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   public WidgetPartShadow(Efl.Object parent= null
         ) :
      base(efl_ui_widget_part_shadow_class_get(), typeof(WidgetPartShadow), parent)
   {
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public WidgetPartShadow(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected WidgetPartShadow(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static WidgetPartShadow static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new WidgetPartShadow(obj.NativeHandle);
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
   protected override void register_event_proxies()
   {
      base.register_event_proxies();
   }
   /// <summary>The blur radius in pixels.</summary>
   /// <param name="rx">The horizontal blur radius.</param>
   /// <param name="ry">The vertical blur radius.</param>
   /// <returns></returns>
   virtual public  void GetRadius( out double rx,  out double ry) {
                                           Efl.Gfx.BlurNativeInherit.efl_gfx_blur_radius_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out rx,  out ry);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>The blur radius in pixels.</summary>
   /// <param name="rx">The horizontal blur radius.</param>
   /// <param name="ry">The vertical blur radius.</param>
   /// <returns></returns>
   virtual public  void SetRadius( double rx,  double ry) {
                                           Efl.Gfx.BlurNativeInherit.efl_gfx_blur_radius_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), rx,  ry);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>An offset relative to the original pixels.
   /// This property allows for drop shadow effects.</summary>
   /// <param name="ox">Horizontal offset in pixels.</param>
   /// <param name="oy">Vertical offset in pixels.</param>
   /// <returns></returns>
   virtual public  void GetOffset( out double ox,  out double oy) {
                                           Efl.Gfx.BlurNativeInherit.efl_gfx_blur_offset_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out ox,  out oy);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>An offset relative to the original pixels.
   /// This property allows for drop shadow effects.</summary>
   /// <param name="ox">Horizontal offset in pixels.</param>
   /// <param name="oy">Vertical offset in pixels.</param>
   /// <returns></returns>
   virtual public  void SetOffset( double ox,  double oy) {
                                           Efl.Gfx.BlurNativeInherit.efl_gfx_blur_offset_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), ox,  oy);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>How much the original image should be &quot;grown&quot; before blurring.
   /// Growing is a combination of blur &amp; color levels adjustment. If the value of grow is positive, the pixels will appear more &quot;fat&quot; or &quot;bold&quot; than the original. If the value is negative, a shrink effect happens instead.
   /// 
   /// This is can be used efficiently to create glow effects.</summary>
   /// <returns>How much to grow the original pixel data.</returns>
   virtual public double GetGrow() {
       var _ret_var = Efl.Gfx.BlurNativeInherit.efl_gfx_blur_grow_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>How much the original image should be &quot;grown&quot; before blurring.
   /// Growing is a combination of blur &amp; color levels adjustment. If the value of grow is positive, the pixels will appear more &quot;fat&quot; or &quot;bold&quot; than the original. If the value is negative, a shrink effect happens instead.
   /// 
   /// This is can be used efficiently to create glow effects.</summary>
   /// <param name="radius">How much to grow the original pixel data.</param>
   /// <returns></returns>
   virtual public  void SetGrow( double radius) {
                         Efl.Gfx.BlurNativeInherit.efl_gfx_blur_grow_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), radius);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Retrieves the general/main color of the given Evas object.
   /// Retrieves the main color&apos;s RGB component (and alpha channel) values, which range from 0 to 255. For the alpha channel, which defines the object&apos;s transparency level, 0 means totally transparent, while 255 means opaque. These color values are premultiplied by the alpha value.
   /// 
   /// Usually youll use this attribute for text and rectangle objects, where the main color is their unique one. If set for objects which themselves have colors, like the images one, those colors get modulated by this one.
   /// 
   /// All newly created Evas rectangles get the default color values of 255 255 255 255 (opaque white).
   /// 
   /// Use null pointers on the components you&apos;re not interested in: they&apos;ll be ignored by the function.</summary>
   /// <param name="r"></param>
   /// <param name="g"></param>
   /// <param name="b"></param>
   /// <param name="a"></param>
   /// <returns></returns>
   virtual public  void GetColor( out  int r,  out  int g,  out  int b,  out  int a) {
                                                                               Efl.Gfx.ColorNativeInherit.efl_gfx_color_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out r,  out g,  out b,  out a);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Sets the general/main color of the given Evas object to the given one.
   /// See also <see cref="Efl.Gfx.Color.GetColor"/> (for an example)
   /// 
   /// These color values are expected to be premultiplied by alpha.</summary>
   /// <param name="r"></param>
   /// <param name="g"></param>
   /// <param name="b"></param>
   /// <param name="a"></param>
   /// <returns></returns>
   virtual public  void SetColor(  int r,   int g,   int b,   int a) {
                                                                               Efl.Gfx.ColorNativeInherit.efl_gfx_color_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), r,  g,  b,  a);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Get hex color code of given Evas object. This returns a short lived hex color code string.</summary>
   /// <returns>the hex color code.</returns>
   virtual public  System.String GetColorCode() {
       var _ret_var = Efl.Gfx.ColorNativeInherit.efl_gfx_color_code_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the color of given Evas object to the given hex color code(#RRGGBBAA). e.g. efl_gfx_color_code_set(obj, &quot;#FFCCAACC&quot;);</summary>
   /// <param name="colorcode">the hex color code.</param>
   /// <returns></returns>
   virtual public  void SetColorCode(  System.String colorcode) {
                         Efl.Gfx.ColorNativeInherit.efl_gfx_color_code_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), colorcode);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Gets the code of the filter program set on this object. May be <c>null</c>.
   /// 1.18</summary>
   /// <param name="code">The Lua program source code.
   /// 1.18</param>
   /// <param name="name">An optional name for this filter.
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void GetFilterProgram( out  System.String code,  out  System.String name) {
                                           Efl.Gfx.FilterNativeInherit.efl_gfx_filter_program_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out code,  out name);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set a graphical filter program on this object.
   /// Valid for Text and Image objects at the moment.
   /// 
   /// The argument passed to this function is a string containing a valid Lua program based on the filters API as described in the &quot;EFL Graphics Filters&quot; reference page.
   /// 
   /// Set to <c>null</c> to disable filtering.
   /// 1.18</summary>
   /// <param name="code">The Lua program source code.
   /// 1.18</param>
   /// <param name="name">An optional name for this filter.
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void SetFilterProgram(  System.String code,   System.String name) {
                                           Efl.Gfx.FilterNativeInherit.efl_gfx_filter_program_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), code,  name);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set the current state of the filter.
   /// This should be used by Edje (EFL&apos;s internal layout engine), but could also be used when implementing animations programmatically.
   /// 
   /// A full state is defined by two states (name + value): origin state and target state of an ongoing animation, as well as the <c>pos</c> progress (from 0 to 1) of that animation timeline. The second state can be omitted if there is no ongoing animation.
   /// 1.18</summary>
   /// <param name="cur_state">Current state of the filter
   /// 1.18</param>
   /// <param name="cur_val">Current value
   /// 1.18</param>
   /// <param name="next_state">Next filter state, optional
   /// 1.18</param>
   /// <param name="next_val">Next value, optional
   /// 1.18</param>
   /// <param name="pos">Position, optional
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void GetFilterState( out  System.String cur_state,  out double cur_val,  out  System.String next_state,  out double next_val,  out double pos) {
                                                                                                 Efl.Gfx.FilterNativeInherit.efl_gfx_filter_state_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out cur_state,  out cur_val,  out next_state,  out next_val,  out pos);
      Eina.Error.RaiseIfUnhandledException();
                                                                   }
   /// <summary>Set the current state of the filter.
   /// This should be used by Edje (EFL&apos;s internal layout engine), but could also be used when implementing animations programmatically.
   /// 
   /// A full state is defined by two states (name + value): origin state and target state of an ongoing animation, as well as the <c>pos</c> progress (from 0 to 1) of that animation timeline. The second state can be omitted if there is no ongoing animation.
   /// 1.18</summary>
   /// <param name="cur_state">Current state of the filter
   /// 1.18</param>
   /// <param name="cur_val">Current value
   /// 1.18</param>
   /// <param name="next_state">Next filter state, optional
   /// 1.18</param>
   /// <param name="next_val">Next value, optional
   /// 1.18</param>
   /// <param name="pos">Position, optional
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void SetFilterState(  System.String cur_state,  double cur_val,   System.String next_state,  double next_val,  double pos) {
                                                                                                 Efl.Gfx.FilterNativeInherit.efl_gfx_filter_state_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), cur_state,  cur_val,  next_state,  next_val,  pos);
      Eina.Error.RaiseIfUnhandledException();
                                                                   }
   /// <summary>Gets the padding required to apply this filter.
   /// 1.18</summary>
   /// <param name="l">Padding on the left
   /// 1.18</param>
   /// <param name="r">Padding on the right
   /// 1.18</param>
   /// <param name="t">Padding on the top
   /// 1.18</param>
   /// <param name="b">Padding on the bottom
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void GetFilterPadding( out  int l,  out  int r,  out  int t,  out  int b) {
                                                                               Efl.Gfx.FilterNativeInherit.efl_gfx_filter_padding_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out l,  out r,  out t,  out b);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Bind an object to use as a mask or texture in a filter program.
   /// This will create automatically a new RGBA buffer containing the source object&apos;s pixels (as it is rendered).
   /// 1.18</summary>
   /// <param name="name">Buffer name as used in the program.
   /// 1.18</param>
   /// <returns>Object to use as a source of pixels.
   /// 1.18</returns>
   virtual public Efl.Gfx.Entity GetFilterSource(  System.String name) {
                         var _ret_var = Efl.Gfx.FilterNativeInherit.efl_gfx_filter_source_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Bind an object to use as a mask or texture in a filter program.
   /// This will create automatically a new RGBA buffer containing the source object&apos;s pixels (as it is rendered).
   /// 1.18</summary>
   /// <param name="name">Buffer name as used in the program.
   /// 1.18</param>
   /// <param name="source">Object to use as a source of pixels.
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void SetFilterSource(  System.String name,  Efl.Gfx.Entity source) {
                                           Efl.Gfx.FilterNativeInherit.efl_gfx_filter_source_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name,  source);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Extra data used by the filter program.
   /// Each data element is a string (<c>value</c>) stored as a global variable <c>name</c>. The program is then responsible for conversion to numbers, tables, etc...
   /// 
   /// If the <c>execute</c> flag is set, then the <c>value</c> can be complex and run, as if the original Lua program contained a line &apos;name = value&apos;. This can be used to pass in tables.
   /// 1.18</summary>
   /// <param name="name">Name of the global variable
   /// 1.18</param>
   /// <param name="value">String value to use as data
   /// 1.18</param>
   /// <param name="execute">If <c>true</c>, execute &apos;name = value&apos;
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void GetFilterData(  System.String name,  out  System.String value,  out bool execute) {
                                                             Efl.Gfx.FilterNativeInherit.efl_gfx_filter_data_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name,  out value,  out execute);
      Eina.Error.RaiseIfUnhandledException();
                                           }
   /// <summary>Extra data used by the filter program.
   /// Each data element is a string (<c>value</c>) stored as a global variable <c>name</c>. The program is then responsible for conversion to numbers, tables, etc...
   /// 
   /// If the <c>execute</c> flag is set, then the <c>value</c> can be complex and run, as if the original Lua program contained a line &apos;name = value&apos;. This can be used to pass in tables.
   /// 1.18</summary>
   /// <param name="name">Name of the global variable
   /// 1.18</param>
   /// <param name="value">String value to use as data
   /// 1.18</param>
   /// <param name="execute">If <c>true</c>, execute &apos;name = value&apos;
   /// 1.18</param>
   /// <returns></returns>
   virtual public  void SetFilterData(  System.String name,   System.String value,  bool execute) {
                                                             Efl.Gfx.FilterNativeInherit.efl_gfx_filter_data_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name,  value,  execute);
      Eina.Error.RaiseIfUnhandledException();
                                           }
   /// <summary>How much the original image should be &quot;grown&quot; before blurring.
/// Growing is a combination of blur &amp; color levels adjustment. If the value of grow is positive, the pixels will appear more &quot;fat&quot; or &quot;bold&quot; than the original. If the value is negative, a shrink effect happens instead.
/// 
/// This is can be used efficiently to create glow effects.</summary>
/// <value>How much to grow the original pixel data.</value>
   public double Grow {
      get { return GetGrow(); }
      set { SetGrow( value); }
   }
   /// <summary>Get hex color code of given Evas object. This returns a short lived hex color code string.</summary>
/// <value>the hex color code.</value>
   public  System.String ColorCode {
      get { return GetColorCode(); }
      set { SetColorCode( value); }
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.WidgetPartShadow.efl_ui_widget_part_shadow_class_get();
   }
}
public class WidgetPartShadowNativeInherit : Efl.Ui.WidgetPartNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_gfx_blur_radius_get_static_delegate == null)
      efl_gfx_blur_radius_get_static_delegate = new efl_gfx_blur_radius_get_delegate(radius_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_radius_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_radius_get_static_delegate)});
      if (efl_gfx_blur_radius_set_static_delegate == null)
      efl_gfx_blur_radius_set_static_delegate = new efl_gfx_blur_radius_set_delegate(radius_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_radius_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_radius_set_static_delegate)});
      if (efl_gfx_blur_offset_get_static_delegate == null)
      efl_gfx_blur_offset_get_static_delegate = new efl_gfx_blur_offset_get_delegate(offset_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_offset_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_offset_get_static_delegate)});
      if (efl_gfx_blur_offset_set_static_delegate == null)
      efl_gfx_blur_offset_set_static_delegate = new efl_gfx_blur_offset_set_delegate(offset_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_offset_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_offset_set_static_delegate)});
      if (efl_gfx_blur_grow_get_static_delegate == null)
      efl_gfx_blur_grow_get_static_delegate = new efl_gfx_blur_grow_get_delegate(grow_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_grow_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_grow_get_static_delegate)});
      if (efl_gfx_blur_grow_set_static_delegate == null)
      efl_gfx_blur_grow_set_static_delegate = new efl_gfx_blur_grow_set_delegate(grow_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_blur_grow_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_blur_grow_set_static_delegate)});
      if (efl_gfx_color_get_static_delegate == null)
      efl_gfx_color_get_static_delegate = new efl_gfx_color_get_delegate(color_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_get_static_delegate)});
      if (efl_gfx_color_set_static_delegate == null)
      efl_gfx_color_set_static_delegate = new efl_gfx_color_set_delegate(color_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_set_static_delegate)});
      if (efl_gfx_color_code_get_static_delegate == null)
      efl_gfx_color_code_get_static_delegate = new efl_gfx_color_code_get_delegate(color_code_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_code_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_code_get_static_delegate)});
      if (efl_gfx_color_code_set_static_delegate == null)
      efl_gfx_color_code_set_static_delegate = new efl_gfx_color_code_set_delegate(color_code_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_code_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_code_set_static_delegate)});
      if (efl_gfx_filter_program_get_static_delegate == null)
      efl_gfx_filter_program_get_static_delegate = new efl_gfx_filter_program_get_delegate(filter_program_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_program_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_program_get_static_delegate)});
      if (efl_gfx_filter_program_set_static_delegate == null)
      efl_gfx_filter_program_set_static_delegate = new efl_gfx_filter_program_set_delegate(filter_program_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_program_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_program_set_static_delegate)});
      if (efl_gfx_filter_state_get_static_delegate == null)
      efl_gfx_filter_state_get_static_delegate = new efl_gfx_filter_state_get_delegate(filter_state_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_state_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_state_get_static_delegate)});
      if (efl_gfx_filter_state_set_static_delegate == null)
      efl_gfx_filter_state_set_static_delegate = new efl_gfx_filter_state_set_delegate(filter_state_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_state_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_state_set_static_delegate)});
      if (efl_gfx_filter_padding_get_static_delegate == null)
      efl_gfx_filter_padding_get_static_delegate = new efl_gfx_filter_padding_get_delegate(filter_padding_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_padding_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_padding_get_static_delegate)});
      if (efl_gfx_filter_source_get_static_delegate == null)
      efl_gfx_filter_source_get_static_delegate = new efl_gfx_filter_source_get_delegate(filter_source_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_source_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_source_get_static_delegate)});
      if (efl_gfx_filter_source_set_static_delegate == null)
      efl_gfx_filter_source_set_static_delegate = new efl_gfx_filter_source_set_delegate(filter_source_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_source_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_source_set_static_delegate)});
      if (efl_gfx_filter_data_get_static_delegate == null)
      efl_gfx_filter_data_get_static_delegate = new efl_gfx_filter_data_get_delegate(filter_data_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_data_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_data_get_static_delegate)});
      if (efl_gfx_filter_data_set_static_delegate == null)
      efl_gfx_filter_data_set_static_delegate = new efl_gfx_filter_data_set_delegate(filter_data_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_filter_data_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_filter_data_set_static_delegate)});
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Ui.WidgetPartShadow.efl_ui_widget_part_shadow_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.WidgetPartShadow.efl_ui_widget_part_shadow_class_get();
   }


    private delegate  void efl_gfx_blur_radius_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double rx,   out double ry);


    public delegate  void efl_gfx_blur_radius_get_api_delegate(System.IntPtr obj,   out double rx,   out double ry);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_radius_get_api_delegate> efl_gfx_blur_radius_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_radius_get_api_delegate>(_Module, "efl_gfx_blur_radius_get");
    private static  void radius_get(System.IntPtr obj, System.IntPtr pd,  out double rx,  out double ry)
   {
      Eina.Log.Debug("function efl_gfx_blur_radius_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           rx = default(double);      ry = default(double);                     
         try {
            ((WidgetPartShadow)wrapper).GetRadius( out rx,  out ry);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_blur_radius_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out rx,  out ry);
      }
   }
   private static efl_gfx_blur_radius_get_delegate efl_gfx_blur_radius_get_static_delegate;


    private delegate  void efl_gfx_blur_radius_set_delegate(System.IntPtr obj, System.IntPtr pd,   double rx,   double ry);


    public delegate  void efl_gfx_blur_radius_set_api_delegate(System.IntPtr obj,   double rx,   double ry);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_radius_set_api_delegate> efl_gfx_blur_radius_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_radius_set_api_delegate>(_Module, "efl_gfx_blur_radius_set");
    private static  void radius_set(System.IntPtr obj, System.IntPtr pd,  double rx,  double ry)
   {
      Eina.Log.Debug("function efl_gfx_blur_radius_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((WidgetPartShadow)wrapper).SetRadius( rx,  ry);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_blur_radius_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  rx,  ry);
      }
   }
   private static efl_gfx_blur_radius_set_delegate efl_gfx_blur_radius_set_static_delegate;


    private delegate  void efl_gfx_blur_offset_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double ox,   out double oy);


    public delegate  void efl_gfx_blur_offset_get_api_delegate(System.IntPtr obj,   out double ox,   out double oy);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_offset_get_api_delegate> efl_gfx_blur_offset_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_offset_get_api_delegate>(_Module, "efl_gfx_blur_offset_get");
    private static  void offset_get(System.IntPtr obj, System.IntPtr pd,  out double ox,  out double oy)
   {
      Eina.Log.Debug("function efl_gfx_blur_offset_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           ox = default(double);      oy = default(double);                     
         try {
            ((WidgetPartShadow)wrapper).GetOffset( out ox,  out oy);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_blur_offset_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out ox,  out oy);
      }
   }
   private static efl_gfx_blur_offset_get_delegate efl_gfx_blur_offset_get_static_delegate;


    private delegate  void efl_gfx_blur_offset_set_delegate(System.IntPtr obj, System.IntPtr pd,   double ox,   double oy);


    public delegate  void efl_gfx_blur_offset_set_api_delegate(System.IntPtr obj,   double ox,   double oy);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_offset_set_api_delegate> efl_gfx_blur_offset_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_offset_set_api_delegate>(_Module, "efl_gfx_blur_offset_set");
    private static  void offset_set(System.IntPtr obj, System.IntPtr pd,  double ox,  double oy)
   {
      Eina.Log.Debug("function efl_gfx_blur_offset_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((WidgetPartShadow)wrapper).SetOffset( ox,  oy);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_blur_offset_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  ox,  oy);
      }
   }
   private static efl_gfx_blur_offset_set_delegate efl_gfx_blur_offset_set_static_delegate;


    private delegate double efl_gfx_blur_grow_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate double efl_gfx_blur_grow_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_grow_get_api_delegate> efl_gfx_blur_grow_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_grow_get_api_delegate>(_Module, "efl_gfx_blur_grow_get");
    private static double grow_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_blur_grow_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  double _ret_var = default(double);
         try {
            _ret_var = ((WidgetPartShadow)wrapper).GetGrow();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_blur_grow_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_blur_grow_get_delegate efl_gfx_blur_grow_get_static_delegate;


    private delegate  void efl_gfx_blur_grow_set_delegate(System.IntPtr obj, System.IntPtr pd,   double radius);


    public delegate  void efl_gfx_blur_grow_set_api_delegate(System.IntPtr obj,   double radius);
    public static Efl.Eo.FunctionWrapper<efl_gfx_blur_grow_set_api_delegate> efl_gfx_blur_grow_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_blur_grow_set_api_delegate>(_Module, "efl_gfx_blur_grow_set");
    private static  void grow_set(System.IntPtr obj, System.IntPtr pd,  double radius)
   {
      Eina.Log.Debug("function efl_gfx_blur_grow_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((WidgetPartShadow)wrapper).SetGrow( radius);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_blur_grow_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  radius);
      }
   }
   private static efl_gfx_blur_grow_set_delegate efl_gfx_blur_grow_set_static_delegate;


    private delegate  void efl_gfx_color_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int r,   out  int g,   out  int b,   out  int a);


    public delegate  void efl_gfx_color_get_api_delegate(System.IntPtr obj,   out  int r,   out  int g,   out  int b,   out  int a);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_get_api_delegate> efl_gfx_color_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_get_api_delegate>(_Module, "efl_gfx_color_get");
    private static  void color_get(System.IntPtr obj, System.IntPtr pd,  out  int r,  out  int g,  out  int b,  out  int a)
   {
      Eina.Log.Debug("function efl_gfx_color_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       r = default( int);      g = default( int);      b = default( int);      a = default( int);                                 
         try {
            ((WidgetPartShadow)wrapper).GetColor( out r,  out g,  out b,  out a);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_color_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out r,  out g,  out b,  out a);
      }
   }
   private static efl_gfx_color_get_delegate efl_gfx_color_get_static_delegate;


    private delegate  void efl_gfx_color_set_delegate(System.IntPtr obj, System.IntPtr pd,    int r,    int g,    int b,    int a);


    public delegate  void efl_gfx_color_set_api_delegate(System.IntPtr obj,    int r,    int g,    int b,    int a);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_set_api_delegate> efl_gfx_color_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_set_api_delegate>(_Module, "efl_gfx_color_set");
    private static  void color_set(System.IntPtr obj, System.IntPtr pd,   int r,   int g,   int b,   int a)
   {
      Eina.Log.Debug("function efl_gfx_color_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((WidgetPartShadow)wrapper).SetColor( r,  g,  b,  a);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_color_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  r,  g,  b,  a);
      }
   }
   private static efl_gfx_color_set_delegate efl_gfx_color_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_gfx_color_code_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_gfx_color_code_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_code_get_api_delegate> efl_gfx_color_code_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_code_get_api_delegate>(_Module, "efl_gfx_color_code_get");
    private static  System.String color_code_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_color_code_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((WidgetPartShadow)wrapper).GetColorCode();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_color_code_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_color_code_get_delegate efl_gfx_color_code_get_static_delegate;


    private delegate  void efl_gfx_color_code_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String colorcode);


    public delegate  void efl_gfx_color_code_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String colorcode);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_code_set_api_delegate> efl_gfx_color_code_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_code_set_api_delegate>(_Module, "efl_gfx_color_code_set");
    private static  void color_code_set(System.IntPtr obj, System.IntPtr pd,   System.String colorcode)
   {
      Eina.Log.Debug("function efl_gfx_color_code_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((WidgetPartShadow)wrapper).SetColorCode( colorcode);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_color_code_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  colorcode);
      }
   }
   private static efl_gfx_color_code_set_delegate efl_gfx_color_code_set_static_delegate;


    private delegate  void efl_gfx_filter_program_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String code,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String name);


    public delegate  void efl_gfx_filter_program_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String code,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String name);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_program_get_api_delegate> efl_gfx_filter_program_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_program_get_api_delegate>(_Module, "efl_gfx_filter_program_get");
    private static  void filter_program_get(System.IntPtr obj, System.IntPtr pd,  out  System.String code,  out  System.String name)
   {
      Eina.Log.Debug("function efl_gfx_filter_program_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                            System.String _out_code = default( System.String);
       System.String _out_name = default( System.String);
                     
         try {
            ((WidgetPartShadow)wrapper).GetFilterProgram( out _out_code,  out _out_name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      code = _out_code;
      name = _out_name;
                        } else {
         efl_gfx_filter_program_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out code,  out name);
      }
   }
   private static efl_gfx_filter_program_get_delegate efl_gfx_filter_program_get_static_delegate;


    private delegate  void efl_gfx_filter_program_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String code,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


    public delegate  void efl_gfx_filter_program_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String code,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_program_set_api_delegate> efl_gfx_filter_program_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_program_set_api_delegate>(_Module, "efl_gfx_filter_program_set");
    private static  void filter_program_set(System.IntPtr obj, System.IntPtr pd,   System.String code,   System.String name)
   {
      Eina.Log.Debug("function efl_gfx_filter_program_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((WidgetPartShadow)wrapper).SetFilterProgram( code,  name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_filter_program_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  code,  name);
      }
   }
   private static efl_gfx_filter_program_set_delegate efl_gfx_filter_program_set_static_delegate;


    private delegate  void efl_gfx_filter_state_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String cur_state,   out double cur_val,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String next_state,   out double next_val,   out double pos);


    public delegate  void efl_gfx_filter_state_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String cur_state,   out double cur_val,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String next_state,   out double next_val,   out double pos);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_state_get_api_delegate> efl_gfx_filter_state_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_state_get_api_delegate>(_Module, "efl_gfx_filter_state_get");
    private static  void filter_state_get(System.IntPtr obj, System.IntPtr pd,  out  System.String cur_state,  out double cur_val,  out  System.String next_state,  out double next_val,  out double pos)
   {
      Eina.Log.Debug("function efl_gfx_filter_state_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                              System.String _out_cur_state = default( System.String);
      cur_val = default(double);       System.String _out_next_state = default( System.String);
      next_val = default(double);      pos = default(double);                                       
         try {
            ((WidgetPartShadow)wrapper).GetFilterState( out _out_cur_state,  out cur_val,  out _out_next_state,  out next_val,  out pos);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      cur_state = _out_cur_state;
            next_state = _out_next_state;
                                                      } else {
         efl_gfx_filter_state_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out cur_state,  out cur_val,  out next_state,  out next_val,  out pos);
      }
   }
   private static efl_gfx_filter_state_get_delegate efl_gfx_filter_state_get_static_delegate;


    private delegate  void efl_gfx_filter_state_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String cur_state,   double cur_val,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String next_state,   double next_val,   double pos);


    public delegate  void efl_gfx_filter_state_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String cur_state,   double cur_val,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String next_state,   double next_val,   double pos);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_state_set_api_delegate> efl_gfx_filter_state_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_state_set_api_delegate>(_Module, "efl_gfx_filter_state_set");
    private static  void filter_state_set(System.IntPtr obj, System.IntPtr pd,   System.String cur_state,  double cur_val,   System.String next_state,  double next_val,  double pos)
   {
      Eina.Log.Debug("function efl_gfx_filter_state_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                            
         try {
            ((WidgetPartShadow)wrapper).SetFilterState( cur_state,  cur_val,  next_state,  next_val,  pos);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                        } else {
         efl_gfx_filter_state_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  cur_state,  cur_val,  next_state,  next_val,  pos);
      }
   }
   private static efl_gfx_filter_state_set_delegate efl_gfx_filter_state_set_static_delegate;


    private delegate  void efl_gfx_filter_padding_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int l,   out  int r,   out  int t,   out  int b);


    public delegate  void efl_gfx_filter_padding_get_api_delegate(System.IntPtr obj,   out  int l,   out  int r,   out  int t,   out  int b);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_padding_get_api_delegate> efl_gfx_filter_padding_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_padding_get_api_delegate>(_Module, "efl_gfx_filter_padding_get");
    private static  void filter_padding_get(System.IntPtr obj, System.IntPtr pd,  out  int l,  out  int r,  out  int t,  out  int b)
   {
      Eina.Log.Debug("function efl_gfx_filter_padding_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       l = default( int);      r = default( int);      t = default( int);      b = default( int);                                 
         try {
            ((WidgetPartShadow)wrapper).GetFilterPadding( out l,  out r,  out t,  out b);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_filter_padding_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out l,  out r,  out t,  out b);
      }
   }
   private static efl_gfx_filter_padding_get_delegate efl_gfx_filter_padding_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Entity efl_gfx_filter_source_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Entity efl_gfx_filter_source_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_source_get_api_delegate> efl_gfx_filter_source_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_source_get_api_delegate>(_Module, "efl_gfx_filter_source_get");
    private static Efl.Gfx.Entity filter_source_get(System.IntPtr obj, System.IntPtr pd,   System.String name)
   {
      Eina.Log.Debug("function efl_gfx_filter_source_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Gfx.Entity _ret_var = default(Efl.Gfx.Entity);
         try {
            _ret_var = ((WidgetPartShadow)wrapper).GetFilterSource( name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_gfx_filter_source_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name);
      }
   }
   private static efl_gfx_filter_source_get_delegate efl_gfx_filter_source_get_static_delegate;


    private delegate  void efl_gfx_filter_source_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Entity source);


    public delegate  void efl_gfx_filter_source_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Entity source);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_source_set_api_delegate> efl_gfx_filter_source_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_source_set_api_delegate>(_Module, "efl_gfx_filter_source_set");
    private static  void filter_source_set(System.IntPtr obj, System.IntPtr pd,   System.String name,  Efl.Gfx.Entity source)
   {
      Eina.Log.Debug("function efl_gfx_filter_source_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((WidgetPartShadow)wrapper).SetFilterSource( name,  source);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_filter_source_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name,  source);
      }
   }
   private static efl_gfx_filter_source_set_delegate efl_gfx_filter_source_set_static_delegate;


    private delegate  void efl_gfx_filter_data_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String value,  [MarshalAs(UnmanagedType.U1)]  out bool execute);


    public delegate  void efl_gfx_filter_data_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]  out  System.String value,  [MarshalAs(UnmanagedType.U1)]  out bool execute);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_data_get_api_delegate> efl_gfx_filter_data_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_data_get_api_delegate>(_Module, "efl_gfx_filter_data_get");
    private static  void filter_data_get(System.IntPtr obj, System.IntPtr pd,   System.String name,  out  System.String value,  out bool execute)
   {
      Eina.Log.Debug("function efl_gfx_filter_data_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                        System.String _out_value = default( System.String);
      execute = default(bool);                           
         try {
            ((WidgetPartShadow)wrapper).GetFilterData( name,  out _out_value,  out execute);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            value = _out_value;
                                    } else {
         efl_gfx_filter_data_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name,  out value,  out execute);
      }
   }
   private static efl_gfx_filter_data_get_delegate efl_gfx_filter_data_get_static_delegate;


    private delegate  void efl_gfx_filter_data_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String value,  [MarshalAs(UnmanagedType.U1)]  bool execute);


    public delegate  void efl_gfx_filter_data_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String value,  [MarshalAs(UnmanagedType.U1)]  bool execute);
    public static Efl.Eo.FunctionWrapper<efl_gfx_filter_data_set_api_delegate> efl_gfx_filter_data_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_filter_data_set_api_delegate>(_Module, "efl_gfx_filter_data_set");
    private static  void filter_data_set(System.IntPtr obj, System.IntPtr pd,   System.String name,   System.String value,  bool execute)
   {
      Eina.Log.Debug("function efl_gfx_filter_data_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        
         try {
            ((WidgetPartShadow)wrapper).SetFilterData( name,  value,  execute);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                } else {
         efl_gfx_filter_data_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name,  value,  execute);
      }
   }
   private static efl_gfx_filter_data_set_delegate efl_gfx_filter_data_set_static_delegate;
}
} } 
