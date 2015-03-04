
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glBlendFuncSeparateINGR.
		/// </summary>
		/// <param name="sfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_INGR_blend_func_separate")]
		public static void BlendFuncSeparateINGR(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateINGR != null, "pglBlendFuncSeparateINGR not implemented");
			Delegates.pglBlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			CallLog("glBlendFuncSeparateINGR({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			DebugCheckErrors();
		}

	}

}