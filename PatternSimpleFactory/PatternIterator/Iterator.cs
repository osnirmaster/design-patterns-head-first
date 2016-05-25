﻿namespace PatternIteratorComposite
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}