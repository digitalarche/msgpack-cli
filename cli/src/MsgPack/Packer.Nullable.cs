﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;

namespace MsgPack
{
	// This file generated from Packer.Nullable.tt T4Template.
	// Do not modify this file. Edit Packer.Nullable.tt instead.

	partial class Packer
	{
		/// <summary>
		///		Pack nullable <see cref="SByte"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer Pack( SByte? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( SByte? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="SByte"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer PackStrict( SByte? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( SByte? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Byte"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Byte? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( Byte? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Byte"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Byte? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( Byte? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int16"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Int16? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( Int16? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int16"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Int16? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( Int16? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt16"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer Pack( UInt16? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( UInt16? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt16"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer PackStrict( UInt16? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( UInt16? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int32"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Int32? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( Int32? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int32"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Int32? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( Int32? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt32"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer Pack( UInt32? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( UInt32? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt32"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer PackStrict( UInt32? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( UInt32? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int64"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Int64? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( Int64? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Int64"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Int64? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( Int64? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt64"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer Pack( UInt64? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		private void PrivatePackCore( UInt64? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="UInt64"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		[CLSCompliant( false )]
		public Packer PackStrict( UInt64? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		private void PrivatePackStrictCore( UInt64? value )
		{
			if ( value.HasValue )
			{
				this.PrivatePackStrictCore( value.Value );
			}
			else
			{
				this.PrivatePackNullCore();
			}
		}
		/// <summary>
		///		Pack nullable <see cref="Single"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Single? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		/// <summary>
		///		Pack nullable <see cref="Single"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Single? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		/// <summary>
		///		Pack nullable <see cref="Double"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Double? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
		/// <summary>
		///		Pack nullable <see cref="Double"/> value without message size compression.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer PackStrict( Double? value )
		{
			return value.HasValue ? this.PackStrict( value.Value ) : this.PackNull();
		}
		
		/// <summary>
		///		Pack nullable <see cref="Boolean"/> value.
		/// </summary>
		/// <param name="value">Value to serialize.</param>
		/// <returns>This packer instance.</returns>
		public Packer Pack( Boolean? value )
		{
			return value.HasValue ? this.Pack( value.Value ) : this.PackNull();
		}
	}
}