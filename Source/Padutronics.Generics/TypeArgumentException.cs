using System;

namespace Padutronics.Generics;

public sealed class TypeArgumentException : ArgumentException
{
    public TypeArgumentException() :
        this(message: string.Empty, typeParameterName: null, innerException: null)
    {
    }

    public TypeArgumentException(string message) :
        this(message, typeParameterName: null, innerException: null)
    {
    }

    public TypeArgumentException(Exception? innerException) :
        this(message: string.Empty, typeParameterName: null, innerException)
    {
    }

    public TypeArgumentException(string message, string? typeParameterName) :
        this(message, typeParameterName, innerException: null)
    {
    }

    public TypeArgumentException(string message, Exception? innerException) :
        this(message, typeParameterName: null, innerException)
    {
    }

    public TypeArgumentException(string message, string? typeParameterName, Exception? innerException) :
        base(message, typeParameterName, innerException)
    {
    }
}