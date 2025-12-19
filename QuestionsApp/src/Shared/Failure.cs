using System.Collections;

namespace Shared;

public class Failure : IEnumerable<Error>
{
    private readonly List<Error> _errors;

    public Failure(IEnumerable<Error> errors)
    {
        // Полная копия
        _errors = [..errors];
    }

    public IEnumerator<Error> GetEnumerator()
    {
        return _errors.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static implicit operator Failure(Error[] errors) => new(errors);

    public static implicit operator Failure(Error error) => new([error]);
}