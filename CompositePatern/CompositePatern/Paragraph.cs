using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }

        public void Add(IDocumentComponent component)
        {
            throw new NotImplementedException("Paragraph cannot contain other components.");
        }

        public void Remove(IDocumentComponent component)
        {
            throw new NotImplementedException("Paragraph cannot contain other components.");
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}Paragraph: {_text}");
        }
    }

}
