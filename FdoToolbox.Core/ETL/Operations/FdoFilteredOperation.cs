#region LGPL Header
// Copyright (C) 2009, Jackie Ng
// http://code.google.com/p/fdotoolbox, jumpinjackie@gmail.com
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
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
//
// See license.txt for more/additional licensing information
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace FdoToolbox.Core.ETL.Operations
{
    /// <summary>
    /// A pipeline operation that conditionally discards features sent to it
    /// </summary>
    public class FdoFilteredOperation : FdoOperationBase
    {
        private Predicate<FdoRow> _condition;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="condition">The predicate that determines which rows will be passed on</param>
        public FdoFilteredOperation(Predicate<FdoRow> condition)
        {
            _condition = condition;
        }

        /// <summary>
        /// Executes the operation
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public override IEnumerable<FdoRow> Execute(IEnumerable<FdoRow> rows)
        {
            foreach (FdoRow row in rows)
            {
                if (_condition(row))
                    yield return row;
            }
        }
    }
}
