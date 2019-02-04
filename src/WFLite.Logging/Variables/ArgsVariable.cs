/*
 * ArgsVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using System.Collections.Generic;
using System.Linq;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.Logging.Variables
{
    public class ArgsVariable : OutVariable<object[]>
    {
        public IEnumerable<IOutVariable> Args
        {
            private get;
            set;
        }

        public ArgsVariable()
        {
        }

        public ArgsVariable(IEnumerable<IOutVariable> args)
        {
            Args = args;
        }

        protected sealed override object getValue()
        {
            return Args.Select(a => a.GetValueAsObject()).ToArray();
        }
    }
}