using UnityEngine;

namespace Patterns.Visitor
{
    public interface IVisitor
    {
        void Visit<T>(T p_visitable) where T : Component, IVisitable;
    }

    public interface IVisitable
    {
        void Accept(IVisitor p_visitor);
    }
}
