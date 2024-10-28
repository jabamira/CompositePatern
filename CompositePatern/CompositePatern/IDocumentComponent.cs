﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public interface IDocumentComponent
    {
        void Add(IDocumentComponent component);
        void Remove(IDocumentComponent component);
        void Display(string indent);
    }
}
