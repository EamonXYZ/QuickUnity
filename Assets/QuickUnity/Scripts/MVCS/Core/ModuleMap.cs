﻿/*
 *	The MIT License (MIT)
 *
 *	Copyright (c) 2016 Jerry Lee
 *
 *	Permission is hereby granted, free of charge, to any person obtaining a copy
 *	of this software and associated documentation files (the "Software"), to deal
 *	in the Software without restriction, including without limitation the rights
 *	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *	copies of the Software, and to permit persons to whom the Software is
 *	furnished to do so, subject to the following conditions:
 *
 *	The above copyright notice and this permission notice shall be included in all
 *	copies or substantial portions of the Software.
 *
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *	SOFTWARE.
 */

using System;

namespace QuickUnity.MVCS
{
    /// <summary>
    /// An abstract <c>IModuleMap</c> implementation.
    /// </summary>
    public class ModuleMap : DataMap<Type, IModule>, IModuleMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleMap"/> class.
        /// </summary>
        public ModuleMap()
            : base()
        {
        }

        #region Public Functions

        /// <summary>
        /// Registers the module.
        /// </summary>
        /// <param name="module">The module.</param>
        public void RegisterModule(IModule module)
        {
            Register(module.GetType(), module);
        }

        /// <summary>
        /// Retrieves the module.
        /// </summary>
        /// <param name="moduleType">Type of the module.</param>
        /// <returns>
        /// The module object.
        /// </returns>
        public IModule RetrieveModule(Type moduleType)
        {
            return Retrieve(moduleType);
        }

        /// <summary>
        /// Removes the module.
        /// </summary>
        /// <param name="moduleType">Type of the module.</param>
        public void RemoveModule(Type moduleType)
        {
            Remove(moduleType);
        }

        #endregion Public Functions
    }
}