/*
 * ArgsVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.Logging.Variables
{
    public class ArgsVariable : Variable
    {
        public IEnumerable<IVariable> Args
        {
            private get;
            set;
        }

        public ArgsVariable()
        {
        }

        public ArgsVariable(IEnumerable<IVariable> args, IConverter converter = null)
            : base(converter)
        {
            Args = args;
        }

        protected sealed override object getValue()
        {
            return Args.Select(a => a.GetValue()).ToArray();
        }

        protected sealed override void setValue(object value)
        {
            throw new NotSupportedException();
        }
    }
}