//
// Cairo.cs - a simplistic binding of the Cairo API to C#.
//
// Authors: Duncan Mak (duncan@ximian.com)
//          Hisham Mardam Bey (hisham.mardambey@gmail.com)
//          John Luke (john.luke@gmail.com)
//          Alp Toker (alp@atoker.com)
//
// (C) Ximian, Inc. 2003
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
// Copyright (C) 2005 John Luke
// Copyright (C) 2006 Alp Toker
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
// ReSharper disable All

namespace Cairo
{
	// sort the functions like in the following page so it is easier to find what is missing
	// http://cairographics.org/manual/index-all.html

	internal static class NativeMethods
	{
		const string cairo = "libcairo.so.2";
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_arc_delegate (IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);
		public static cairo_arc_delegate cairo_arc => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_arc_delegate>("cairo_arc");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_arc_negative_delegate (IntPtr cr, double xc, double yc, double radius, double angle1, double angle2);
		public static cairo_arc_negative_delegate cairo_arc_negative => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_arc_negative_delegate>("cairo_arc_negative");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_atsui_font_face_create_for_atsu_font_id_delegate (IntPtr font_id);
		public static cairo_atsui_font_face_create_for_atsu_font_id_delegate cairo_atsui_font_face_create_for_atsu_font_id => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_atsui_font_face_create_for_atsu_font_id_delegate>("cairo_atsui_font_face_create_for_atsu_font_id");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_clip_delegate (IntPtr cr);
		public static cairo_clip_delegate cairo_clip => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_clip_delegate>("cairo_clip");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_clip_preserve_delegate (IntPtr cr);
		public static cairo_clip_preserve_delegate cairo_clip_preserve => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_clip_preserve_delegate>("cairo_clip_preserve");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_clip_extents_delegate (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
		public static cairo_clip_extents_delegate cairo_clip_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_clip_extents_delegate>("cairo_clip_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_close_path_delegate (IntPtr cr);
		public static cairo_close_path_delegate cairo_close_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_close_path_delegate>("cairo_close_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_copy_page_delegate (IntPtr cr);
		public static cairo_copy_page_delegate cairo_copy_page => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_copy_page_delegate>("cairo_copy_page");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_copy_path_delegate (IntPtr cr);
		public static cairo_copy_path_delegate cairo_copy_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_copy_path_delegate>("cairo_copy_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_copy_path_flat_delegate (IntPtr cr);
		public static cairo_copy_path_flat_delegate cairo_copy_path_flat => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_copy_path_flat_delegate>("cairo_copy_path_flat");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_append_path_delegate (IntPtr cr, IntPtr path);
		public static cairo_append_path_delegate cairo_append_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_append_path_delegate>("cairo_append_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_create_delegate (IntPtr target);
		public static cairo_create_delegate cairo_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_create_delegate>("cairo_create");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_curve_to_delegate (IntPtr cr, double x1, double y1, double x2, double y2, double x3, double y3);
		public static cairo_curve_to_delegate cairo_curve_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_curve_to_delegate>("cairo_curve_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_debug_reset_static_data_delegate ();
		public static cairo_debug_reset_static_data_delegate cairo_debug_reset_static_data => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_debug_reset_static_data_delegate>("cairo_debug_reset_static_data");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_destroy_delegate (IntPtr cr);
		public static cairo_destroy_delegate cairo_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_destroy_delegate>("cairo_destroy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_device_to_user_delegate (IntPtr cr, ref double x, ref double y);
		public static cairo_device_to_user_delegate cairo_device_to_user => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_device_to_user_delegate>("cairo_device_to_user");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_device_to_user_distance_delegate (IntPtr cr, ref double dx, ref double dy);
		public static cairo_device_to_user_distance_delegate cairo_device_to_user_distance => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_device_to_user_distance_delegate>("cairo_device_to_user_distance");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_fill_delegate (IntPtr cr);
		public static cairo_fill_delegate cairo_fill => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_fill_delegate>("cairo_fill");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_fill_extents_delegate (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
		public static cairo_fill_extents_delegate cairo_fill_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_fill_extents_delegate>("cairo_fill_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_fill_preserve_delegate (IntPtr cr);
		public static cairo_fill_preserve_delegate cairo_fill_preserve => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_fill_preserve_delegate>("cairo_fill_preserve");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_extents_delegate (IntPtr cr, out FontExtents extents);
		public static cairo_font_extents_delegate cairo_font_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_extents_delegate>("cairo_font_extents");
		
		// FontFace
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_face_destroy_delegate (IntPtr font_face);
		public static cairo_font_face_destroy_delegate cairo_font_face_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_face_destroy_delegate>("cairo_font_face_destroy");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FontType cairo_font_face_get_type_delegate (IntPtr font_face);
		public static cairo_font_face_get_type_delegate cairo_font_face_get_type => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_face_get_type_delegate>("cairo_font_face_get_type");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_font_face_reference_delegate (IntPtr font_face);
		public static cairo_font_face_reference_delegate cairo_font_face_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_face_reference_delegate>("cairo_font_face_reference");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_font_face_status_delegate (IntPtr font_face);
		public static cairo_font_face_status_delegate cairo_font_face_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_face_status_delegate>("cairo_font_face_status");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint cairo_font_face_get_reference_count_delegate (IntPtr surface);
		public static cairo_font_face_get_reference_count_delegate cairo_font_face_get_reference_count => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_face_get_reference_count_delegate>("cairo_font_face_get_reference_count");
		
		// FontOptions
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_font_options_copy_delegate (IntPtr original);
		public static cairo_font_options_copy_delegate cairo_font_options_copy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_copy_delegate>("cairo_font_options_copy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_font_options_create_delegate ();
		public static cairo_font_options_create_delegate cairo_font_options_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_create_delegate>("cairo_font_options_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_destroy_delegate (IntPtr options);
		public static cairo_font_options_destroy_delegate cairo_font_options_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_destroy_delegate>("cairo_font_options_destroy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.U1)]
		public delegate bool cairo_font_options_equal_delegate (IntPtr options, IntPtr other);
		public static cairo_font_options_equal_delegate cairo_font_options_equal => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_equal_delegate>("cairo_font_options_equal");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Antialias cairo_font_options_get_antialias_delegate (IntPtr options);
		public static cairo_font_options_get_antialias_delegate cairo_font_options_get_antialias => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_get_antialias_delegate>("cairo_font_options_get_antialias");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate HintMetrics cairo_font_options_get_hint_metrics_delegate (IntPtr options);
		public static cairo_font_options_get_hint_metrics_delegate cairo_font_options_get_hint_metrics => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_get_hint_metrics_delegate>("cairo_font_options_get_hint_metrics");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate HintStyle cairo_font_options_get_hint_style_delegate (IntPtr options);
		public static cairo_font_options_get_hint_style_delegate cairo_font_options_get_hint_style => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_get_hint_style_delegate>("cairo_font_options_get_hint_style");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate SubpixelOrder cairo_font_options_get_subpixel_order_delegate (IntPtr options);
		public static cairo_font_options_get_subpixel_order_delegate cairo_font_options_get_subpixel_order => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_get_subpixel_order_delegate>("cairo_font_options_get_subpixel_order");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long cairo_font_options_hash_delegate (IntPtr options);
		public static cairo_font_options_hash_delegate cairo_font_options_hash => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_hash_delegate>("cairo_font_options_hash");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_merge_delegate (IntPtr options, IntPtr other);
		public static cairo_font_options_merge_delegate cairo_font_options_merge => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_merge_delegate>("cairo_font_options_merge");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_set_antialias_delegate (IntPtr options, Antialias aa);
		public static cairo_font_options_set_antialias_delegate cairo_font_options_set_antialias => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_set_antialias_delegate>("cairo_font_options_set_antialias");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_set_hint_metrics_delegate (IntPtr options, HintMetrics metrics);
		public static cairo_font_options_set_hint_metrics_delegate cairo_font_options_set_hint_metrics => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_set_hint_metrics_delegate>("cairo_font_options_set_hint_metrics");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_set_hint_style_delegate (IntPtr options, HintStyle style);
		public static cairo_font_options_set_hint_style_delegate cairo_font_options_set_hint_style => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_set_hint_style_delegate>("cairo_font_options_set_hint_style");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_font_options_set_subpixel_order_delegate (IntPtr options, SubpixelOrder order);
		public static cairo_font_options_set_subpixel_order_delegate cairo_font_options_set_subpixel_order => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_set_subpixel_order_delegate>("cairo_font_options_set_subpixel_order");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_font_options_status_delegate (IntPtr options);
		public static cairo_font_options_status_delegate cairo_font_options_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_font_options_status_delegate>("cairo_font_options_status");
		
		// Freetype / FontConfig 
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_ft_font_face_create_for_ft_face_delegate (IntPtr face, int load_flags);
		public static cairo_ft_font_face_create_for_ft_face_delegate cairo_ft_font_face_create_for_ft_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ft_font_face_create_for_ft_face_delegate>("cairo_ft_font_face_create_for_ft_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_ft_font_face_create_for_pattern_delegate (IntPtr fc_pattern);
		public static cairo_ft_font_face_create_for_pattern_delegate cairo_ft_font_face_create_for_pattern => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ft_font_face_create_for_pattern_delegate>("cairo_ft_font_face_create_for_pattern");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ft_font_options_substitute_delegate (FontOptions options, IntPtr pattern);
		public static cairo_ft_font_options_substitute_delegate cairo_ft_font_options_substitute => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ft_font_options_substitute_delegate>("cairo_ft_font_options_substitute");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_ft_scaled_font_lock_face_delegate (IntPtr scaled_font);
		public static cairo_ft_scaled_font_lock_face_delegate cairo_ft_scaled_font_lock_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ft_scaled_font_lock_face_delegate>("cairo_ft_scaled_font_lock_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ft_scaled_font_unlock_face_delegate (IntPtr scaled_font);
		public static cairo_ft_scaled_font_unlock_face_delegate cairo_ft_scaled_font_unlock_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ft_scaled_font_unlock_face_delegate>("cairo_ft_scaled_font_unlock_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Antialias cairo_get_antialias_delegate (IntPtr cr);
		public static cairo_get_antialias_delegate cairo_get_antialias => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_antialias_delegate>("cairo_get_antialias");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_get_current_point_delegate (IntPtr cr, out double x, out double y);
		public static cairo_get_current_point_delegate cairo_get_current_point => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_current_point_delegate>("cairo_get_current_point");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FillRule cairo_get_fill_rule_delegate (IntPtr cr);
		public static cairo_get_fill_rule_delegate cairo_get_fill_rule => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_fill_rule_delegate>("cairo_get_fill_rule");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_get_font_face_delegate (IntPtr cr);
		public static cairo_get_font_face_delegate cairo_get_font_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_font_face_delegate>("cairo_get_font_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_get_font_matrix_delegate (IntPtr cr, out Matrix matrix);
		public static cairo_get_font_matrix_delegate cairo_get_font_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_font_matrix_delegate>("cairo_get_font_matrix");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_get_font_options_delegate (IntPtr cr, IntPtr options);
		public static cairo_get_font_options_delegate cairo_get_font_options => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_font_options_delegate>("cairo_get_font_options");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_get_group_target_delegate (IntPtr cr);
		public static cairo_get_group_target_delegate cairo_get_group_target => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_group_target_delegate>("cairo_get_group_target");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate LineCap cairo_get_line_cap_delegate (IntPtr cr);
		public static cairo_get_line_cap_delegate cairo_get_line_cap => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_line_cap_delegate>("cairo_get_line_cap");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate LineJoin cairo_get_line_join_delegate (IntPtr cr);
		public static cairo_get_line_join_delegate cairo_get_line_join => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_line_join_delegate>("cairo_get_line_join");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate double cairo_get_line_width_delegate (IntPtr cr);
		public static cairo_get_line_width_delegate cairo_get_line_width => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_line_width_delegate>("cairo_get_line_width");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_get_matrix_delegate (IntPtr cr, Matrix matrix);
		public static cairo_get_matrix_delegate cairo_get_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_matrix_delegate>("cairo_get_matrix");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate double cairo_get_miter_limit_delegate (IntPtr cr);
		public static cairo_get_miter_limit_delegate cairo_get_miter_limit => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_miter_limit_delegate>("cairo_get_miter_limit");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Operator cairo_get_operator_delegate (IntPtr cr);
		public static cairo_get_operator_delegate cairo_get_operator => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_operator_delegate>("cairo_get_operator");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint cairo_get_reference_count_delegate (IntPtr surface);
		public static cairo_get_reference_count_delegate cairo_get_reference_count => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_reference_count_delegate>("cairo_get_reference_count");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_get_source_delegate (IntPtr cr);
		public static cairo_get_source_delegate cairo_get_source => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_source_delegate>("cairo_get_source");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_get_target_delegate (IntPtr cr);
		public static cairo_get_target_delegate cairo_get_target => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_target_delegate>("cairo_get_target");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate double cairo_get_tolerance_delegate (IntPtr cr);
		public static cairo_get_tolerance_delegate cairo_get_tolerance => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_tolerance_delegate>("cairo_get_tolerance");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_glitz_surface_create_delegate (IntPtr surface);
		public static cairo_glitz_surface_create_delegate cairo_glitz_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_glitz_surface_create_delegate>("cairo_glitz_surface_create");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_glyph_extents_delegate (IntPtr cr, IntPtr glyphs, int num_glyphs, out TextExtents extents);
		public static cairo_glyph_extents_delegate cairo_glyph_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_glyph_extents_delegate>("cairo_glyph_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_glyph_path_delegate (IntPtr cr, IntPtr glyphs, int num_glyphs);
		public static cairo_glyph_path_delegate cairo_glyph_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_glyph_path_delegate>("cairo_glyph_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.U1)]
		public delegate bool cairo_has_current_point_delegate (IntPtr cr);
		public static cairo_has_current_point_delegate cairo_has_current_point => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_has_current_point_delegate>("cairo_has_current_point");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_identity_matrix_delegate (IntPtr cr);
		public static cairo_identity_matrix_delegate cairo_identity_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_identity_matrix_delegate>("cairo_identity_matrix");
		
		// ImageSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_image_surface_create_delegate (Cairo.Format format, int width, int height);
		public static cairo_image_surface_create_delegate cairo_image_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_create_delegate>("cairo_image_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_image_surface_create_for_data_delegate (byte[] data, Cairo.Format format, int width, int height, int stride);
		public static cairo_image_surface_create_for_data_delegate cairo_image_surface_create_for_data => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_create_for_data_delegate>("cairo_image_surface_create_for_data");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_image_surface_create_for_data_ptr_delegate (IntPtr data, Cairo.Format format, int width, int height, int stride);
		public static cairo_image_surface_create_for_data_ptr_delegate cairo_image_surface_create_for_data_ptr => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_create_for_data_ptr_delegate>("cairo_image_surface_create_for_data");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_image_surface_create_from_png_delegate (string filename);
		public static cairo_image_surface_create_from_png_delegate cairo_image_surface_create_from_png => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_create_from_png_delegate>("cairo_image_surface_create_from_png");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_image_surface_get_data_delegate (IntPtr surface);
		public static cairo_image_surface_get_data_delegate cairo_image_surface_get_data => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_get_data_delegate>("cairo_image_surface_get_data");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Format cairo_image_surface_get_format_delegate (IntPtr surface);
		public static cairo_image_surface_get_format_delegate cairo_image_surface_get_format => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_get_format_delegate>("cairo_image_surface_get_format");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_image_surface_get_height_delegate (IntPtr surface);
		public static cairo_image_surface_get_height_delegate cairo_image_surface_get_height => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_get_height_delegate>("cairo_image_surface_get_height");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_image_surface_get_stride_delegate (IntPtr surface);
		public static cairo_image_surface_get_stride_delegate cairo_image_surface_get_stride => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_get_stride_delegate>("cairo_image_surface_get_stride");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_image_surface_get_width_delegate (IntPtr surface);
		public static cairo_image_surface_get_width_delegate cairo_image_surface_get_width => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_image_surface_get_width_delegate>("cairo_image_surface_get_width");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.U1)]
		public delegate bool cairo_in_clip_delegate (IntPtr cr, double x, double y);
		public static cairo_in_clip_delegate cairo_in_clip => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_in_clip_delegate>("cairo_in_clip");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.U1)]
		public delegate bool cairo_in_fill_delegate (IntPtr cr, double x, double y);
		public static cairo_in_fill_delegate cairo_in_fill => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_in_fill_delegate>("cairo_in_fill");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[return: MarshalAs (UnmanagedType.U1)]
		public delegate bool cairo_in_stroke_delegate (IntPtr cr, double x, double y);
		public static cairo_in_stroke_delegate cairo_in_stroke => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_in_stroke_delegate>("cairo_in_stroke");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_line_to_delegate (IntPtr cr, double x, double y);
		public static cairo_line_to_delegate cairo_line_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_line_to_delegate>("cairo_line_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_mask_delegate (IntPtr cr, IntPtr pattern);
		public static cairo_mask_delegate cairo_mask => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_mask_delegate>("cairo_mask");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_mask_surface_delegate (IntPtr cr, IntPtr surface, double x, double y);
		public static cairo_mask_surface_delegate cairo_mask_surface => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_mask_surface_delegate>("cairo_mask_surface");
		
		// Matrix
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_init_delegate (Matrix matrix, double xx, double yx, double xy, double yy, double x0, double y0);
		public static cairo_matrix_init_delegate cairo_matrix_init => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_init_delegate>("cairo_matrix_init");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_init_identity_delegate (Matrix matrix);
		public static cairo_matrix_init_identity_delegate cairo_matrix_init_identity => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_init_identity_delegate>("cairo_matrix_init_identity");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_init_rotate_delegate (Matrix matrix, double radians);
		public static cairo_matrix_init_rotate_delegate cairo_matrix_init_rotate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_init_rotate_delegate>("cairo_matrix_init_rotate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_init_scale_delegate (Matrix matrix, double sx, double sy);
		public static cairo_matrix_init_scale_delegate cairo_matrix_init_scale => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_init_scale_delegate>("cairo_matrix_init_scale");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_init_translate_delegate (Matrix matrix, double tx, double ty);
		public static cairo_matrix_init_translate_delegate cairo_matrix_init_translate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_init_translate_delegate>("cairo_matrix_init_translate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_matrix_invert_delegate (Matrix matrix);
		public static cairo_matrix_invert_delegate cairo_matrix_invert => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_invert_delegate>("cairo_matrix_invert");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_multiply_delegate (Matrix result, Matrix a, Matrix b);
		public static cairo_matrix_multiply_delegate cairo_matrix_multiply => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_multiply_delegate>("cairo_matrix_multiply");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_scale_delegate (Matrix matrix, double sx, double sy);
		public static cairo_matrix_scale_delegate cairo_matrix_scale => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_scale_delegate>("cairo_matrix_scale");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_rotate_delegate (Matrix matrix, double radians);
		public static cairo_matrix_rotate_delegate cairo_matrix_rotate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_rotate_delegate>("cairo_matrix_rotate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_transform_distance_delegate (Matrix matrix, ref double dx, ref double dy);
		public static cairo_matrix_transform_distance_delegate cairo_matrix_transform_distance => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_transform_distance_delegate>("cairo_matrix_transform_distance");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_transform_point_delegate (Matrix matrix, ref double x, ref double y);
		public static cairo_matrix_transform_point_delegate cairo_matrix_transform_point => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_transform_point_delegate>("cairo_matrix_transform_point");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_matrix_translate_delegate (Matrix matrix, double tx, double ty);
		public static cairo_matrix_translate_delegate cairo_matrix_translate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_matrix_translate_delegate>("cairo_matrix_translate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_move_to_delegate (IntPtr cr, double x, double y);
		public static cairo_move_to_delegate cairo_move_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_move_to_delegate>("cairo_move_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_new_path_delegate (IntPtr cr);
		public static cairo_new_path_delegate cairo_new_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_new_path_delegate>("cairo_new_path");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_new_sub_path_delegate (IntPtr cr);
		public static cairo_new_sub_path_delegate cairo_new_sub_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_new_sub_path_delegate>("cairo_new_sub_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_paint_delegate (IntPtr cr);
		public static cairo_paint_delegate cairo_paint => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_paint_delegate>("cairo_paint");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_paint_with_alpha_delegate (IntPtr cr, double alpha);
		public static cairo_paint_with_alpha_delegate cairo_paint_with_alpha => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_paint_with_alpha_delegate>("cairo_paint_with_alpha");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_path_destroy_delegate (IntPtr path);
		public static cairo_path_destroy_delegate cairo_path_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_path_destroy_delegate>("cairo_path_destroy");
		
		// Pattern
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_add_color_stop_rgb_delegate (IntPtr pattern, double offset, double red, double green, double blue);
		public static cairo_pattern_add_color_stop_rgb_delegate cairo_pattern_add_color_stop_rgb => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_add_color_stop_rgb_delegate>("cairo_pattern_add_color_stop_rgb");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_add_color_stop_rgba_delegate (IntPtr pattern, double offset, double red, double green, double blue, double alpha);
		public static cairo_pattern_add_color_stop_rgba_delegate cairo_pattern_add_color_stop_rgba => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_add_color_stop_rgba_delegate>("cairo_pattern_add_color_stop_rgba");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_color_stop_count_delegate (IntPtr pattern, out int count);
		public static cairo_pattern_get_color_stop_count_delegate cairo_pattern_get_color_stop_count => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_color_stop_count_delegate>("cairo_pattern_get_color_stop_count");
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_color_stop_rgba_delegate (IntPtr pattern, int index, out double offset, out double red, out double green, out double blue, out double alpha);
		public static cairo_pattern_get_color_stop_rgba_delegate cairo_pattern_get_color_stop_rgba => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_color_stop_rgba_delegate>("cairo_pattern_get_color_stop_rgba");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_create_for_surface_delegate (IntPtr surface);
		public static cairo_pattern_create_for_surface_delegate cairo_pattern_create_for_surface => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_create_for_surface_delegate>("cairo_pattern_create_for_surface");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_surface_delegate (IntPtr pattern, out IntPtr surface);
		public static cairo_pattern_get_surface_delegate cairo_pattern_get_surface => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_surface_delegate>("cairo_pattern_get_surface");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_create_linear_delegate (double x0, double y0, double x1, double y1);
		public static cairo_pattern_create_linear_delegate cairo_pattern_create_linear => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_create_linear_delegate>("cairo_pattern_create_linear");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_linear_points_delegate (IntPtr pattern, out double x0, out double y0, out double x1, out double y1);
		public static cairo_pattern_get_linear_points_delegate cairo_pattern_get_linear_points => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_linear_points_delegate>("cairo_pattern_get_linear_points");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_create_radial_delegate (double cx0, double cy0, double radius0, double cx1, double cy1, double radius1);
		public static cairo_pattern_create_radial_delegate cairo_pattern_create_radial => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_create_radial_delegate>("cairo_pattern_create_radial");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_radial_circles_delegate (IntPtr pattern, out double x0, out double y0, out double r0, out double x1, out double y1, out double r1);
		public static cairo_pattern_get_radial_circles_delegate cairo_pattern_get_radial_circles => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_radial_circles_delegate>("cairo_pattern_get_radial_circles");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_create_rgb_delegate (double r, double g, double b);
		public static cairo_pattern_create_rgb_delegate cairo_pattern_create_rgb => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_create_rgb_delegate>("cairo_pattern_create_rgb");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_create_rgba_delegate (double r, double g, double b, double a);
		public static cairo_pattern_create_rgba_delegate cairo_pattern_create_rgba => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_create_rgba_delegate>("cairo_pattern_create_rgba");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_get_rgba_delegate (IntPtr pattern, out double red, out double green, out double blue, out double alpha);
		public static cairo_pattern_get_rgba_delegate cairo_pattern_get_rgba => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_rgba_delegate>("cairo_pattern_get_rgba");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_destroy_delegate (IntPtr pattern);
		public static cairo_pattern_destroy_delegate cairo_pattern_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_destroy_delegate>("cairo_pattern_destroy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Extend cairo_pattern_get_extend_delegate (IntPtr pattern);
		public static cairo_pattern_get_extend_delegate cairo_pattern_get_extend => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_extend_delegate>("cairo_pattern_get_extend");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Filter cairo_pattern_get_filter_delegate (IntPtr pattern);
		public static cairo_pattern_get_filter_delegate cairo_pattern_get_filter => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_filter_delegate>("cairo_pattern_get_filter");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_get_matrix_delegate (IntPtr pattern, Matrix matrix);
		public static cairo_pattern_get_matrix_delegate cairo_pattern_get_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_matrix_delegate>("cairo_pattern_get_matrix");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate PatternType cairo_pattern_get_type_delegate (IntPtr pattern);
		public static cairo_pattern_get_type_delegate cairo_pattern_get_type => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_get_type_delegate>("cairo_pattern_get_type");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pattern_reference_delegate (IntPtr pattern);
		public static cairo_pattern_reference_delegate cairo_pattern_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_reference_delegate>("cairo_pattern_reference");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_set_extend_delegate (IntPtr pattern, Extend extend);
		public static cairo_pattern_set_extend_delegate cairo_pattern_set_extend => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_set_extend_delegate>("cairo_pattern_set_extend");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_set_filter_delegate (IntPtr pattern, Filter filter);
		public static cairo_pattern_set_filter_delegate cairo_pattern_set_filter => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_set_filter_delegate>("cairo_pattern_set_filter");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pattern_set_matrix_delegate (IntPtr pattern, Matrix matrix);
		public static cairo_pattern_set_matrix_delegate cairo_pattern_set_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_set_matrix_delegate>("cairo_pattern_set_matrix");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_pattern_status_delegate (IntPtr pattern);
		public static cairo_pattern_status_delegate cairo_pattern_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pattern_status_delegate>("cairo_pattern_status");
	
		// PdfSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pdf_surface_create_delegate (string filename, double width, double height);
		public static cairo_pdf_surface_create_delegate cairo_pdf_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pdf_surface_create_delegate>("cairo_pdf_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pdf_surface_set_size_delegate (IntPtr surface, double x, double y);
		public static cairo_pdf_surface_set_size_delegate cairo_pdf_surface_set_size => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pdf_surface_set_size_delegate>("cairo_pdf_surface_set_size");
		
		// PostscriptSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_ps_surface_create_delegate (string filename, double width, double height);
		public static cairo_ps_surface_create_delegate cairo_ps_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ps_surface_create_delegate>("cairo_ps_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ps_surface_dsc_begin_page_setup_delegate (IntPtr surface);
		public static cairo_ps_surface_dsc_begin_page_setup_delegate cairo_ps_surface_dsc_begin_page_setup => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ps_surface_dsc_begin_page_setup_delegate>("cairo_ps_surface_dsc_begin_page_setup");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ps_surface_dsc_begin_setup_delegate (IntPtr surface);
		public static cairo_ps_surface_dsc_begin_setup_delegate cairo_ps_surface_dsc_begin_setup => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ps_surface_dsc_begin_setup_delegate>("cairo_ps_surface_dsc_begin_setup");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ps_surface_dsc_comment_delegate (IntPtr surface, string comment);
		public static cairo_ps_surface_dsc_comment_delegate cairo_ps_surface_dsc_comment => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ps_surface_dsc_comment_delegate>("cairo_ps_surface_dsc_comment");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_ps_surface_set_size_delegate (IntPtr surface, double x, double y);
		public static cairo_ps_surface_set_size_delegate cairo_ps_surface_set_size => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_ps_surface_set_size_delegate>("cairo_ps_surface_set_size");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_pop_group_delegate (IntPtr cr);
		public static cairo_pop_group_delegate cairo_pop_group => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pop_group_delegate>("cairo_pop_group");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_pop_group_to_source_delegate (IntPtr cr);
		public static cairo_pop_group_to_source_delegate cairo_pop_group_to_source => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_pop_group_to_source_delegate>("cairo_pop_group_to_source");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_push_group_delegate (IntPtr cr);
		public static cairo_push_group_delegate cairo_push_group => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_push_group_delegate>("cairo_push_group");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_push_group_with_content_delegate (IntPtr cr, Content content);
		public static cairo_push_group_with_content_delegate cairo_push_group_with_content => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_push_group_with_content_delegate>("cairo_push_group_with_content");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_quartz_surface_create_delegate (IntPtr context, bool flipped, int width, int height);
		public static cairo_quartz_surface_create_delegate cairo_quartz_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_quartz_surface_create_delegate>("cairo_quartz_surface_create");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rectangle_delegate (IntPtr cr, double x, double y, double width, double height);
		public static cairo_rectangle_delegate cairo_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rectangle_delegate>("cairo_rectangle");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_reference_delegate (IntPtr cr);
		public static cairo_reference_delegate cairo_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_reference_delegate>("cairo_reference");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool cairo_region_contains_point_delegate (IntPtr region, int x, int y);
		public static cairo_region_contains_point_delegate cairo_region_contains_point => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_contains_point_delegate>("cairo_region_contains_point");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate RegionOverlap cairo_region_contains_rectangle_delegate (IntPtr region, ref RectangleInt rectangle);
		public static cairo_region_contains_rectangle_delegate cairo_region_contains_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_contains_rectangle_delegate>("cairo_region_contains_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_region_copy_delegate (IntPtr original);
		public static cairo_region_copy_delegate cairo_region_copy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_copy_delegate>("cairo_region_copy");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_region_create_delegate ();
		public static cairo_region_create_delegate cairo_region_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_create_delegate>("cairo_region_create");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_region_create_rectangle_delegate (ref RectangleInt rect);
		public static cairo_region_create_rectangle_delegate cairo_region_create_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_create_rectangle_delegate>("cairo_region_create_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_region_create_rectangles_delegate (RectangleInt[] rects, int count);
		public static cairo_region_create_rectangles_delegate cairo_region_create_rectangles => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_create_rectangles_delegate>("cairo_region_create_rectangles");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_region_destroy_delegate (IntPtr region);
		public static cairo_region_destroy_delegate cairo_region_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_destroy_delegate>("cairo_region_destroy");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool cairo_region_equal_delegate (IntPtr a, IntPtr b);
		public static cairo_region_equal_delegate cairo_region_equal => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_equal_delegate>("cairo_region_equal");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_region_get_extents_delegate (IntPtr region, out RectangleInt extents);
		public static cairo_region_get_extents_delegate cairo_region_get_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_get_extents_delegate>("cairo_region_get_extents");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_region_get_rectangle_delegate (IntPtr region, int nth, out RectangleInt rectangle);
		public static cairo_region_get_rectangle_delegate cairo_region_get_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_get_rectangle_delegate>("cairo_region_get_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_intersect_delegate (IntPtr dst, IntPtr other);
		public static cairo_region_intersect_delegate cairo_region_intersect => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_intersect_delegate>("cairo_region_intersect");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_intersect_rectangle_delegate (IntPtr dst, ref RectangleInt rectangle);
		public static cairo_region_intersect_rectangle_delegate cairo_region_intersect_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_intersect_rectangle_delegate>("cairo_region_intersect_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool cairo_region_is_empty_delegate (IntPtr region);
		public static cairo_region_is_empty_delegate cairo_region_is_empty => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_is_empty_delegate>("cairo_region_is_empty");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_region_num_rectangles_delegate (IntPtr region);
		public static cairo_region_num_rectangles_delegate cairo_region_num_rectangles => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_num_rectangles_delegate>("cairo_region_num_rectangles");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_region_reference_delegate (IntPtr region);
		public static cairo_region_reference_delegate cairo_region_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_reference_delegate>("cairo_region_reference");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_status_delegate (IntPtr region);
		public static cairo_region_status_delegate cairo_region_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_status_delegate>("cairo_region_status");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_subtract_delegate (IntPtr dst, IntPtr other);
		public static cairo_region_subtract_delegate cairo_region_subtract => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_subtract_delegate>("cairo_region_subtract");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_subtract_rectangle_delegate (IntPtr dst, ref RectangleInt rectangle);
		public static cairo_region_subtract_rectangle_delegate cairo_region_subtract_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_subtract_rectangle_delegate>("cairo_region_subtract_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_region_translate_delegate (IntPtr region, int dx, int dy);
		public static cairo_region_translate_delegate cairo_region_translate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_translate_delegate>("cairo_region_translate");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_union_delegate (IntPtr dst, IntPtr other);
		public static cairo_region_union_delegate cairo_region_union => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_union_delegate>("cairo_region_union");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_union_rectangle_delegate (IntPtr dst, ref RectangleInt rectangle);
		public static cairo_region_union_rectangle_delegate cairo_region_union_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_union_rectangle_delegate>("cairo_region_union_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_xor_delegate (IntPtr dst, IntPtr other);
		public static cairo_region_xor_delegate cairo_region_xor => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_xor_delegate>("cairo_region_xor");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_region_xor_rectangle_delegate (IntPtr dst, ref RectangleInt rectangle);
		public static cairo_region_xor_rectangle_delegate cairo_region_xor_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_region_xor_rectangle_delegate>("cairo_region_xor_rectangle");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rel_curve_to_delegate (IntPtr cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);
		public static cairo_rel_curve_to_delegate cairo_rel_curve_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rel_curve_to_delegate>("cairo_rel_curve_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rel_line_to_delegate (IntPtr cr, double dx, double dy);
		public static cairo_rel_line_to_delegate cairo_rel_line_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rel_line_to_delegate>("cairo_rel_line_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rel_move_to_delegate (IntPtr cr, double dx, double dy);
		public static cairo_rel_move_to_delegate cairo_rel_move_to => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rel_move_to_delegate>("cairo_rel_move_to");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_reset_clip_delegate (IntPtr cr);
		public static cairo_reset_clip_delegate cairo_reset_clip => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_reset_clip_delegate>("cairo_reset_clip");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_restore_delegate (IntPtr cr);
		public static cairo_restore_delegate cairo_restore => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_restore_delegate>("cairo_restore");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rotate_delegate (IntPtr cr, double angle);
		public static cairo_rotate_delegate cairo_rotate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rotate_delegate>("cairo_rotate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_save_delegate (IntPtr cr);
		public static cairo_save_delegate cairo_save => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_save_delegate>("cairo_save");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scale_delegate (IntPtr cr, double sx, double sy);
		public static cairo_scale_delegate cairo_scale => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scale_delegate>("cairo_scale");
		
		// ScaledFont
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_scaled_font_create_delegate (IntPtr fontFace, Matrix matrix, Matrix ctm, IntPtr options);
		public static cairo_scaled_font_create_delegate cairo_scaled_font_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_create_delegate>("cairo_scaled_font_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_scaled_font_destroy_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_destroy_delegate cairo_scaled_font_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_destroy_delegate>("cairo_scaled_font_destroy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scaled_font_extents_delegate (IntPtr scaled_font, out FontExtents extents);
		public static cairo_scaled_font_extents_delegate cairo_scaled_font_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_extents_delegate>("cairo_scaled_font_extents");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scaled_font_get_ctm_delegate (IntPtr scaled_font, out Matrix matrix);
		public static cairo_scaled_font_get_ctm_delegate cairo_scaled_font_get_ctm => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_get_ctm_delegate>("cairo_scaled_font_get_ctm");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_scaled_font_get_font_face_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_get_font_face_delegate cairo_scaled_font_get_font_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_get_font_face_delegate>("cairo_scaled_font_get_font_face");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scaled_font_get_font_matrix_delegate (IntPtr scaled_font, out Matrix matrix);
		public static cairo_scaled_font_get_font_matrix_delegate cairo_scaled_font_get_font_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_get_font_matrix_delegate>("cairo_scaled_font_get_font_matrix");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_scaled_font_get_font_options_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_get_font_options_delegate cairo_scaled_font_get_font_options => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_get_font_options_delegate>("cairo_scaled_font_get_font_options");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FontType cairo_scaled_font_get_type_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_get_type_delegate cairo_scaled_font_get_type => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_get_type_delegate>("cairo_scaled_font_get_type");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scaled_font_glyph_extents_delegate (IntPtr scaled_font, IntPtr glyphs, int num_glyphs, out TextExtents extents);
		public static cairo_scaled_font_glyph_extents_delegate cairo_scaled_font_glyph_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_glyph_extents_delegate>("cairo_scaled_font_glyph_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_scaled_font_reference_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_reference_delegate cairo_scaled_font_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_reference_delegate>("cairo_scaled_font_reference");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_scaled_font_status_delegate (IntPtr scaled_font);
		public static cairo_scaled_font_status_delegate cairo_scaled_font_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_status_delegate>("cairo_scaled_font_status");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_scaled_font_delegate (IntPtr cr, IntPtr scaled_font);
		public static cairo_set_scaled_font_delegate cairo_set_scaled_font => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_scaled_font_delegate>("cairo_set_scaled_font");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_get_scaled_font_delegate (IntPtr cr);
		public static cairo_get_scaled_font_delegate cairo_get_scaled_font => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_scaled_font_delegate>("cairo_get_scaled_font");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_scaled_font_text_extents_delegate (IntPtr scaled_font, byte[] utf8, out TextExtents extents);
		public static cairo_scaled_font_text_extents_delegate cairo_scaled_font_text_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_scaled_font_text_extents_delegate>("cairo_scaled_font_text_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_select_font_face_delegate (IntPtr cr, string family, FontSlant slant, FontWeight weight);
		public static cairo_select_font_face_delegate cairo_select_font_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_select_font_face_delegate>("cairo_select_font_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_antialias_delegate (IntPtr cr, Antialias antialias);
		public static cairo_set_antialias_delegate cairo_set_antialias => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_antialias_delegate>("cairo_set_antialias");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_dash_delegate (IntPtr cr, double [] dashes, int ndash, double offset);
		public static cairo_set_dash_delegate cairo_set_dash => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_dash_delegate>("cairo_set_dash");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_get_dash_delegate (IntPtr cr, IntPtr dashes, out double offset);
		public static cairo_get_dash_delegate cairo_get_dash => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_dash_delegate>("cairo_get_dash");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_get_dash_count_delegate (IntPtr cr);
		public static cairo_get_dash_count_delegate cairo_get_dash_count => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_get_dash_count_delegate>("cairo_get_dash_count");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_fill_rule_delegate (IntPtr cr, Cairo.FillRule fill_rule);
		public static cairo_set_fill_rule_delegate cairo_set_fill_rule => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_fill_rule_delegate>("cairo_set_fill_rule");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_font_face_delegate (IntPtr cr, IntPtr fontFace);
		public static cairo_set_font_face_delegate cairo_set_font_face => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_font_face_delegate>("cairo_set_font_face");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_font_matrix_delegate (IntPtr cr, Matrix matrix);
		public static cairo_set_font_matrix_delegate cairo_set_font_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_font_matrix_delegate>("cairo_set_font_matrix");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_font_options_delegate (IntPtr cr, IntPtr options);
		public static cairo_set_font_options_delegate cairo_set_font_options => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_font_options_delegate>("cairo_set_font_options");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_font_size_delegate (IntPtr cr, double size);
		public static cairo_set_font_size_delegate cairo_set_font_size => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_font_size_delegate>("cairo_set_font_size");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_line_cap_delegate (IntPtr cr, LineCap line_cap);
		public static cairo_set_line_cap_delegate cairo_set_line_cap => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_line_cap_delegate>("cairo_set_line_cap");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_line_join_delegate (IntPtr cr, LineJoin line_join);
		public static cairo_set_line_join_delegate cairo_set_line_join => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_line_join_delegate>("cairo_set_line_join");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_line_width_delegate (IntPtr cr, double width);
		public static cairo_set_line_width_delegate cairo_set_line_width => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_line_width_delegate>("cairo_set_line_width");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_matrix_delegate (IntPtr cr, Matrix matrix);
		public static cairo_set_matrix_delegate cairo_set_matrix => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_matrix_delegate>("cairo_set_matrix");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_miter_limit_delegate (IntPtr cr, double limit);
		public static cairo_set_miter_limit_delegate cairo_set_miter_limit => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_miter_limit_delegate>("cairo_set_miter_limit");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_operator_delegate (IntPtr cr, Cairo.Operator op);
		public static cairo_set_operator_delegate cairo_set_operator => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_operator_delegate>("cairo_set_operator");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_source_delegate (IntPtr cr, IntPtr pattern);
		public static cairo_set_source_delegate cairo_set_source => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_source_delegate>("cairo_set_source");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_source_rgb_delegate (IntPtr cr, double red, double green, double blue);
		public static cairo_set_source_rgb_delegate cairo_set_source_rgb => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_source_rgb_delegate>("cairo_set_source_rgb");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_source_rgba_delegate (IntPtr cr, double red, double green, double blue, double alpha);
		public static cairo_set_source_rgba_delegate cairo_set_source_rgba => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_source_rgba_delegate>("cairo_set_source_rgba");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_source_surface_delegate (IntPtr cr, IntPtr surface, double x, double y);
		public static cairo_set_source_surface_delegate cairo_set_source_surface => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_source_surface_delegate>("cairo_set_source_surface");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_set_tolerance_delegate (IntPtr cr, double tolerance);
		public static cairo_set_tolerance_delegate cairo_set_tolerance => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_set_tolerance_delegate>("cairo_set_tolerance");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_show_glyphs_delegate (IntPtr ct, IntPtr glyphs, int num_glyphs);
		public static cairo_show_glyphs_delegate cairo_show_glyphs => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_show_glyphs_delegate>("cairo_show_glyphs");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_show_page_delegate (IntPtr cr);
		public static cairo_show_page_delegate cairo_show_page => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_show_page_delegate>("cairo_show_page");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_show_text_delegate (IntPtr cr, byte[] utf8);
		public static cairo_show_text_delegate cairo_show_text => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_show_text_delegate>("cairo_show_text");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_status_delegate (IntPtr cr);
		public static cairo_status_delegate cairo_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_status_delegate>("cairo_status");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_status_to_string_delegate (Status status);
		public static cairo_status_to_string_delegate cairo_status_to_string => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_status_to_string_delegate>("cairo_status_to_string");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_stroke_delegate (IntPtr cr);
		public static cairo_stroke_delegate cairo_stroke => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_stroke_delegate>("cairo_stroke");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_stroke_extents_delegate (IntPtr cr, out double x1, out double y1, out double x2, out double y2);
		public static cairo_stroke_extents_delegate cairo_stroke_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_stroke_extents_delegate>("cairo_stroke_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_stroke_preserve_delegate (IntPtr cr);
		public static cairo_stroke_preserve_delegate cairo_stroke_preserve => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_stroke_preserve_delegate>("cairo_stroke_preserve");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_rectangle_list_destroy_delegate (IntPtr rectangle_list);
		public static cairo_rectangle_list_destroy_delegate cairo_rectangle_list_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_rectangle_list_destroy_delegate>("cairo_rectangle_list_destroy");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_copy_clip_rectangle_list_delegate (IntPtr cr);
		public static cairo_copy_clip_rectangle_list_delegate cairo_copy_clip_rectangle_list => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_copy_clip_rectangle_list_delegate>("cairo_copy_clip_rectangle_list");

		// Surface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_surface_create_similar_delegate (IntPtr surface, Cairo.Content content, int width, int height);
		public static cairo_surface_create_similar_delegate cairo_surface_create_similar => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_create_similar_delegate>("cairo_surface_create_similar");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_destroy_delegate (IntPtr surface);
		public static cairo_surface_destroy_delegate cairo_surface_destroy => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_destroy_delegate>("cairo_surface_destroy");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_finish_delegate (IntPtr surface);
		public static cairo_surface_finish_delegate cairo_surface_finish => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_finish_delegate>("cairo_surface_finish");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_flush_delegate (IntPtr surface);
		public static cairo_surface_flush_delegate cairo_surface_flush => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_flush_delegate>("cairo_surface_flush");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Content cairo_surface_get_content_delegate (IntPtr surface);
		public static cairo_surface_get_content_delegate cairo_surface_get_content => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_get_content_delegate>("cairo_surface_get_content");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_get_device_offset_delegate (IntPtr surface, out double x, out double y);
		public static cairo_surface_get_device_offset_delegate cairo_surface_get_device_offset => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_get_device_offset_delegate>("cairo_surface_get_device_offset");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_get_font_options_delegate (IntPtr surface, IntPtr FontOptions);
		public static cairo_surface_get_font_options_delegate cairo_surface_get_font_options => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_get_font_options_delegate>("cairo_surface_get_font_options");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint cairo_surface_get_reference_count_delegate (IntPtr surface);
		public static cairo_surface_get_reference_count_delegate cairo_surface_get_reference_count => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_get_reference_count_delegate>("cairo_surface_get_reference_count");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate SurfaceType cairo_surface_get_type_delegate (IntPtr surface);
		public static cairo_surface_get_type_delegate cairo_surface_get_type => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_get_type_delegate>("cairo_surface_get_type");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_mark_dirty_delegate (IntPtr surface);
		public static cairo_surface_mark_dirty_delegate cairo_surface_mark_dirty => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_mark_dirty_delegate>("cairo_surface_mark_dirty");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_mark_dirty_rectangle_delegate (IntPtr surface, int x, int y, int width, int height);
		public static cairo_surface_mark_dirty_rectangle_delegate cairo_surface_mark_dirty_rectangle => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_mark_dirty_rectangle_delegate>("cairo_surface_mark_dirty_rectangle");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_surface_reference_delegate (IntPtr surface);
		public static cairo_surface_reference_delegate cairo_surface_reference => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_reference_delegate>("cairo_surface_reference");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_set_device_offset_delegate (IntPtr surface, double x, double y);
		public static cairo_surface_set_device_offset_delegate cairo_surface_set_device_offset => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_set_device_offset_delegate>("cairo_surface_set_device_offset");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_set_fallback_resolution_delegate (IntPtr surface, double x, double y);
		public static cairo_surface_set_fallback_resolution_delegate cairo_surface_set_fallback_resolution => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_set_fallback_resolution_delegate>("cairo_surface_set_fallback_resolution");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_surface_status_delegate (IntPtr surface);
		public static cairo_surface_status_delegate cairo_surface_status => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_status_delegate>("cairo_surface_status");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_surface_write_to_png_delegate (IntPtr surface, string filename);
		public static cairo_surface_write_to_png_delegate cairo_surface_write_to_png => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_surface_write_to_png_delegate>("cairo_surface_write_to_png");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_svg_surface_create_delegate (string fileName, double width, double height);
		public static cairo_svg_surface_create_delegate cairo_svg_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_svg_surface_create_delegate>("cairo_svg_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_svg_surface_restrict_to_version_delegate (IntPtr surface, SvgVersion version);
		public static cairo_svg_surface_restrict_to_version_delegate cairo_svg_surface_restrict_to_version => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_svg_surface_restrict_to_version_delegate>("cairo_svg_surface_restrict_to_version");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_text_extents_delegate (IntPtr cr, byte[] utf8, out TextExtents extents);
		public static cairo_text_extents_delegate cairo_text_extents => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_text_extents_delegate>("cairo_text_extents");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_text_path_delegate (IntPtr ct, byte[] utf8);
		public static cairo_text_path_delegate cairo_text_path => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_text_path_delegate>("cairo_text_path");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_transform_delegate (IntPtr cr, Matrix matrix);
		public static cairo_transform_delegate cairo_transform => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_transform_delegate>("cairo_transform");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_translate_delegate (IntPtr cr, double tx, double ty);
		public static cairo_translate_delegate cairo_translate => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_translate_delegate>("cairo_translate");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_user_to_device_delegate (IntPtr cr, ref double x, ref double y);
		public static cairo_user_to_device_delegate cairo_user_to_device => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_user_to_device_delegate>("cairo_user_to_device");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_user_to_device_distance_delegate (IntPtr cr, ref double dx, ref double dy);
		public static cairo_user_to_device_distance_delegate cairo_user_to_device_distance => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_user_to_device_distance_delegate>("cairo_user_to_device_distance");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_version_delegate ();
		public static cairo_version_delegate cairo_version => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_version_delegate>("cairo_version");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_version_string_delegate ();
		public static cairo_version_string_delegate cairo_version_string => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_version_string_delegate>("cairo_version_string");
		
		// DirectFBSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_directfb_surface_create_delegate (IntPtr dfb, IntPtr surface);
		public static cairo_directfb_surface_create_delegate cairo_directfb_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_directfb_surface_create_delegate>("cairo_directfb_surface_create");
		
		// win32 fonts
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_win32_font_face_create_for_logfontw_delegate (IntPtr logfontw);
		public static cairo_win32_font_face_create_for_logfontw_delegate cairo_win32_font_face_create_for_logfontw => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_font_face_create_for_logfontw_delegate>("cairo_win32_font_face_create_for_logfontw");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_win32_scaled_font_done_font_delegate (IntPtr scaled_font);
		public static cairo_win32_scaled_font_done_font_delegate cairo_win32_scaled_font_done_font => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_scaled_font_done_font_delegate>("cairo_win32_scaled_font_done_font");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate double cairo_win32_scaled_font_get_metrics_factor_delegate (IntPtr scaled_font);
		public static cairo_win32_scaled_font_get_metrics_factor_delegate cairo_win32_scaled_font_get_metrics_factor => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_scaled_font_get_metrics_factor_delegate>("cairo_win32_scaled_font_get_metrics_factor");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate Status cairo_win32_scaled_font_select_font_delegate (IntPtr scaled_font, IntPtr hdc);
		public static cairo_win32_scaled_font_select_font_delegate cairo_win32_scaled_font_select_font => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_scaled_font_select_font_delegate>("cairo_win32_scaled_font_select_font");
		
		// win32 surface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_win32_surface_create_delegate (IntPtr hdc);
		public static cairo_win32_surface_create_delegate cairo_win32_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_surface_create_delegate>("cairo_win32_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_win32_surface_create_with_ddb_delegate (IntPtr hdc, Format format, int width, int height);
		public static cairo_win32_surface_create_with_ddb_delegate cairo_win32_surface_create_with_ddb => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_win32_surface_create_with_ddb_delegate>("cairo_win32_surface_create_with_ddb");

		// XcbSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xcb_surface_create_delegate (IntPtr connection, uint drawable, IntPtr visual, int width, int height);
		public static cairo_xcb_surface_create_delegate cairo_xcb_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xcb_surface_create_delegate>("cairo_xcb_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xcb_surface_create_for_bitmap_delegate (IntPtr connection, uint bitmap, IntPtr screen, int width, int height);
		public static cairo_xcb_surface_create_for_bitmap_delegate cairo_xcb_surface_create_for_bitmap => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xcb_surface_create_for_bitmap_delegate>("cairo_xcb_surface_create_for_bitmap");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_xcb_surface_set_size_delegate (IntPtr surface, int width, int height);
		public static cairo_xcb_surface_set_size_delegate cairo_xcb_surface_set_size => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xcb_surface_set_size_delegate>("cairo_xcb_surface_set_size");
		
		// XlibSurface
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_create_delegate (IntPtr display, IntPtr drawable, IntPtr visual, int width, int height);
		public static cairo_xlib_surface_create_delegate cairo_xlib_surface_create => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_create_delegate>("cairo_xlib_surface_create");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_create_for_bitmap_delegate (IntPtr display, IntPtr bitmap, IntPtr screen, int width, int height);
		public static cairo_xlib_surface_create_for_bitmap_delegate cairo_xlib_surface_create_for_bitmap => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_create_for_bitmap_delegate>("cairo_xlib_surface_create_for_bitmap");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_xlib_surface_get_depth_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_depth_delegate cairo_xlib_surface_get_depth => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_depth_delegate>("cairo_xlib_surface_get_depth");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_get_display_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_display_delegate cairo_xlib_surface_get_display => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_display_delegate>("cairo_xlib_surface_get_display");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_get_drawable_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_drawable_delegate cairo_xlib_surface_get_drawable => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_drawable_delegate>("cairo_xlib_surface_get_drawable");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_xlib_surface_get_height_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_height_delegate cairo_xlib_surface_get_height => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_height_delegate>("cairo_xlib_surface_get_height");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_get_screen_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_screen_delegate cairo_xlib_surface_get_screen => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_screen_delegate>("cairo_xlib_surface_get_screen");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cairo_xlib_surface_get_visual_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_visual_delegate cairo_xlib_surface_get_visual => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_visual_delegate>("cairo_xlib_surface_get_visual");

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cairo_xlib_surface_get_width_delegate (IntPtr surface);
		public static cairo_xlib_surface_get_width_delegate cairo_xlib_surface_get_width => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_get_width_delegate>("cairo_xlib_surface_get_width");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_xlib_surface_set_drawable_delegate (IntPtr surface, IntPtr drawable, int width, int height);
		public static cairo_xlib_surface_set_drawable_delegate cairo_xlib_surface_set_drawable => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_set_drawable_delegate>("cairo_xlib_surface_set_drawable");
		
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void cairo_xlib_surface_set_size_delegate (IntPtr surface, int width, int height);
		public static cairo_xlib_surface_set_size_delegate cairo_xlib_surface_set_size => Cairo.DynLoader.NativeDllHelper.GetDllImport<cairo_xlib_surface_set_size_delegate>("cairo_xlib_surface_set_size");
	}
}
