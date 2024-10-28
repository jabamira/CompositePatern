using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public class Section : IDocumentComponent
{
    private string _title;
    private List<IDocumentComponent> _components = new List<IDocumentComponent>();

    public Section(string title)
    {
        _title = title;
    }

    public void Add(IDocumentComponent component)
    {
        _components.Add(component);
    }

    public void Remove(IDocumentComponent component)
    {
        _components.Remove(component);
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}Section: {_title}");
        foreach (var component in _components)
        {
            component.Display(indent + "  ");
        }
    }
}

}
